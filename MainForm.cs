using Gameloop.Vdf;
using Gameloop.Vdf.Linq;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Linq;

namespace ConfigXpy
{
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        List<SteamConfig> configs = new List<SteamConfig>();
        string currentActiveUser = "";

        public MainForm()
        {
            InitializeComponent();
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            FindConfigs();
            var index = 0;
            foreach(var config in configs)
            {
                var nameTag = config.steamID + " - " + config.username;
                if (config.steamID == currentActiveUser)
                {
                    nameTag += " (Current)";
                }
                cmbSource.Items.Add(nameTag);
                cmbDest.Items.Add(nameTag);
                if (config.steamID == currentActiveUser)
                {
                    cmbDest.SelectedIndex = index;
                    cmbSource.SelectedIndex = index;

                    materialTextBoxLaunch.Text = configs[cmbSource.SelectedIndex].GetLaunchOptions().ToString();
                    materialDestLaunch.Text = configs[cmbDest.SelectedIndex].GetLaunchOptions().ToString();

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
            btnCopy.Text = "Replicate";
            btnCopy.UseAccentColor = false;
        }

        private void cmbDest_SelectedIndexChanged(object sender, EventArgs e)
        {
            var launch = configs[cmbDest.SelectedIndex].GetLaunchOptions();
            materialDestLaunch.Text = launch.ToString();
            btnCopy.Enabled = (cmbDest.SelectedIndex != cmbSource.SelectedIndex);
            btnCopy.Text = "Replicate";
            btnCopy.UseAccentColor = false;
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
    }
}
