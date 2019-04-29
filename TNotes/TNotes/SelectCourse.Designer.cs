namespace TNotes
{
    partial class SelectCourse
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
            this.button1 = new System.Windows.Forms.Button();
            this.coursetb = new System.Windows.Forms.TextBox();
            this.subjtb = new System.Windows.Forms.TextBox();
            this.proftb = new System.Windows.Forms.TextBox();
            this.semestertb = new System.Windows.Forms.TextBox();
            this.yeartb = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.CourseCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(456, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save To Selected Course";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // coursetb
            // 
            this.coursetb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursetb.Location = new System.Drawing.Point(12, 160);
            this.coursetb.Name = "coursetb";
            this.coursetb.Size = new System.Drawing.Size(125, 30);
            this.coursetb.TabIndex = 2;
            this.coursetb.Text = "Course";
            this.coursetb.GotFocus += new System.EventHandler(this.clear_OnFocus);
            this.coursetb.LostFocus += new System.EventHandler(this.resetText_OnLostFocus);
            // 
            // subjtb
            // 
            this.subjtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjtb.Location = new System.Drawing.Point(143, 160);
            this.subjtb.Name = "subjtb";
            this.subjtb.Size = new System.Drawing.Size(125, 30);
            this.subjtb.TabIndex = 3;
            this.subjtb.Text = "Subject";
            this.subjtb.GotFocus += new System.EventHandler(this.clear_OnFocus);
            this.subjtb.LostFocus += new System.EventHandler(this.resetText_OnLostFocus);
            // 
            // proftb
            // 
            this.proftb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proftb.Location = new System.Drawing.Point(274, 160);
            this.proftb.Name = "proftb";
            this.proftb.Size = new System.Drawing.Size(125, 30);
            this.proftb.TabIndex = 4;
            this.proftb.Text = "Professor";
            this.proftb.GotFocus += new System.EventHandler(this.clear_OnFocus);
            this.proftb.LostFocus += new System.EventHandler(this.resetText_OnLostFocus);
            // 
            // semestertb
            // 
            this.semestertb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semestertb.Location = new System.Drawing.Point(405, 160);
            this.semestertb.Name = "semestertb";
            this.semestertb.Size = new System.Drawing.Size(125, 30);
            this.semestertb.TabIndex = 5;
            this.semestertb.Text = "Semester";
            this.semestertb.GotFocus += new System.EventHandler(this.clear_OnFocus);
            this.semestertb.LostFocus += new System.EventHandler(this.resetText_OnLostFocus);
            // 
            // yeartb
            // 
            this.yeartb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yeartb.Location = new System.Drawing.Point(536, 160);
            this.yeartb.Name = "yeartb";
            this.yeartb.Size = new System.Drawing.Size(125, 30);
            this.yeartb.TabIndex = 6;
            this.yeartb.Text = "Year";
            this.yeartb.GotFocus += new System.EventHandler(this.clear_OnFocus);
            this.yeartb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yeartb_KeyPress);
            this.yeartb.LostFocus += new System.EventHandler(this.resetText_OnLostFocus);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(456, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 40);
            this.button2.TabIndex = 7;
            this.button2.Text = "Save To New Course";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CourseCB
            // 
            this.CourseCB.FormattingEnabled = true;
            this.CourseCB.Location = new System.Drawing.Point(12, 21);
            this.CourseCB.Name = "CourseCB";
            this.CourseCB.Size = new System.Drawing.Size(648, 24);
            this.CourseCB.TabIndex = 8;
            // 
            // SelectCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 266);
            this.Controls.Add(this.CourseCB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.yeartb);
            this.Controls.Add(this.semestertb);
            this.Controls.Add(this.proftb);
            this.Controls.Add(this.subjtb);
            this.Controls.Add(this.coursetb);
            this.Controls.Add(this.button1);
            this.Name = "SelectCourse";
            this.Text = "Select Course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox coursetb;
        private System.Windows.Forms.TextBox subjtb;
        private System.Windows.Forms.TextBox proftb;
        private System.Windows.Forms.TextBox semestertb;
        private System.Windows.Forms.TextBox yeartb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox CourseCB;
    }
}