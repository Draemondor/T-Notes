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
    public partial class SelectCourse : Form
    {
        User user;

        public string course { get; set; }
        public string subj { get; set; }
        public string prof { get; set; }
        public string semester { get; set; }
        public string year { get; set; }

        string ctb = "Course";
        string stb = "Subject";
        string ptb = "Professor";
        string sem = "Semester";
        string ytb = "Year";

        public SelectCourse()
        {
            InitializeComponent();
        }

        public SelectCourse(User x)
        {
            this.user = x;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.course = coursetb.Text;
            this.subj = subjtb.Text;
            this.prof = proftb.Text;
            this.semester = semestertb.Text;
            this.year = yeartb.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void yeartb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void clear_OnFocus(object sender, EventArgs e)
        {
            if (coursetb.Text == ctb && sender == coursetb)
                coursetb.Text = "";
            else if (subjtb.Text == stb && sender == subjtb)
                subjtb.Text = "";
            else if (proftb.Text == ptb && sender == proftb)
                proftb.Text = "";
            else if (semestertb.Text == sem && sender == semestertb)
                semestertb.Text = "";
            else if (yeartb.Text == ytb && sender == yeartb)
                yeartb.Text = "";
        }

        private void resetText_OnLostFocus(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(coursetb.Text) & sender == coursetb)
                coursetb.Text = ctb;
            else if (String.IsNullOrWhiteSpace(subjtb.Text) & sender == subjtb)
                subjtb.Text = stb;
            else if (String.IsNullOrWhiteSpace(proftb.Text) & sender == proftb)
                proftb.Text = ptb;
            else if (String.IsNullOrWhiteSpace(semestertb.Text) & sender == semestertb)
                semestertb.Text = sem;
            else if (String.IsNullOrWhiteSpace(yeartb.Text) & sender == yeartb)
                yeartb.Text = ytb;
        }
    }
}
