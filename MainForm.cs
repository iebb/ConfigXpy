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
using Steamworks;
using System.Diagnostics;

namespace ConfigXpy
{
    public partial class MainForm : MaterialForm
    {
        private CSGO CSGOForm;
        public MainForm()
        {
            // InitializeComponent();
            CSGOForm = new CSGO();
            CSGOForm.Show();
        }
    }
}
