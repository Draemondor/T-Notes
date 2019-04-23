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
        public Form1(User x)
        {
            this.user = x;
            InitializeComponent();
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

        
    }
}
