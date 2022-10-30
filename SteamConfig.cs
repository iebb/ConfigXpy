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
    public static class VdfExtensions
    {
        public static VToken Get(this VToken obj, string key)
        {
            return obj.Children<VProperty>().First(x => x.Key.Equals(key, StringComparison.InvariantCultureIgnoreCase)).Value;
        }
    }

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
                VToken? launchOptions = vdfConfig?.Get("Software")?.Get("Valve")?.Get("Steam")?.Get("apps")?.Get(TargetAppId)?.Get("LaunchOptions");
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
                VToken? apps = vdfConfig?.Get("Software")?.Get("Valve")?.Get("Steam")?.Get("apps");
                if (apps == null) return false;
                VObject appNode;

                if (apps[TargetAppId] == null) apps[TargetAppId] = new VObject();
                appNode = (VObject)apps[TargetAppId];

                var launchKey = "LaunchOptions";
                var targetKey = appNode.Children<VProperty>().First(x => x.Key.Equals(launchKey, StringComparison.InvariantCultureIgnoreCase));
                if (targetKey != null)
                {
                    appNode[targetKey.Key] = launchOpt;
                } 
                else
                {
                    appNode[launchKey] = launchOpt;
                }
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
