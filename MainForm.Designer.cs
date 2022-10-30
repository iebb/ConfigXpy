namespace ConfigXpy
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            this.cmbSource = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbDest = new MaterialSkin.Controls.MaterialComboBox();
            this.chkCopyCfg = new MaterialSkin.Controls.MaterialCheckbox();
            this.btnCopy = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.materialTextBoxLaunch = new MaterialSkin.Controls.MaterialTextBox();
            this.chkVideo = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialDestLaunch = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // materialDrawer1
            // 
            this.materialDrawer1.AutoHide = false;
            this.materialDrawer1.AutoShow = false;
            this.materialDrawer1.BackgroundWithAccent = false;
            this.materialDrawer1.BaseTabControl = null;
            this.materialDrawer1.Depth = 0;
            this.materialDrawer1.HighlightWithAccent = true;
            this.materialDrawer1.IndicatorWidth = 0;
            this.materialDrawer1.IsOpen = false;
            this.materialDrawer1.Location = new System.Drawing.Point(-250, 155);
            this.materialDrawer1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDrawer1.Name = "materialDrawer1";
            this.materialDrawer1.ShowIconsWhenHidden = false;
            this.materialDrawer1.Size = new System.Drawing.Size(250, 120);
            this.materialDrawer1.TabIndex = 2;
            this.materialDrawer1.Text = "materialDrawer1";
            this.materialDrawer1.UseColors = false;
            // 
            // cmbSource
            // 
            this.cmbSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSource.AutoResize = false;
            this.cmbSource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbSource.Depth = 0;
            this.cmbSource.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbSource.DropDownHeight = 174;
            this.cmbSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSource.DropDownWidth = 121;
            this.cmbSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbSource.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbSource.FormattingEnabled = true;
            this.cmbSource.Hint = "From Account";
            this.cmbSource.IntegralHeight = false;
            this.cmbSource.ItemHeight = 43;
            this.cmbSource.Location = new System.Drawing.Point(20, 82);
            this.cmbSource.MaxDropDownItems = 4;
            this.cmbSource.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbSource.Name = "cmbSource";
            this.cmbSource.Size = new System.Drawing.Size(460, 49);
            this.cmbSource.StartIndex = 0;
            this.cmbSource.TabIndex = 3;
            this.cmbSource.SelectedIndexChanged += new System.EventHandler(this.cmbSource_SelectedIndexChanged);
            // 
            // cmbDest
            // 
            this.cmbDest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDest.AutoResize = false;
            this.cmbDest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbDest.Depth = 0;
            this.cmbDest.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbDest.DropDownHeight = 174;
            this.cmbDest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDest.DropDownWidth = 121;
            this.cmbDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbDest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbDest.FormattingEnabled = true;
            this.cmbDest.Hint = "To Account";
            this.cmbDest.IntegralHeight = false;
            this.cmbDest.ItemHeight = 43;
            this.cmbDest.Location = new System.Drawing.Point(20, 239);
            this.cmbDest.MaxDropDownItems = 4;
            this.cmbDest.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbDest.Name = "cmbDest";
            this.cmbDest.Size = new System.Drawing.Size(460, 49);
            this.cmbDest.StartIndex = 0;
            this.cmbDest.TabIndex = 4;
            this.cmbDest.SelectedIndexChanged += new System.EventHandler(this.cmbDest_SelectedIndexChanged);
            // 
            // chkCopyCfg
            // 
            this.chkCopyCfg.AutoSize = true;
            this.chkCopyCfg.Checked = true;
            this.chkCopyCfg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCopyCfg.Depth = 0;
            this.chkCopyCfg.Location = new System.Drawing.Point(20, 358);
            this.chkCopyCfg.Margin = new System.Windows.Forms.Padding(0);
            this.chkCopyCfg.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkCopyCfg.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkCopyCfg.Name = "chkCopyCfg";
            this.chkCopyCfg.ReadOnly = false;
            this.chkCopyCfg.Ripple = true;
            this.chkCopyCfg.Size = new System.Drawing.Size(82, 37);
            this.chkCopyCfg.TabIndex = 5;
            this.chkCopyCfg.Text = "Config";
            this.chkCopyCfg.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCopy.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCopy.Depth = 0;
            this.btnCopy.HighEmphasis = true;
            this.btnCopy.Icon = null;
            this.btnCopy.Location = new System.Drawing.Point(414, 359);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCopy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCopy.Size = new System.Drawing.Size(64, 36);
            this.btnCopy.TabIndex = 7;
            this.btnCopy.Text = "Copy";
            this.btnCopy.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCopy.UseAccentColor = false;
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("down_arrow")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(230, 191);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("down_arrow")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(420, 191);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("down_arrow")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(42, 191);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // materialTextBoxLaunch
            // 
            this.materialTextBoxLaunch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTextBoxLaunch.AnimateReadOnly = true;
            this.materialTextBoxLaunch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxLaunch.Depth = 0;
            this.materialTextBoxLaunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialTextBoxLaunch.Hint = "Launch Options";
            this.materialTextBoxLaunch.LeadingIcon = null;
            this.materialTextBoxLaunch.Location = new System.Drawing.Point(20, 137);
            this.materialTextBoxLaunch.MaxLength = 50;
            this.materialTextBoxLaunch.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxLaunch.Multiline = false;
            this.materialTextBoxLaunch.Name = "materialTextBoxLaunch";
            this.materialTextBoxLaunch.ReadOnly = true;
            this.materialTextBoxLaunch.Size = new System.Drawing.Size(460, 50);
            this.materialTextBoxLaunch.TabIndex = 11;
            this.materialTextBoxLaunch.Text = " ";
            this.materialTextBoxLaunch.TrailingIcon = null;
            // 
            // chkVideo
            // 
            this.chkVideo.AutoSize = true;
            this.chkVideo.Checked = true;
            this.chkVideo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVideo.Depth = 0;
            this.chkVideo.Location = new System.Drawing.Point(128, 358);
            this.chkVideo.Margin = new System.Windows.Forms.Padding(0);
            this.chkVideo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkVideo.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkVideo.Name = "chkVideo";
            this.chkVideo.ReadOnly = false;
            this.chkVideo.Ripple = true;
            this.chkVideo.Size = new System.Drawing.Size(137, 37);
            this.chkVideo.TabIndex = 12;
            this.chkVideo.Text = "Video Settings";
            this.chkVideo.UseVisualStyleBackColor = true;
            // 
            // materialDestLaunch
            // 
            this.materialDestLaunch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDestLaunch.AnimateReadOnly = true;
            this.materialDestLaunch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialDestLaunch.Depth = 0;
            this.materialDestLaunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialDestLaunch.Hint = "Launch Options";
            this.materialDestLaunch.LeadingIcon = null;
            this.materialDestLaunch.Location = new System.Drawing.Point(20, 294);
            this.materialDestLaunch.MaxLength = 50;
            this.materialDestLaunch.MouseState = MaterialSkin.MouseState.OUT;
            this.materialDestLaunch.Multiline = false;
            this.materialDestLaunch.Name = "materialDestLaunch";
            this.materialDestLaunch.ReadOnly = true;
            this.materialDestLaunch.Size = new System.Drawing.Size(460, 50);
            this.materialDestLaunch.TabIndex = 13;
            this.materialDestLaunch.Text = " ";
            this.materialDestLaunch.TrailingIcon = null;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.materialDestLaunch);
            this.Controls.Add(this.chkVideo);
            this.Controls.Add(this.materialTextBoxLaunch);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.chkCopyCfg);
            this.Controls.Add(this.cmbDest);
            this.Controls.Add(this.cmbSource);
            this.Controls.Add(this.materialDrawer1);
            this.MaximumSize = new System.Drawing.Size(1080, 450);
            this.MinimumSize = new System.Drawing.Size(500, 450);
            this.Name = "MainForm";
            this.Text = "CS:GO Config Replicator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private MaterialSkin.Controls.MaterialComboBox cmbSource;
        private MaterialSkin.Controls.MaterialComboBox cmbDest;
        private MaterialSkin.Controls.MaterialCheckbox chkCopyCfg;
        private MaterialSkin.Controls.MaterialButton btnCopy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxLaunch;
        private MaterialSkin.Controls.MaterialCheckbox chkVideo;
        private MaterialSkin.Controls.MaterialTextBox materialDestLaunch;
    }
}
