namespace QuarsPicker
{
    partial class Main
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.copyInt = new DevExpress.XtraEditors.SimpleButton();
            this.intLabel = new System.Windows.Forms.Label();
            this.copyHex = new DevExpress.XtraEditors.SimpleButton();
            this.hexLabel = new System.Windows.Forms.Label();
            this.copyRgbb = new DevExpress.XtraEditors.SimpleButton();
            this.rgbbLabel = new System.Windows.Forms.Label();
            this.copyRgb = new DevExpress.XtraEditors.SimpleButton();
            this.scLabel = new DevExpress.XtraEditors.LabelControl();
            this.selectedColor = new System.Windows.Forms.PictureBox();
            this.rgbLabel = new System.Windows.Forms.Label();
            this.mpLabel = new DevExpress.XtraEditors.LabelControl();
            this.cpyClr = new DevExpress.XtraEditors.SimpleButton();
            this.colorList = new DevExpress.XtraEditors.ListBoxControl();
            this.colorBox = new System.Windows.Forms.PictureBox();
            this.leftMenu = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.homeBtn = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.settingsBtn = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.pixelGrabber = new System.Windows.Forms.Timer(this.components);
            this.keyGrabber = new System.Windows.Forms.Timer(this.components);
            this.infoButton = new DevExpress.XtraEditors.SimpleButton();
            this.fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Controls.Add(this.copyInt);
            this.fluentDesignFormContainer1.Controls.Add(this.intLabel);
            this.fluentDesignFormContainer1.Controls.Add(this.copyHex);
            this.fluentDesignFormContainer1.Controls.Add(this.hexLabel);
            this.fluentDesignFormContainer1.Controls.Add(this.copyRgbb);
            this.fluentDesignFormContainer1.Controls.Add(this.rgbbLabel);
            this.fluentDesignFormContainer1.Controls.Add(this.copyRgb);
            this.fluentDesignFormContainer1.Controls.Add(this.scLabel);
            this.fluentDesignFormContainer1.Controls.Add(this.selectedColor);
            this.fluentDesignFormContainer1.Controls.Add(this.rgbLabel);
            this.fluentDesignFormContainer1.Controls.Add(this.mpLabel);
            this.fluentDesignFormContainer1.Controls.Add(this.cpyClr);
            this.fluentDesignFormContainer1.Controls.Add(this.colorList);
            this.fluentDesignFormContainer1.Controls.Add(this.colorBox);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(120, 32);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(449, 245);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // copyInt
            // 
            this.copyInt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("copyInt.ImageOptions.Image")));
            this.copyInt.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.copyInt.Location = new System.Drawing.Point(184, 137);
            this.copyInt.Name = "copyInt";
            this.copyInt.Size = new System.Drawing.Size(24, 25);
            this.copyInt.TabIndex = 15;
            this.copyInt.Click += new System.EventHandler(this.CopyInt_Click);
            // 
            // intLabel
            // 
            this.intLabel.AutoSize = true;
            this.intLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.intLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.intLabel.Location = new System.Drawing.Point(214, 135);
            this.intLabel.Name = "intLabel";
            this.intLabel.Size = new System.Drawing.Size(65, 34);
            this.intLabel.TabIndex = 14;
            this.intLabel.Text = "INTEGER:\r\n0";
            // 
            // copyHex
            // 
            this.copyHex.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("copyHex.ImageOptions.Image")));
            this.copyHex.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.copyHex.Location = new System.Drawing.Point(184, 94);
            this.copyHex.Name = "copyHex";
            this.copyHex.Size = new System.Drawing.Size(24, 25);
            this.copyHex.TabIndex = 13;
            this.copyHex.Click += new System.EventHandler(this.CopyHex_Click);
            // 
            // hexLabel
            // 
            this.hexLabel.AutoSize = true;
            this.hexLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hexLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.hexLabel.Location = new System.Drawing.Point(214, 92);
            this.hexLabel.Name = "hexLabel";
            this.hexLabel.Size = new System.Drawing.Size(64, 34);
            this.hexLabel.TabIndex = 12;
            this.hexLabel.Text = "HEX:\r\n0x000000";
            // 
            // copyRgbb
            // 
            this.copyRgbb.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("copyRgbb.ImageOptions.Image")));
            this.copyRgbb.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.copyRgbb.Location = new System.Drawing.Point(184, 52);
            this.copyRgbb.Name = "copyRgbb";
            this.copyRgbb.Size = new System.Drawing.Size(24, 25);
            this.copyRgbb.TabIndex = 9;
            this.copyRgbb.Click += new System.EventHandler(this.CopyRgbb_Click);
            // 
            // rgbbLabel
            // 
            this.rgbbLabel.AutoSize = true;
            this.rgbbLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rgbbLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rgbbLabel.Location = new System.Drawing.Point(214, 50);
            this.rgbbLabel.Name = "rgbbLabel";
            this.rgbbLabel.Size = new System.Drawing.Size(66, 34);
            this.rgbbLabel.TabIndex = 8;
            this.rgbbLabel.Text = "RGB(1-0):\r\n0, 0, 0";
            // 
            // copyRgb
            // 
            this.copyRgb.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("copyRgb.ImageOptions.Image")));
            this.copyRgb.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.copyRgb.Location = new System.Drawing.Point(185, 12);
            this.copyRgb.Name = "copyRgb";
            this.copyRgb.Size = new System.Drawing.Size(24, 25);
            this.copyRgb.TabIndex = 7;
            this.copyRgb.Click += new System.EventHandler(this.CopyBtn_Click);
            // 
            // scLabel
            // 
            this.scLabel.Location = new System.Drawing.Point(7, 131);
            this.scLabel.Name = "scLabel";
            this.scLabel.Size = new System.Drawing.Size(88, 13);
            this.scLabel.TabIndex = 6;
            this.scLabel.Text = "Mouse Pixel Color:";
            // 
            // selectedColor
            // 
            this.selectedColor.Location = new System.Drawing.Point(6, 150);
            this.selectedColor.Name = "selectedColor";
            this.selectedColor.Size = new System.Drawing.Size(151, 85);
            this.selectedColor.TabIndex = 5;
            this.selectedColor.TabStop = false;
            // 
            // rgbLabel
            // 
            this.rgbLabel.AutoSize = true;
            this.rgbLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rgbLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rgbLabel.Location = new System.Drawing.Point(214, 8);
            this.rgbLabel.Name = "rgbLabel";
            this.rgbLabel.Size = new System.Drawing.Size(45, 34);
            this.rgbLabel.TabIndex = 4;
            this.rgbLabel.Text = "RGB:\r\n0, 0, 0";
            // 
            // mpLabel
            // 
            this.mpLabel.Location = new System.Drawing.Point(6, 11);
            this.mpLabel.Name = "mpLabel";
            this.mpLabel.Size = new System.Drawing.Size(88, 13);
            this.mpLabel.TabIndex = 3;
            this.mpLabel.Text = "Mouse Pixel Color:";
            // 
            // cpyClr
            // 
            this.cpyClr.Location = new System.Drawing.Point(315, 212);
            this.cpyClr.Name = "cpyClr";
            this.cpyClr.Size = new System.Drawing.Size(127, 23);
            this.cpyClr.TabIndex = 2;
            this.cpyClr.Text = "Copy Selected Color";
            this.cpyClr.Click += new System.EventHandler(this.CpyClr_Click);
            // 
            // colorList
            // 
            this.colorList.Location = new System.Drawing.Point(315, 6);
            this.colorList.Name = "colorList";
            this.colorList.Size = new System.Drawing.Size(127, 200);
            this.colorList.TabIndex = 1;
            this.colorList.SelectedIndexChanged += new System.EventHandler(this.ColorList_SelectedIndexChanged);
            // 
            // colorBox
            // 
            this.colorBox.Location = new System.Drawing.Point(5, 30);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(151, 85);
            this.colorBox.TabIndex = 0;
            this.colorBox.TabStop = false;
            // 
            // leftMenu
            // 
            this.leftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftMenu.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.homeBtn,
            this.settingsBtn});
            this.leftMenu.Location = new System.Drawing.Point(0, 32);
            this.leftMenu.Name = "leftMenu";
            this.leftMenu.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.False;
            this.leftMenu.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.leftMenu.Size = new System.Drawing.Size(120, 245);
            this.leftMenu.TabIndex = 1;
            // 
            // homeBtn
            // 
            this.homeBtn.Appearance.Hovered.BackColor = System.Drawing.Color.Gray;
            this.homeBtn.Appearance.Hovered.ForeColor = System.Drawing.Color.White;
            this.homeBtn.Appearance.Hovered.Options.UseBackColor = true;
            this.homeBtn.Appearance.Hovered.Options.UseForeColor = true;
            this.homeBtn.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.homeBtn.Appearance.Normal.Options.UseForeColor = true;
            this.homeBtn.Appearance.Pressed.BackColor = System.Drawing.Color.DimGray;
            this.homeBtn.Appearance.Pressed.ForeColor = System.Drawing.Color.Gray;
            this.homeBtn.Appearance.Pressed.Options.UseBackColor = true;
            this.homeBtn.Appearance.Pressed.Options.UseForeColor = true;
            this.homeBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.ImageOptions.Image")));
            this.homeBtn.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Squeeze;
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.homeBtn.Text = "Home";
            // 
            // settingsBtn
            // 
            this.settingsBtn.Appearance.Disabled.ForeColor = System.Drawing.Color.Silver;
            this.settingsBtn.Appearance.Disabled.Options.UseForeColor = true;
            this.settingsBtn.Appearance.Hovered.ForeColor = System.Drawing.Color.Silver;
            this.settingsBtn.Appearance.Hovered.Options.UseForeColor = true;
            this.settingsBtn.Appearance.Normal.ForeColor = System.Drawing.Color.Silver;
            this.settingsBtn.Appearance.Normal.Options.UseForeColor = true;
            this.settingsBtn.Appearance.Pressed.ForeColor = System.Drawing.Color.Silver;
            this.settingsBtn.Appearance.Pressed.Options.UseForeColor = true;
            this.settingsBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("settingsBtn.ImageOptions.Image")));
            this.settingsBtn.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Squeeze;
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(569, 32);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // pixelGrabber
            // 
            this.pixelGrabber.Enabled = true;
            this.pixelGrabber.Tick += new System.EventHandler(this.PixelGrabber_Tick);
            // 
            // keyGrabber
            // 
            this.keyGrabber.Enabled = true;
            this.keyGrabber.Interval = 250;
            this.keyGrabber.Tick += new System.EventHandler(this.KeyGrabber_Tick);
            // 
            // infoButton
            // 
            this.infoButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("infoButton.ImageOptions.Image")));
            this.infoButton.Location = new System.Drawing.Point(48, 242);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(22, 23);
            this.infoButton.TabIndex = 3;
            this.infoButton.Click += new System.EventHandler(this.İnfoButton_Click);
            // 
            // Main
            // 
            this.ActiveGlowColor = System.Drawing.Color.Red;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 277);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.leftMenu);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.InactiveGlowColor = System.Drawing.Color.Red;
            this.KeyPreview = true;
            this.LookAndFeel.SkinName = "Office 2016 Black";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.NavigationControl = this.leftMenu;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuarsPicker";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.fluentDesignFormContainer1.ResumeLayout(false);
            this.fluentDesignFormContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl leftMenu;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private System.Windows.Forms.PictureBox colorBox;
        private System.Windows.Forms.Timer pixelGrabber;
        private DevExpress.XtraEditors.ListBoxControl colorList;
        private DevExpress.XtraEditors.SimpleButton cpyClr;
        private System.Windows.Forms.Timer keyGrabber;
        private DevExpress.XtraEditors.LabelControl mpLabel;
        private DevExpress.XtraBars.Navigation.AccordionControlElement homeBtn;
        private DevExpress.XtraBars.Navigation.AccordionControlElement settingsBtn;
        private System.Windows.Forms.Label rgbLabel;
        private DevExpress.XtraEditors.LabelControl scLabel;
        private System.Windows.Forms.PictureBox selectedColor;
        private DevExpress.XtraEditors.SimpleButton copyRgb;
        private System.Windows.Forms.Label rgbbLabel;
        private DevExpress.XtraEditors.SimpleButton copyRgbb;
        private DevExpress.XtraEditors.SimpleButton copyHex;
        private System.Windows.Forms.Label hexLabel;
        private DevExpress.XtraEditors.SimpleButton copyInt;
        private System.Windows.Forms.Label intLabel;
        private DevExpress.XtraEditors.SimpleButton infoButton;
    }
}