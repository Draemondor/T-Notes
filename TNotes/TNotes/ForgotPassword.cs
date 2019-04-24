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
    public partial class ForgotPassword : Form
    {
        User user;
        public ForgotPassword(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void CreateAccount_lable_Click(object sender, EventArgs e)
        {

        }

        private void Tnotes_lable_Click(object sender, EventArgs e)
        {

        }

        private void bgPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnResetYourPassword_Click(object sender, EventArgs e)
        {
            if (user.weakChangePass(this.textBox1.Text, this.txtNewPassword.Text) > 0)
                this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (this.txtNewPassword.Text.Equals(this.txtRe_enterPassword.Text))
            {
                this.password_icon.Image = global::TNotes.Properties.Resources.checkmark1;
            }
            else
            {
                this.password_icon.Image = global::TNotes.Properties.Resources.incorrect1;
                this.password_icon.Show();
            }
        }

        private void txtRe_enterPassword_TextChanged(object sender, EventArgs e)
        {
            if (this.txtRe_enterPassword.Text.Equals(this.txtNewPassword.Text))
            {
                this.password_icon.Image = global::TNotes.Properties.Resources.checkmark1;
            }
            else
            {
                this.password_icon.Image = global::TNotes.Properties.Resources.incorrect1;
                this.password_icon.Show();
            }
        }

        public void RemoveText(object sender, EventArgs e)
        {
            if (txtNewPassword.Text.Equals("New Password") & sender == txtNewPassword)
                txtNewPassword.Text = "";
            else if (txtRe_enterPassword.Text.Equals("Confirm Your Password") & sender == txtRe_enterPassword)
                txtRe_enterPassword.Text = "";
            else if (textBox1.Text.Equals("Username") & sender == textBox1)
                textBox1.Text = "";
        }

        public void AddText(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNewPassword.Text) & sender == txtNewPassword)
            {
                txtNewPassword.Text = "New Password";
            }
            else if (String.IsNullOrWhiteSpace(txtRe_enterPassword.Text) & sender == txtRe_enterPassword)
            {
                txtRe_enterPassword.Text = "Confirm Your Password";
            }
            else if (String.IsNullOrWhiteSpace(textBox1.Text) & sender == textBox1)
            {
                textBox1.Text = "Username";
            }
        }
    }
}