using Gameloop.Vdf.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigXpy
{
    internal class SteamConfig
    {
        // Int32 steamID;
        public string steamID;
        public string username;
        public string userdataDir;
        public VToken vdfConfig;

        public SteamConfig(string steamID, string userdataDir, string username, VToken vdfConfig)
        {
            this.steamID = steamID;
            this.userdataDir = userdataDir;
            this.username = username;
            this.vdfConfig = vdfConfig;
        }

        public string GetLaunchOptions()
        {
            try
            {
                VToken? Software = vdfConfig["Software"];
                if (Software == null) return "";
                VToken? Valve = Software["Valve"];
                if (Valve == null) return "";
                VToken? Steam = Valve["Steam"];
                if (Steam == null) return "";
                VToken? apps = Steam["apps"];
                if (apps == null) return "";
                VToken? goConfig = apps["730"];
                if (goConfig == null) return "";
                VToken? launchOptions = goConfig["LaunchOptions"];
                if (launchOptions == null) return "";
                return launchOptions.ToString();
            }
            catch (Exception) { return ""; }
        }
        public string GetConfigPath()
        {
            return userdataDir + "\\730\\local\\cfg\\";
        }
    }
}
