namespace GiaoDien.FE
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.imageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.ceMANAGER = new DevExpress.XtraEditors.CheckEdit();
            this.ceADMIN = new DevExpress.XtraEditors.CheckEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSignIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceMANAGER.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceADMIN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.imageSlider1);
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Name = "panelControl1";
            // 
            // imageSlider1
            // 
            this.imageSlider1.AllowLooping = true;
            this.imageSlider1.AnimationTime = 2000;
            this.imageSlider1.AutoSlide = DevExpress.XtraEditors.Controls.AutoSlide.Forward;
            this.imageSlider1.AutoSlideInterval = 3000;
            this.imageSlider1.CurrentImageIndex = 0;
            resources.ApplyResources(this.imageSlider1, "imageSlider1");
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images"))));
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images1"))));
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images2"))));
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images3"))));
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images4"))));
            this.imageSlider1.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomOutside;
            this.imageSlider1.Name = "imageSlider1";
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("panelControl2.Appearance.BackColor")));
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.ceMANAGER);
            this.panelControl2.Controls.Add(this.ceADMIN);
            this.panelControl2.Controls.Add(this.pictureBox1);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.txtPass);
            this.panelControl2.Controls.Add(this.txtUser);
            this.panelControl2.Controls.Add(this.btnExit);
            this.panelControl2.Controls.Add(this.btnSignIn);
            resources.ApplyResources(this.panelControl2, "panelControl2");
            this.panelControl2.Name = "panelControl2";
            // 
            // ceMANAGER
            // 
            resources.ApplyResources(this.ceMANAGER, "ceMANAGER");
            this.ceMANAGER.Name = "ceMANAGER";
            // 
            // 
            // 
            this.ceMANAGER.Properties.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("ceMANAGER.Properties.Appearance.ForeColor")));
            this.ceMANAGER.Properties.Appearance.Options.UseForeColor = true;
            this.ceMANAGER.Properties.Caption = resources.GetString("ceMANAGER.Properties.Caption");
            // 
            // ceADMIN
            // 
            resources.ApplyResources(this.ceADMIN, "ceADMIN");
            this.ceADMIN.Name = "ceADMIN";
            // 
            // 
            // 
            this.ceADMIN.Properties.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("ceADMIN.Properties.Appearance.ForeColor")));
            this.ceADMIN.Properties.Appearance.Options.UseForeColor = true;
            this.ceADMIN.Properties.Caption = resources.GetString("ceADMIN.Properties.Caption");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GiaoDien.Properties.Resources.logo1;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl3.Appearance.Font")));
            this.labelControl3.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("labelControl3.Appearance.ForeColor")));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(this.labelControl3, "labelControl3");
            this.labelControl3.Name = "labelControl3";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl2.Appearance.Font")));
            this.labelControl2.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("labelControl2.Appearance.ForeColor")));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(this.labelControl2, "labelControl2");
            this.labelControl2.Name = "labelControl2";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl1.Appearance.Font")));
            this.labelControl1.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("labelControl1.Appearance.ForeColor")));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Name = "labelControl1";
            // 
            // txtPass
            // 
            this.txtPass.AcceptsTab = true;
            this.txtPass.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtPass.BackColor = System.Drawing.Color.LightCyan;
            this.txtPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.txtPass, "txtPass");
            this.txtPass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPass.Name = "txtPass";
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            this.txtUser.AcceptsTab = true;
            this.txtUser.BackColor = System.Drawing.Color.LightCyan;
            this.txtUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.txtUser, "txtUser");
            this.txtUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtUser.Name = "txtUser";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Crimson;
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.Crimson;
            resources.ApplyResources(this.btnSignIn, "btnSignIn");
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // login
            // 
            this.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("login.Appearance.BackColor")));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ControlBox = false;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.DoubleBuffered = true;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.InactiveGlowColor = System.Drawing.Color.Black;
            this.Name = "login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceMANAGER.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceADMIN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.TextBox txtUser;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtPass;
        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CheckEdit ceMANAGER;
        private DevExpress.XtraEditors.CheckEdit ceADMIN;
    }
}