using Google.Protobuf;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Win32;
using Steamworks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfigXpy
{
    public partial class CSGO : MaterialForm
    {

        private readonly MaterialSkinManager materialSkinManager;
        List<SteamConfig> configs = new List<SteamConfig>();
        string currentActiveUser = "";
        CloudFs cloud = new CloudFs("730");
        string saveSlot = "1";

        public CSGO()
        {
            InitializeComponent();

            if (!cloud.CloudSaveExists(saveSlot))
            {
                configDownloader.Enabled = false;
            }

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple500, Primary.DeepPurple700, Primary.DeepPurple100, Accent.Pink200, TextShade.WHITE);

        }

        public void FindConfigs()
        {
            configs.Clear();


            const string keyActiveProcess = "HKEY_CURRENT_USER\\Software\\Valve\\Steam\\ActiveProcess";
            var activeUser = Registry.GetValue(keyActiveProcess, "ActiveUser", 0);
            if (activeUser != null)
            {
                currentActiveUser = activeUser.ToString();
            }

            const string keyName = "HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\Valve\\Steam";
            var steamInstallPath = Registry.GetValue(keyName, "InstallPath", "");
            if (steamInstallPath == null) return;
            var userData = steamInstallPath.ToString() + "\\userdata\\";
            var directories = Directory.GetDirectories(userData);
            foreach (var directory in directories)
            {
                try
                {
                    configs.Add(new SteamConfig(directory));
                }
                catch (Exception) { }
            }

            configs = configs.OrderBy(o => Int32.Parse(o.steamID)).ToList();
        }

        private void CSGOForm_Load(object sender, EventArgs e)
        {
            FindConfigs();
            var index = 0;
            foreach (var config in configs)
            {
                var nameTag = config.steamID + " - " + config.username;
                if (config.steamID == currentActiveUser)
                {
                    nameTag += " (Current)";
                }
                cmbSource.Items.Add(nameTag);
                cmbDest.Items.Add(nameTag);
                cmbCloudSync.Items.Add(nameTag);
                if (config.steamID == currentActiveUser)
                {
                    cmbDest.SelectedIndex = index;
                    cmbSource.SelectedIndex = index;
                    cmbCloudSync.SelectedIndex = index;

                    materialTextBoxLaunch.Text = configs[cmbSource.SelectedIndex].GetLaunchOptions().ToString();
                    materialDestLaunch.Text = configs[cmbDest.SelectedIndex].GetLaunchOptions().ToString();
                    materialCloudLaunch.Text = configs[cmbCloudSync.SelectedIndex].GetLaunchOptions().ToString();

                    btnCopy.Enabled = false;
                    btnCopy.UseAccentColor = false;
                }
                index++;
            }
        }

        private void cmbSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            var launch = configs[cmbSource.SelectedIndex].GetLaunchOptions();
            materialTextBoxLaunch.Text = launch.ToString();
            btnCopy.Enabled = (cmbDest.SelectedIndex != cmbSource.SelectedIndex);
            btnCopy.Text = "复制 Config";
            btnCopy.UseAccentColor = false;
        }

        private void cmbDest_SelectedIndexChanged(object sender, EventArgs e)
        {
            var launch = configs[cmbDest.SelectedIndex].GetLaunchOptions();
            materialDestLaunch.Text = launch.ToString();
            btnCopy.Enabled = (cmbDest.SelectedIndex != cmbSource.SelectedIndex);
            btnCopy.Text = "复制 Config";
            btnCopy.UseAccentColor = false;
        }

        private void cmbCloudSync_SelectedIndexChanged(object sender, EventArgs e)
        {
            var launch = configs[cmbCloudSync.SelectedIndex].GetLaunchOptions();
            materialCloudLaunch.Text = launch.ToString();
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {

            if (cmbSource.SelectedIndex >= 0 && cmbDest.SelectedIndex >= 0)
            {
                var sourceDir = configs[cmbSource.SelectedIndex].GetConfigPath();
                var targetDir = configs[cmbDest.SelectedIndex].GetConfigPath();
                Directory.CreateDirectory(targetDir);
                var files = Directory.GetFiles(sourceDir);
                int cnt = 0;
                foreach (var file in files)
                {
                    if ((file.EndsWith(".cfg") && chkCopyCfg.Checked) || (file.EndsWith(".txt") && chkVideo.Checked))
                    {
                        var target = targetDir + Path.GetFileName(file);
                        var sourceFile = new FileInfo(file);
                        try
                        {
                            sourceFile.CopyTo(target, true);
                            cnt += 1;
                        }
                        catch (Exception) { }
                    }
                }

                if (chkLaunchOptions.Checked)
                {
                    configs[cmbDest.SelectedIndex].WriteLaunchOptions(
                        configs[cmbSource.SelectedIndex].GetLaunchOptions()
                    );
                    var launch = configs[cmbDest.SelectedIndex].GetLaunchOptions();
                    materialDestLaunch.Text = launch.ToString();
                }

                btnCopy.Text = String.Format("{0} copied", cnt);
                btnCopy.UseAccentColor = true;
            }
        }

        private void configUploader_Click(object sender, EventArgs e)
        {

            if (cmbCloudSync.SelectedIndex >= 0)
            {
                var sourceDir = configs[cmbCloudSync.SelectedIndex].GetConfigPath();
                var launchOptions = configs[cmbCloudSync.SelectedIndex].GetLaunchOptions();
                var files = Directory.GetFiles(sourceDir);

                var cloudStorage = new CloudStorage(saveSlot);
                cloudStorage.LaunchOptions = launchOptions;
                foreach (var file in files)
                {
                    if (file.EndsWith(".cfg"))
                    {
                        var sourceFile = new FileInfo(file);
                        if (sourceFile.Length >= 524288) continue;
                        cloudStorage.AddUTF8File(sourceFile, "cfg");
                    }
                    else if (file.EndsWith("video.txt"))
                    {
                        var sourceFile = new FileInfo(file);
                        if (sourceFile.Length >= 524288) continue;
                        cloudStorage.AddUTF8File(sourceFile, "video");
                    }
                }
                if (cloud.WriteCloudStorage(cloudStorage))
                {
                    configDownloader.Enabled = true;
                    labelStatusUL.Text = "上传成功";
                    labelStatusUL.ForeColor = Color.Green;
                }
                else
                {
                    labelStatusUL.Text = "上传失败，请检查空间是否足够";
                    labelStatusUL.ForeColor = Color.Red;
                }

            }
        }

        private void configDownloader_Click(object sender, EventArgs e)
        {
            if (cmbCloudSync.SelectedIndex >= 0)
            {
                var sourceDir = configs[cmbCloudSync.SelectedIndex].GetConfigPath();
                var cloudStorage = cloud.ReadCloudStorage(saveSlot);
                if (cloudStorage != null)
                {
                    cloudStorage.WriteToDir(sourceDir);
                    if (chkLaunchOptions.Checked && cloudStorage.LaunchOptions != null)
                    {
                        configs[cmbCloudSync.SelectedIndex].WriteLaunchOptions(
                            cloudStorage.LaunchOptions
                        );
                        var launch = configs[cmbCloudSync.SelectedIndex].GetLaunchOptions();
                        materialCloudLaunch.Text = launch.ToString();
                    }
                    labelStatusDL.Text = "下载并写入成功!";
                    labelStatusDL.ForeColor = Color.Green;
                }
                else
                {
                    labelStatusDL.Text = "下载失败";
                    labelStatusDL.ForeColor = Color.Red;
                }
            }
        }

    }
}
