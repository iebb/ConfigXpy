namespace ConfigXpy
{
    partial class CSGO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSGO));
            materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            cmbSource = new MaterialSkin.Controls.MaterialComboBox();
            cmbDest = new MaterialSkin.Controls.MaterialComboBox();
            chkCopyCfg = new MaterialSkin.Controls.MaterialCheckbox();
            btnCopy = new MaterialSkin.Controls.MaterialButton();
            materialTextBoxLaunch = new MaterialSkin.Controls.MaterialTextBox();
            chkVideo = new MaterialSkin.Controls.MaterialCheckbox();
            materialDestLaunch = new MaterialSkin.Controls.MaterialTextBox();
            chkLaunchOptions = new MaterialSkin.Controls.MaterialCheckbox();
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            tabPage2 = new System.Windows.Forms.TabPage();
            labelStatusDL = new System.Windows.Forms.Label();
            labelStatusUL = new System.Windows.Forms.Label();
            configDownloader = new MaterialSkin.Controls.MaterialButton();
            cmbCloudSync = new MaterialSkin.Controls.MaterialComboBox();
            materialCloudLaunch = new MaterialSkin.Controls.MaterialTextBox();
            configUploader = new MaterialSkin.Controls.MaterialButton();
            materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            materialTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // materialDrawer1
            // 
            materialDrawer1.AutoHide = false;
            materialDrawer1.AutoShow = false;
            materialDrawer1.BackgroundWithAccent = false;
            materialDrawer1.BaseTabControl = null;
            materialDrawer1.Depth = 0;
            materialDrawer1.HighlightWithAccent = true;
            materialDrawer1.IndicatorWidth = 0;
            materialDrawer1.IsOpen = false;
            materialDrawer1.Location = new System.Drawing.Point(-250, 155);
            materialDrawer1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDrawer1.Name = "materialDrawer1";
            materialDrawer1.ShowIconsWhenHidden = false;
            materialDrawer1.Size = new System.Drawing.Size(250, 120);
            materialDrawer1.TabIndex = 2;
            materialDrawer1.Text = "materialDrawer1";
            materialDrawer1.UseColors = false;
            // 
            // cmbSource
            // 
            cmbSource.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cmbSource.AutoResize = false;
            cmbSource.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            cmbSource.Depth = 0;
            cmbSource.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            cmbSource.DropDownHeight = 174;
            cmbSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbSource.DropDownWidth = 121;
            cmbSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            cmbSource.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            cmbSource.FormattingEnabled = true;
            cmbSource.Hint = "From Account / 源账号";
            cmbSource.IntegralHeight = false;
            cmbSource.ItemHeight = 43;
            cmbSource.Location = new System.Drawing.Point(19, 21);
            cmbSource.MaxDropDownItems = 4;
            cmbSource.MouseState = MaterialSkin.MouseState.OUT;
            cmbSource.Name = "cmbSource";
            cmbSource.Size = new System.Drawing.Size(881, 49);
            cmbSource.StartIndex = 0;
            cmbSource.TabIndex = 3;
            cmbSource.SelectedIndexChanged += cmbSource_SelectedIndexChanged;
            // 
            // cmbDest
            // 
            cmbDest.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cmbDest.AutoResize = false;
            cmbDest.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            cmbDest.Depth = 0;
            cmbDest.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            cmbDest.DropDownHeight = 174;
            cmbDest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbDest.DropDownWidth = 121;
            cmbDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            cmbDest.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            cmbDest.FormattingEnabled = true;
            cmbDest.Hint = "To Account / 复制到";
            cmbDest.IntegralHeight = false;
            cmbDest.ItemHeight = 43;
            cmbDest.Location = new System.Drawing.Point(19, 153);
            cmbDest.MaxDropDownItems = 4;
            cmbDest.MouseState = MaterialSkin.MouseState.OUT;
            cmbDest.Name = "cmbDest";
            cmbDest.Size = new System.Drawing.Size(881, 49);
            cmbDest.StartIndex = 0;
            cmbDest.TabIndex = 4;
            cmbDest.SelectedIndexChanged += cmbDest_SelectedIndexChanged;
            // 
            // chkCopyCfg
            // 
            chkCopyCfg.AutoSize = true;
            chkCopyCfg.Checked = true;
            chkCopyCfg.CheckState = System.Windows.Forms.CheckState.Checked;
            chkCopyCfg.Depth = 0;
            chkCopyCfg.Location = new System.Drawing.Point(10, 464);
            chkCopyCfg.Margin = new System.Windows.Forms.Padding(0);
            chkCopyCfg.MouseLocation = new System.Drawing.Point(-1, -1);
            chkCopyCfg.MouseState = MaterialSkin.MouseState.HOVER;
            chkCopyCfg.Name = "chkCopyCfg";
            chkCopyCfg.ReadOnly = false;
            chkCopyCfg.Ripple = true;
            chkCopyCfg.Size = new System.Drawing.Size(82, 37);
            chkCopyCfg.TabIndex = 5;
            chkCopyCfg.Text = "Config";
            chkCopyCfg.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            btnCopy.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnCopy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnCopy.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCopy.Depth = 0;
            btnCopy.HighEmphasis = true;
            btnCopy.Icon = null;
            btnCopy.Location = new System.Drawing.Point(790, 282);
            btnCopy.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnCopy.MouseState = MaterialSkin.MouseState.HOVER;
            btnCopy.Name = "btnCopy";
            btnCopy.NoAccentTextColor = System.Drawing.Color.Empty;
            btnCopy.Size = new System.Drawing.Size(110, 36);
            btnCopy.TabIndex = 7;
            btnCopy.Text = "复制 Config";
            btnCopy.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCopy.UseAccentColor = false;
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // materialTextBoxLaunch
            // 
            materialTextBoxLaunch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            materialTextBoxLaunch.AnimateReadOnly = true;
            materialTextBoxLaunch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            materialTextBoxLaunch.Depth = 0;
            materialTextBoxLaunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            materialTextBoxLaunch.Hint = "Launch Options / 启动项";
            materialTextBoxLaunch.LeadingIcon = null;
            materialTextBoxLaunch.Location = new System.Drawing.Point(19, 76);
            materialTextBoxLaunch.MaxLength = 50;
            materialTextBoxLaunch.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxLaunch.Multiline = false;
            materialTextBoxLaunch.Name = "materialTextBoxLaunch";
            materialTextBoxLaunch.ReadOnly = true;
            materialTextBoxLaunch.Size = new System.Drawing.Size(881, 50);
            materialTextBoxLaunch.TabIndex = 11;
            materialTextBoxLaunch.Text = " ";
            materialTextBoxLaunch.TrailingIcon = null;
            // 
            // chkVideo
            // 
            chkVideo.AutoSize = true;
            chkVideo.Checked = true;
            chkVideo.CheckState = System.Windows.Forms.CheckState.Checked;
            chkVideo.Depth = 0;
            chkVideo.Location = new System.Drawing.Point(112, 464);
            chkVideo.Margin = new System.Windows.Forms.Padding(0);
            chkVideo.MouseLocation = new System.Drawing.Point(-1, -1);
            chkVideo.MouseState = MaterialSkin.MouseState.HOVER;
            chkVideo.Name = "chkVideo";
            chkVideo.ReadOnly = false;
            chkVideo.Ripple = true;
            chkVideo.Size = new System.Drawing.Size(216, 37);
            chkVideo.TabIndex = 12;
            chkVideo.Text = "Video Settings / 显示设置";
            chkVideo.UseVisualStyleBackColor = true;
            // 
            // materialDestLaunch
            // 
            materialDestLaunch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            materialDestLaunch.AnimateReadOnly = true;
            materialDestLaunch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            materialDestLaunch.Depth = 0;
            materialDestLaunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            materialDestLaunch.Hint = "Launch Options / 启动项";
            materialDestLaunch.LeadingIcon = null;
            materialDestLaunch.Location = new System.Drawing.Point(19, 208);
            materialDestLaunch.MaxLength = 50;
            materialDestLaunch.MouseState = MaterialSkin.MouseState.OUT;
            materialDestLaunch.Multiline = false;
            materialDestLaunch.Name = "materialDestLaunch";
            materialDestLaunch.ReadOnly = true;
            materialDestLaunch.Size = new System.Drawing.Size(881, 50);
            materialDestLaunch.TabIndex = 13;
            materialDestLaunch.Text = " ";
            materialDestLaunch.TrailingIcon = null;
            // 
            // chkLaunchOptions
            // 
            chkLaunchOptions.AutoSize = true;
            chkLaunchOptions.Checked = true;
            chkLaunchOptions.CheckState = System.Windows.Forms.CheckState.Checked;
            chkLaunchOptions.Depth = 0;
            chkLaunchOptions.Location = new System.Drawing.Point(358, 464);
            chkLaunchOptions.Margin = new System.Windows.Forms.Padding(0);
            chkLaunchOptions.MouseLocation = new System.Drawing.Point(-1, -1);
            chkLaunchOptions.MouseState = MaterialSkin.MouseState.HOVER;
            chkLaunchOptions.Name = "chkLaunchOptions";
            chkLaunchOptions.ReadOnly = false;
            chkLaunchOptions.Ripple = true;
            chkLaunchOptions.Size = new System.Drawing.Size(356, 37);
            chkLaunchOptions.TabIndex = 14;
            chkLaunchOptions.Text = "Launch Options / 启动项（需要重启 Steam）";
            chkLaunchOptions.UseVisualStyleBackColor = true;
            // 
            // materialTabControl1
            // 
            materialTabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            materialTabControl1.Controls.Add(tabPage1);
            materialTabControl1.Controls.Add(tabPage2);
            materialTabControl1.Depth = 0;
            materialTabControl1.Location = new System.Drawing.Point(6, 108);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new System.Drawing.Size(926, 357);
            materialTabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = System.Drawing.Color.Transparent;
            tabPage1.Controls.Add(cmbSource);
            tabPage1.Controls.Add(cmbDest);
            tabPage1.Controls.Add(materialTextBoxLaunch);
            tabPage1.Controls.Add(materialDestLaunch);
            tabPage1.Controls.Add(btnCopy);
            tabPage1.ForeColor = System.Drawing.Color.White;
            tabPage1.Location = new System.Drawing.Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(918, 327);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "复制";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(labelStatusDL);
            tabPage2.Controls.Add(labelStatusUL);
            tabPage2.Controls.Add(configDownloader);
            tabPage2.Controls.Add(cmbCloudSync);
            tabPage2.Controls.Add(materialCloudLaunch);
            tabPage2.Controls.Add(configUploader);
            tabPage2.Location = new System.Drawing.Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(918, 327);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "云同步";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelStatusDL
            // 
            labelStatusDL.AutoSize = true;
            labelStatusDL.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelStatusDL.Location = new System.Drawing.Point(235, 204);
            labelStatusDL.Name = "labelStatusDL";
            labelStatusDL.Size = new System.Drawing.Size(15, 21);
            labelStatusDL.TabIndex = 16;
            labelStatusDL.Text = " ";
            // 
            // labelStatusUL
            // 
            labelStatusUL.AutoSize = true;
            labelStatusUL.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelStatusUL.Location = new System.Drawing.Point(235, 156);
            labelStatusUL.Name = "labelStatusUL";
            labelStatusUL.Size = new System.Drawing.Size(15, 21);
            labelStatusUL.TabIndex = 15;
            labelStatusUL.Text = " ";
            // 
            // configDownloader
            // 
            configDownloader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            configDownloader.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            configDownloader.Depth = 0;
            configDownloader.HighEmphasis = true;
            configDownloader.Icon = null;
            configDownloader.Location = new System.Drawing.Point(19, 192);
            configDownloader.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            configDownloader.MouseState = MaterialSkin.MouseState.HOVER;
            configDownloader.Name = "configDownloader";
            configDownloader.NoAccentTextColor = System.Drawing.Color.Empty;
            configDownloader.Size = new System.Drawing.Size(196, 36);
            configDownloader.TabIndex = 14;
            configDownloader.Text = "从云端下载配置写入账号";
            configDownloader.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            configDownloader.UseAccentColor = false;
            configDownloader.UseVisualStyleBackColor = true;
            configDownloader.Click += configDownloader_Click;
            // 
            // cmbCloudSync
            // 
            cmbCloudSync.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cmbCloudSync.AutoResize = false;
            cmbCloudSync.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            cmbCloudSync.Depth = 0;
            cmbCloudSync.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            cmbCloudSync.DropDownHeight = 174;
            cmbCloudSync.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbCloudSync.DropDownWidth = 121;
            cmbCloudSync.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            cmbCloudSync.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            cmbCloudSync.FormattingEnabled = true;
            cmbCloudSync.Hint = "Sync Account";
            cmbCloudSync.IntegralHeight = false;
            cmbCloudSync.ItemHeight = 43;
            cmbCloudSync.Location = new System.Drawing.Point(19, 21);
            cmbCloudSync.MaxDropDownItems = 4;
            cmbCloudSync.MouseState = MaterialSkin.MouseState.OUT;
            cmbCloudSync.Name = "cmbCloudSync";
            cmbCloudSync.Size = new System.Drawing.Size(881, 49);
            cmbCloudSync.StartIndex = 0;
            cmbCloudSync.TabIndex = 12;
            cmbCloudSync.SelectedIndexChanged += cmbCloudSync_SelectedIndexChanged;
            // 
            // materialCloudLaunch
            // 
            materialCloudLaunch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            materialCloudLaunch.AnimateReadOnly = true;
            materialCloudLaunch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            materialCloudLaunch.Depth = 0;
            materialCloudLaunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            materialCloudLaunch.Hint = "Launch Options / 启动项";
            materialCloudLaunch.LeadingIcon = null;
            materialCloudLaunch.Location = new System.Drawing.Point(19, 76);
            materialCloudLaunch.MaxLength = 50;
            materialCloudLaunch.MouseState = MaterialSkin.MouseState.OUT;
            materialCloudLaunch.Multiline = false;
            materialCloudLaunch.Name = "materialCloudLaunch";
            materialCloudLaunch.ReadOnly = true;
            materialCloudLaunch.Size = new System.Drawing.Size(881, 50);
            materialCloudLaunch.TabIndex = 13;
            materialCloudLaunch.Text = " ";
            materialCloudLaunch.TrailingIcon = null;
            // 
            // configUploader
            // 
            configUploader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            configUploader.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            configUploader.Depth = 0;
            configUploader.HighEmphasis = true;
            configUploader.Icon = null;
            configUploader.Location = new System.Drawing.Point(19, 144);
            configUploader.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            configUploader.MouseState = MaterialSkin.MouseState.HOVER;
            configUploader.Name = "configUploader";
            configUploader.NoAccentTextColor = System.Drawing.Color.Empty;
            configUploader.Size = new System.Drawing.Size(196, 36);
            configUploader.TabIndex = 0;
            configUploader.Text = "将该账号配置上传至云端";
            configUploader.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            configUploader.UseAccentColor = false;
            configUploader.UseVisualStyleBackColor = true;
            configUploader.Click += configUploader_Click;
            // 
            // materialTabSelector1
            // 
            materialTabSelector1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            materialTabSelector1.BaseTabControl = materialTabControl1;
            materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            materialTabSelector1.Depth = 0;
            materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialTabSelector1.Location = new System.Drawing.Point(0, 64);
            materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabSelector1.Name = "materialTabSelector1";
            materialTabSelector1.Size = new System.Drawing.Size(939, 48);
            materialTabSelector1.TabIndex = 17;
            materialTabSelector1.Text = "tabSelector";
            // 
            // CSGO
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(938, 500);
            Controls.Add(materialTabSelector1);
            Controls.Add(materialTabControl1);
            Controls.Add(chkLaunchOptions);
            Controls.Add(chkVideo);
            Controls.Add(chkCopyCfg);
            Controls.Add(materialDrawer1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximumSize = new System.Drawing.Size(1080, 500);
            MinimumSize = new System.Drawing.Size(500, 500);
            Name = "CSGO";
            Text = "CS:GO Config 复制器";
            Load += CSGOForm_Load;
            materialTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private MaterialSkin.Controls.MaterialComboBox cmbSource;
        private MaterialSkin.Controls.MaterialComboBox cmbDest;
        private MaterialSkin.Controls.MaterialCheckbox chkCopyCfg;
        private MaterialSkin.Controls.MaterialButton btnCopy;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxLaunch;
        private MaterialSkin.Controls.MaterialCheckbox chkVideo;
        private MaterialSkin.Controls.MaterialTextBox materialDestLaunch;
        private MaterialSkin.Controls.MaterialCheckbox chkLaunchOptions;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private MaterialSkin.Controls.MaterialButton configUploader;
        private MaterialSkin.Controls.MaterialButton configDownloader;
        private MaterialSkin.Controls.MaterialComboBox cmbCloudSync;
        private MaterialSkin.Controls.MaterialTextBox materialCloudLaunch;
        private System.Windows.Forms.Label labelStatusUL;
        private System.Windows.Forms.Label labelStatusDL;
    }
}