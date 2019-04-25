using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TNotes
{
    public partial class Dashboard : Form
    {
        User user;
        public Dashboard(User x)
        {
            this.user = x;
            InitializeComponent();
            this.Hide();

        }

        private void Logo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Home_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Courses_TextChanged(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCourses_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            Thread myThread = new Thread((ThreadStart)delegate { Application.Run(new UserSettings(user)); });
            myThread.Start();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            User newUser = new User();
            Thread myThread = new Thread((ThreadStart)delegate { Application.Run(new Form1(newUser)); });
            myThread.Start();
            this.Close();
        }

        private void searchStart_Click(object sender, EventArgs e)
        {
            string keywords = this.txtSearch.Text;
            string[] keywordsArray = keywords.Split(',');
            List<string> keywordsList = new List<string>();
            foreach (string s in keywordsArray)
            {
                keywordsList.Add(s);
            }

        }

        public void RemoveText(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals("Search") & sender == txtSearch)
                txtSearch.Text = "";
        }

        public void AddText(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtSearch.Text) & sender == txtSearch)
            {
                txtSearch.Text = "Search";
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            User result = Task.Factory.StartNew(() =>
            {
                UserSettings settings = new UserSettings(user);
                Application.Run(settings);

                return user;
            }).Result;
            if (user.login(user.getUsername(), user.getPassword()) < 0)
            {
                User newUser = new User();
                Thread myThread = new Thread((ThreadStart)delegate { Application.Run(new Form1(newUser)); });
                myThread.Start();
                this.Close();
            } else
            {
                this.BringToFront();
            }      
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            User newUser = new User();
            Thread myThread = new Thread((ThreadStart)delegate { Application.Run(new Form1(newUser)); });
            myThread.Start();
            this.Close();
        }
    }
}
