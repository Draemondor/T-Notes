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
        public string sem { get; set; }
        public string year { get; set; }

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
            DataTable courses = user.dtCourses();
            
            foreach(DataRow row in courses.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for(int i=0; i<courses.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                listCourses.Items.Add(item);
            }
        }
    }
}
