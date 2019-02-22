using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TNotes
{
    public partial class Form1 : Form
    {
        User user = new User();
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Console.WriteLine(this.textBox1.Text);
            Console.WriteLine(this.textBox2.Text);
            
            int user_id = user.login(this.textBox1.Text, this.textBox2.Text);
            Console.WriteLine("user_id: " + user_id);
            if (user_id >=0)
            {
                this.Login.Hide();
                this.textBox1.Hide();
                this.textBox2.Hide();
                this.label1.Hide();
                this.label2.Hide();
                this.label3.Show();
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
