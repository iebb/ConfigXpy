using Steamworks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using Google.Protobuf;

namespace ConfigXpy
{

    public partial class CloudFile
    {
        public CloudFile(string fileName, string fileType, string fileRelativePath, int fileLength, byte[] fileContents)
        {
            this.filename_ = fileName;
            this.filetype_ = fileType;
            this.relativePath_ = fileRelativePath;
            this.length_ = fileLength;
            this.contents_ = ByteString.CopyFrom(fileContents);
        }
    }
    public partial class CloudStorage
    {
        public CloudStorage(string saveSlot)
        {
            this.saveSlot_ = saveSlot;
        }

        public void AddFile(CloudFile cloudFile)
        {
            this.files_.Add(cloudFile);
        }
        public void AddUTF8File(FileInfo file, string fileType)
        {
            using (var sr = new StreamReader(file.FullName))
            {
                string fileContent = sr.ReadToEnd();
                byte[] bytes = Encoding.UTF8.GetBytes(fileContent);
                this.files_.Add(new CloudFile(file.Name, fileType, file.Name, bytes.Length, bytes));
            }
        }
        public void AddBinaryFile(FileInfo file, string fileType)
        {
            using (FileStream fs = File.Open(file.FullName, FileMode.Open))
            {
                byte[] data = new BinaryReader(fs).ReadBytes((int)fs.Length);
                this.files_.Add(new CloudFile(file.Name, fileType, file.Name, data.Length, data));
            }
        }
        public void WriteToDir(string basePath)
        {
            foreach (var item in this.files_)
            {
                var fullName = Path.Join(basePath, item.Filename);
                using (FileStream fs = File.Open(fullName, FileMode.OpenOrCreate))
                {
                    var bw = new BinaryWriter(fs);
                    byte[] data = item.Contents.ToByteArray();
                    bw.Write(data);
                }
            }
        }

    }

    internal class CloudFs
    {
        public bool IsAvailable = false;
        public string AppId = "0";
        public CloudFs(string appId)
        {
            IsAvailable = SteamRemoteStorage.IsCloudEnabledForAccount() && SteamRemoteStorage.IsCloudEnabledForApp();
            SteamRemoteStorage.SetCloudEnabledForApp(true);
            AppId = appId;
        }

        public bool WriteCloudStorage(CloudStorage cs)
        {
            if (!IsAvailable)
            {
                return false;
            }

            string fileName = String.Format("{0}-{1}", AppId, cs.SaveSlot);
            byte[] bytes = cs.ToByteArray();
            var fw = SteamRemoteStorage.FileWrite(fileName, bytes, bytes.Length);
            return fw;
        }
        public CloudStorage? ReadCloudStorage(string saveSlot)
        {
            if (!IsAvailable)
            {
                return null;
            }

            string fileName = String.Format("{0}-{1}", AppId, saveSlot);

            var size = SteamRemoteStorage.GetFileSize(fileName);

            if (size <= 0)
                return null;

            var buffer = new byte[size];
            SteamRemoteStorage.FileRead(fileName, buffer, buffer.Length);
            return CloudStorage.Parser.ParseFrom(buffer);
        }
        public bool CloudSaveExists(string saveSlot)
        {
            if (!IsAvailable)
            {
                return false;
            }

            string resultName = String.Format("{0}-{1}", AppId, saveSlot);
            return SteamRemoteStorage.FileExists(resultName);
        }
        /*
        public bool ListFiles()
        {
            if (!IsAvailable)
            {
                return false;
            }
            SteamRemoteStorage.

            string resultName = String.Format("%s/%s/%s/%s", AppId, saveSlot, fileType, fileName);

            // var m_RemoteStorageFileWriteAsyncComplete_t = CallResult<RemoteStorageFileWriteAsyncComplete_t>.Create();

            using (var sr = new StreamReader(file.FullName))
            {
                string fileContent = sr.ReadToEnd();
                byte[] bytes = Encoding.UTF8.GetBytes(fileContent);
                // var handle = SteamRemoteStorage.FileWriteAsync(resultName, bytes, (uint)bytes.Length);
                var handle = SteamRemoteStorage.FileWrite(resultName, bytes, bytes.Length);
                // m_RemoteStorageFileWriteAsyncComplete_t.Set(handle, callback.Invoke);
            }
            return true;

        }*/
    }
}
