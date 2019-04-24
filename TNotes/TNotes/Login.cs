using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TNotes
{
    public partial class Form1 : Form
    {
        User user;
        string phu = "Username";
        string php = "Password";
        Color farbe;
        public Form1(User x)
        {
            this.user = x;
            InitializeComponent();
            txtUsername.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            farbe = txtUsername.ForeColor;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int user_id = user.login(this.txtUsername.Text, this.txtPassword.Text);
            Console.WriteLine("user_id: " + user_id);
            if (user_id >= 0)
            {
                this.button1.Hide();
                this.txtUsername.Hide();
                this.txtPassword.Hide();
                user.setAttributes(txtUsername.Text, txtPassword.Text);
                Thread myThread = new Thread((ThreadStart)delegate { Application.Run(new Dashboard(user)); });
                myThread.Start();
                this.Close();
                
            }
            else
            {
                this.txtUsername.ResetText();
                this.txtPassword.ResetText();
                this.label4.Show();
            }
        }

        public void RemoveText(object sender, EventArgs e)
        {
            txtUsername.ForeColor = farbe;
            txtPassword.ForeColor = farbe;
            if (txtUsername.Text == phu & sender == txtUsername)
                txtUsername.Text = "";
            else if (txtPassword.Text == php & sender == txtPassword)
                txtPassword.Text = "";
        }

        public void AddText(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtUsername.Text) & sender == txtUsername)
            {
                txtUsername.ForeColor = Color.Gray;
                txtUsername.Text = phu;
            }
            else if (String.IsNullOrWhiteSpace(txtPassword.Text) & sender == txtPassword)
            {
                txtPassword.ForeColor = Color.Gray;
                txtPassword.Text = php;
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            Thread myThread = new Thread((ThreadStart)delegate { Application.Run(new CreateAccount(user)); });
            myThread.Start();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Thread myThread = new Thread((ThreadStart)delegate { Application.Run(new ForgotPassword(user)); });
            myThread.Start();
        }
    }
}
