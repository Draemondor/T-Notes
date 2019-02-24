namespace WindowsFormsApp1
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.bgPanel = new System.Windows.Forms.Panel();
            this.pleaseChoiceNewPassword_label = new System.Windows.Forms.Label();
            this.Reset_lable = new System.Windows.Forms.Label();
            this.btnResetYourPassword = new System.Windows.Forms.Button();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtRe_enterPassword = new System.Windows.Forms.TextBox();
            this.password_icon = new System.Windows.Forms.PictureBox();
            this.usrname_icon = new System.Windows.Forms.PictureBox();
            this.Tnotes_lable = new System.Windows.Forms.Label();
            this.CreateAccount_lable = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.bgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.password_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrname_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(12, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(85, 84);
            this.Logo.TabIndex = 5;
            this.Logo.TabStop = false;
            // 
            // bgPanel
            // 
            this.bgPanel.BackColor = System.Drawing.Color.Transparent;
            this.bgPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bgPanel.BackgroundImage")));
            this.bgPanel.Controls.Add(this.pleaseChoiceNewPassword_label);
            this.bgPanel.Controls.Add(this.Reset_lable);
            this.bgPanel.Controls.Add(this.btnResetYourPassword);
            this.bgPanel.Controls.Add(this.txtNewPassword);
            this.bgPanel.Controls.Add(this.txtRe_enterPassword);
            this.bgPanel.Controls.Add(this.password_icon);
            this.bgPanel.Controls.Add(this.usrname_icon);
            this.bgPanel.Location = new System.Drawing.Point(130, 111);
            this.bgPanel.Name = "bgPanel";
            this.bgPanel.Size = new System.Drawing.Size(312, 200);
            this.bgPanel.TabIndex = 6;
            this.bgPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bgPanel_Paint);
            // 
            // pleaseChoiceNewPassword_label
            // 
            this.pleaseChoiceNewPassword_label.AutoSize = true;
            this.pleaseChoiceNewPassword_label.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pleaseChoiceNewPassword_label.Location = new System.Drawing.Point(19, 46);
            this.pleaseChoiceNewPassword_label.Name = "pleaseChoiceNewPassword_label";
            this.pleaseChoiceNewPassword_label.Size = new System.Drawing.Size(210, 16);
            this.pleaseChoiceNewPassword_label.TabIndex = 10;
            this.pleaseChoiceNewPassword_label.Text = "Please choose a new password.";
            // 
            // Reset_lable
            // 
            this.Reset_lable.AutoSize = true;
            this.Reset_lable.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_lable.Location = new System.Drawing.Point(18, 21);
            this.Reset_lable.Name = "Reset_lable";
            this.Reset_lable.Size = new System.Drawing.Size(159, 20);
            this.Reset_lable.TabIndex = 9;
            this.Reset_lable.Text = "Reset your password.";
            // 
            // btnResetYourPassword
            // 
            this.btnResetYourPassword.AutoSize = true;
            this.btnResetYourPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(142)))), ((int)(((byte)(30)))));
            this.btnResetYourPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetYourPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetYourPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(144)))));
            this.btnResetYourPassword.Location = new System.Drawing.Point(22, 150);
            this.btnResetYourPassword.Name = "btnResetYourPassword";
            this.btnResetYourPassword.Size = new System.Drawing.Size(267, 29);
            this.btnResetYourPassword.TabIndex = 8;
            this.btnResetYourPassword.Text = "Reset Your Password";
            this.btnResetYourPassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResetYourPassword.UseVisualStyleBackColor = true;
            this.btnResetYourPassword.Click += new System.EventHandler(this.btnCreateAnAccount_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(173)))), ((int)(((byte)(223)))));
            this.txtNewPassword.Location = new System.Drawing.Point(46, 76);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(243, 23);
            this.txtNewPassword.TabIndex = 4;
            this.txtNewPassword.Text = "New Password";
            // 
            // txtRe_enterPassword
            // 
            this.txtRe_enterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRe_enterPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(173)))), ((int)(((byte)(223)))));
            this.txtRe_enterPassword.Location = new System.Drawing.Point(46, 113);
            this.txtRe_enterPassword.Name = "txtRe_enterPassword";
            this.txtRe_enterPassword.Size = new System.Drawing.Size(243, 23);
            this.txtRe_enterPassword.TabIndex = 3;
            this.txtRe_enterPassword.Text = "Re-Enter Password";
            // 
            // password_icon
            // 
            this.password_icon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.password_icon.BackColor = System.Drawing.Color.Transparent;
            this.password_icon.Image = ((System.Drawing.Image)(resources.GetObject("password_icon.Image")));
            this.password_icon.Location = new System.Drawing.Point(22, 114);
            this.password_icon.Name = "password_icon";
            this.password_icon.Size = new System.Drawing.Size(17, 20);
            this.password_icon.TabIndex = 1;
            this.password_icon.TabStop = false;
            // 
            // usrname_icon
            // 
            this.usrname_icon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.usrname_icon.BackColor = System.Drawing.Color.Transparent;
            this.usrname_icon.Image = ((System.Drawing.Image)(resources.GetObject("usrname_icon.Image")));
            this.usrname_icon.Location = new System.Drawing.Point(21, 77);
            this.usrname_icon.Name = "usrname_icon";
            this.usrname_icon.Size = new System.Drawing.Size(17, 20);
            this.usrname_icon.TabIndex = 2;
            this.usrname_icon.TabStop = false;
            // 
            // Tnotes_lable
            // 
            this.Tnotes_lable.AutoSize = true;
            this.Tnotes_lable.BackColor = System.Drawing.Color.Transparent;
            this.Tnotes_lable.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tnotes_lable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(222)))), ((int)(((byte)(240)))));
            this.Tnotes_lable.Location = new System.Drawing.Point(230, 41);
            this.Tnotes_lable.Name = "Tnotes_lable";
            this.Tnotes_lable.Size = new System.Drawing.Size(120, 37);
            this.Tnotes_lable.TabIndex = 10;
            this.Tnotes_lable.Text = "T-Notes";
            this.Tnotes_lable.Click += new System.EventHandler(this.Tnotes_lable_Click);
            // 
            // CreateAccount_lable
            // 
            this.CreateAccount_lable.AutoSize = true;
            this.CreateAccount_lable.BackColor = System.Drawing.Color.Transparent;
            this.CreateAccount_lable.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccount_lable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(222)))), ((int)(((byte)(240)))));
            this.CreateAccount_lable.Location = new System.Drawing.Point(178, 72);
            this.CreateAccount_lable.Name = "CreateAccount_lable";
            this.CreateAccount_lable.Size = new System.Drawing.Size(233, 37);
            this.CreateAccount_lable.TabIndex = 9;
            this.CreateAccount_lable.Text = "Forgot Password";
            this.CreateAccount_lable.Click += new System.EventHandler(this.CreateAccount_lable_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(515, 341);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 30);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(573, 383);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Tnotes_lable);
            this.Controls.Add(this.CreateAccount_lable);
            this.Controls.Add(this.bgPanel);
            this.Controls.Add(this.Logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForgotPassword";
            this.Text = "T-Notes  | Forgot Password ";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.bgPanel.ResumeLayout(false);
            this.bgPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.password_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrname_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel bgPanel;
        private System.Windows.Forms.Button btnResetYourPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtRe_enterPassword;
        private System.Windows.Forms.PictureBox password_icon;
        private System.Windows.Forms.PictureBox usrname_icon;
        private System.Windows.Forms.Label Tnotes_lable;
        private System.Windows.Forms.Label CreateAccount_lable;
        private System.Windows.Forms.Label pleaseChoiceNewPassword_label;
        private System.Windows.Forms.Label Reset_lable;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}