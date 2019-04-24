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
    public partial class UserSettings : Form
    {
        User user;
        public UserSettings(User user)
        {
            this.user = user;
            InitializeComponent();
        }
        //Removes user account
        private void button3_Click(object sender, EventArgs e)
        {
            int user_id = user.login(this.textBox7.Text, this.textBox6.Text);
            if (user_id > 0)
            {
                user.removeUser(user_id, this.textBox6.Text);
                this.Close();
            }
        }
        //Changes username
        private void button1_Click(object sender, EventArgs e)
        {
            int user_id = user.login(this.textBox9.Text, this.textBox2.Text);
            user.changeUser(user_id, this.textBox9.Text, this.textBox1.Text);
        }
        //Changes password
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.textBox4.Text.Equals(this.textBox5.Text))
            {
                int user_id = user.login(this.textBox8.Text, this.textBox3.Text);
                user.changePass(user_id, this.textBox3.Text, this.textBox4.Text);
            }
            else
            {

            }
        }
        //Displays a checkmark if passwords match, an X otherwise
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox4.Text.Equals(this.textBox5.Text))
            {
                this.pictureBox1.Image = global::TNotes.Properties.Resources.checkmark1;
            }
            else
            {
                this.pictureBox1.Image = global::TNotes.Properties.Resources.incorrect1;
                this.pictureBox1.Show();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox4.Text.Equals(this.textBox5.Text))
            {
                this.pictureBox1.Image = global::TNotes.Properties.Resources.checkmark1;
            }
            else
            {
                this.pictureBox1.Image = global::TNotes.Properties.Resources.incorrect1;
                this.pictureBox1.Show();
            }
        }
    }
}
