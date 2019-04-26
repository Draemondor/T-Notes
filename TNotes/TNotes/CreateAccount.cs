using System;
using System.Windows.Forms;

namespace TNotes
{
    public partial class CreateAccount : Form
    {
        User user;
        public CreateAccount(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateAnAccount_Click(object sender, EventArgs e)
        {
           if(user.addUser(textEmail.Text, txtConfirmPassword.Text, txtFirstName.Text, txtLastName.Text)>0)
            {
                this.Close();
            }
        }

        private void txtCreatePassword_TextChanged(object sender, EventArgs e)
        {
            if (this.txtCreatePassword.Text.Equals(this.txtConfirmPassword.Text))
            {
                this.confirm_icon.Image = global::TNotes.Properties.Resources.checkmark1;
            }
            else
            {
                this.confirm_icon.Image = global::TNotes.Properties.Resources.incorrect1;
                this.confirm_icon.Show();
            }
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (this.txtConfirmPassword.Text.Equals(this.txtCreatePassword.Text))
            {
                this.confirm_icon.Image = global::TNotes.Properties.Resources.checkmark1;
            }
            else
            {
                this.confirm_icon.Image = global::TNotes.Properties.Resources.incorrect1;
                this.confirm_icon.Show();
            }
        }

        public void RemoveText(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text.Equals("Confirm Your Password") & sender == txtConfirmPassword)
                txtConfirmPassword.Text = "";
            else if (txtCreatePassword.Text.Equals("Password") & sender == txtCreatePassword)
                txtCreatePassword.Text = "";
            else if (txtFirstName.Text.Equals("First Name") & sender == txtFirstName)
                txtFirstName.Text = "";
            else if (txtLastName.Text.Equals("Last Name") & sender == txtLastName)
                txtLastName.Text = "";
            else if (textEmail.Text.Equals("Username") & sender == textEmail)
                textEmail.Text = "";
        }

        public void AddText(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtConfirmPassword.Text) & sender == txtConfirmPassword)
            {
                txtConfirmPassword.Text = "Confirm Your Password";
            }
            else if (String.IsNullOrWhiteSpace(txtCreatePassword.Text) & sender == txtCreatePassword)
            {
                txtCreatePassword.Text = "Password";
            }
            else if (String.IsNullOrWhiteSpace(txtFirstName.Text) & sender == txtFirstName)
            {
                txtFirstName.Text = "First Name";
            }
            else if (String.IsNullOrWhiteSpace(txtLastName.Text) & sender == txtLastName)
            {
                txtLastName.Text = "Last Name";
            }
            else if (String.IsNullOrWhiteSpace(textEmail.Text) & sender == textEmail)
            {
                textEmail.Text = "Username";
            }
        }
    }
}
