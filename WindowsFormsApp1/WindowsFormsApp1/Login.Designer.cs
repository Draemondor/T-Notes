namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.password_icon = new System.Windows.Forms.PictureBox();
            this.usrname_icon = new System.Windows.Forms.PictureBox();
            this.bgPanel = new System.Windows.Forms.Panel();
            this.btnCreateAnAccount = new System.Windows.Forms.Button();
            this.btnLink_ForgotPassword = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCheckbox_RememberMe = new System.Windows.Forms.CheckBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.label_Tnotes = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.password_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrname_icon)).BeginInit();
            this.bgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // password_icon
            // 
            this.password_icon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.password_icon.BackColor = System.Drawing.Color.Transparent;
            this.password_icon.Image = ((System.Drawing.Image)(resources.GetObject("password_icon.Image")));
            this.password_icon.Location = new System.Drawing.Point(22, 63);
            this.password_icon.Name = "password_icon";
            this.password_icon.Size = new System.Drawing.Size(17, 20);
            this.password_icon.TabIndex = 1;
            this.password_icon.TabStop = false;
            this.password_icon.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // usrname_icon
            // 
            this.usrname_icon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.usrname_icon.BackColor = System.Drawing.Color.Transparent;
            this.usrname_icon.Image = ((System.Drawing.Image)(resources.GetObject("usrname_icon.Image")));
            this.usrname_icon.Location = new System.Drawing.Point(21, 26);
            this.usrname_icon.Name = "usrname_icon";
            this.usrname_icon.Size = new System.Drawing.Size(17, 20);
            this.usrname_icon.TabIndex = 2;
            this.usrname_icon.TabStop = false;
            this.usrname_icon.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // bgPanel
            // 
            this.bgPanel.BackColor = System.Drawing.Color.Transparent;
            this.bgPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bgPanel.BackgroundImage")));
            this.bgPanel.Controls.Add(this.btnCreateAnAccount);
            this.bgPanel.Controls.Add(this.btnLink_ForgotPassword);
            this.bgPanel.Controls.Add(this.btnLogin);
            this.bgPanel.Controls.Add(this.btnCheckbox_RememberMe);
            this.bgPanel.Controls.Add(this.txtUsername);
            this.bgPanel.Controls.Add(this.txtPassword);
            this.bgPanel.Controls.Add(this.password_icon);
            this.bgPanel.Controls.Add(this.usrname_icon);
            this.bgPanel.Location = new System.Drawing.Point(137, 99);
            this.bgPanel.Name = "bgPanel";
            this.bgPanel.Size = new System.Drawing.Size(312, 200);
            this.bgPanel.TabIndex = 3;
            this.bgPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnCreateAnAccount
            // 
            this.btnCreateAnAccount.AutoSize = true;
            this.btnCreateAnAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(142)))), ((int)(((byte)(30)))));
            this.btnCreateAnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAnAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(144)))));
            this.btnCreateAnAccount.Location = new System.Drawing.Point(144, 148);
            this.btnCreateAnAccount.Name = "btnCreateAnAccount";
            this.btnCreateAnAccount.Size = new System.Drawing.Size(145, 29);
            this.btnCreateAnAccount.TabIndex = 8;
            this.btnCreateAnAccount.Text = "Create An Account";
            this.btnCreateAnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreateAnAccount.UseVisualStyleBackColor = true;
            this.btnCreateAnAccount.Click += new System.EventHandler(this.CreateAnAccount_Click);
            // 
            // btnLink_ForgotPassword
            // 
            this.btnLink_ForgotPassword.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLink_ForgotPassword.AutoSize = true;
            this.btnLink_ForgotPassword.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btnLink_ForgotPassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(144)))));
            this.btnLink_ForgotPassword.Location = new System.Drawing.Point(197, 111);
            this.btnLink_ForgotPassword.Name = "btnLink_ForgotPassword";
            this.btnLink_ForgotPassword.Size = new System.Drawing.Size(92, 13);
            this.btnLink_ForgotPassword.TabIndex = 7;
            this.btnLink_ForgotPassword.TabStop = true;
            this.btnLink_ForgotPassword.Text = "Forgot Password?";
            this.btnLink_ForgotPassword.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(142)))), ((int)(((byte)(30)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(144)))));
            this.btnLogin.Location = new System.Drawing.Point(22, 148);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(95, 29);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btnCheckbox_RememberMe
            // 
            this.btnCheckbox_RememberMe.AutoSize = true;
            this.btnCheckbox_RememberMe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(144)))));
            this.btnCheckbox_RememberMe.Location = new System.Drawing.Point(22, 111);
            this.btnCheckbox_RememberMe.Name = "btnCheckbox_RememberMe";
            this.btnCheckbox_RememberMe.Size = new System.Drawing.Size(95, 17);
            this.btnCheckbox_RememberMe.TabIndex = 5;
            this.btnCheckbox_RememberMe.Text = "Remember Me";
            this.btnCheckbox_RememberMe.UseVisualStyleBackColor = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(173)))), ((int)(((byte)(223)))));
            this.txtUsername.Location = new System.Drawing.Point(46, 25);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(243, 23);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(173)))), ((int)(((byte)(223)))));
            this.txtPassword.Location = new System.Drawing.Point(46, 62);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(243, 23);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "Password";
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(12, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(85, 84);
            this.Logo.TabIndex = 4;
            this.Logo.TabStop = false;
            // 
            // label_Tnotes
            // 
            this.label_Tnotes.AutoSize = true;
            this.label_Tnotes.BackColor = System.Drawing.Color.Transparent;
            this.label_Tnotes.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Tnotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(222)))), ((int)(((byte)(240)))));
            this.label_Tnotes.Location = new System.Drawing.Point(190, 59);
            this.label_Tnotes.Name = "label_Tnotes";
            this.label_Tnotes.Size = new System.Drawing.Size(197, 37);
            this.label_Tnotes.TabIndex = 5;
            this.label_Tnotes.Text = "T-notes Login";
            this.label_Tnotes.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(515, 341);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 30);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(573, 383);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label_Tnotes);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.bgPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "T-notes  |  Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.password_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrname_icon)).EndInit();
            this.bgPanel.ResumeLayout(false);
            this.bgPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox password_icon;
        private System.Windows.Forms.PictureBox usrname_icon;
        private System.Windows.Forms.Panel bgPanel;
        private System.Windows.Forms.LinkLabel btnLink_ForgotPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox btnCheckbox_RememberMe;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnCreateAnAccount;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label label_Tnotes;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

