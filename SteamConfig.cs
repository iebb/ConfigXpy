using Gameloop.Vdf;
using Gameloop.Vdf.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigXpy
{
    internal class SteamConfig
    {
        const string TargetAppId = "730";

        public Int32 steamIDInt;
        public string steamID;
        public string username;
        public string fileName;
        public string userdataDir;
        public VToken vdfConfig;
        public VProperty vProperty;

        public SteamConfig(string userdataDir)
        {

            this.userdataDir = userdataDir;
            var baseName = Path.GetFileName(userdataDir);
            this.steamID = baseName;
            this.steamIDInt = Int32.Parse(baseName);

            this.fileName = userdataDir + "\\config\\localconfig.vdf";
            if (!File.Exists(this.fileName))
            {
                throw new Exception("Local config not found");
            }
            var content = File.ReadAllText(this.fileName);

            this.vProperty = VdfConvert.Deserialize(
                content, new VdfSerializerSettings()
                {
                    MaximumTokenSize = 65536,
                    UsesEscapeSequences = true
                }
            );
            this.vdfConfig = vProperty.Value;

            try
            {
                VToken? vPersonaName = vdfConfig["friends"]?["PersonaName"];
                if (vPersonaName != null)
                {
                    this.username = vPersonaName.ToString();
                }
            }
            catch (Exception) { }
        }

        public string GetLaunchOptions()
        {
            var content = File.ReadAllText(this.fileName);
            this.vProperty = VdfConvert.Deserialize(
                content, new VdfSerializerSettings()
                {
                    MaximumTokenSize = 65536,
                    UsesEscapeSequences = true
                }
            );
            this.vdfConfig = vProperty.Value;

            try
            {
                VToken? launchOptions = vdfConfig["Software"]?["Valve"]?["Steam"]?["apps"]?[TargetAppId]?["LaunchOptions"];
                if (launchOptions == null) return "";
                return launchOptions.ToString();
            }
            catch (Exception) { return ""; }
        }
        public bool WriteLaunchOptions(string launchOptions)
        {
            try
            {
                VValue launchOpt = new VValue(launchOptions);
                VToken? apps = vdfConfig["Software"]?["Valve"]?["Steam"]?["apps"];
                if (apps == null) return false;
                if (apps[TargetAppId] == null)
                {
                    apps[TargetAppId] = new VObject();
                }
                apps[TargetAppId]["LaunchOptions"] = launchOpt;
            }
            catch (Exception) { return false; }
            string s = VdfConvert.Serialize(this.vProperty);
            File.WriteAllText(this.fileName, s);
            return true;
        }
        public string GetConfigPath()
        {
            return userdataDir + "\\" + TargetAppId + "\\local\\cfg\\";
        }
    }
}
