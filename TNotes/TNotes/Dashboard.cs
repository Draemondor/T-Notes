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
        String noteString;

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
            DataTable courses = user.dtCourses();

            DataTable courses_copy = courses;

            courses.Columns.Remove("course_id");
            courses.Columns.Remove("user_id");
            courses.Columns.Remove("note-id");
            courses.Columns["course_name"].ColumnName = "Courses";
            courses.Columns["subject"].ColumnName = "Subject";
            courses.Columns["prof"].ColumnName = "Professor";
            courses.Columns["semester"].ColumnName = "Semester";
            courses.Columns["year"].ColumnName = "Year";
            dataGridView1.DataSource = courses;
            gridResize(dataGridView1);

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
            Console.Write(this.txtSearch.Text);
            string keywords = this.txtSearch.Text;
            Console.Write(keywords);
            string[] keywordsArray = keywords.Split(',');
            List<string> keywordsList = new List<string>();
            foreach (string s in keywordsArray)
            {
                keywordsList.Add(s);
            }
            if (keywordsList.Count != 0)
            {
                DataTable notes = user.searchByKeyword(keywordsList);
                dataGridView1.DataSource = notes;
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

        private void btnYear_Click(object sender, EventArgs e)
        {
            string year = Prompt.ShowDialog("Year You're Looking For?", "Year");
            DataTable courses = user.dtCourses();

            courses.DefaultView.RowFilter = "Convert(year,'System.String') LIKE '%" + year + "%'";

            courses.Columns.Remove("course_id");
            courses.Columns.Remove("user_id");
            courses.Columns.Remove("note-id");
            courses.Columns["course_name"].ColumnName = "Courses";
            courses.Columns["subject"].ColumnName = "Subject";
            courses.Columns["prof"].ColumnName = "Professor";
            courses.Columns["semester"].ColumnName = "Semester";
            courses.Columns["year"].ColumnName = "Year";
            dataGridView1.DataSource = courses;
            gridResize(dataGridView1);


        }

        private void btnSemester_Click(object sender, EventArgs e)
        {
            string semester = Prompt.ShowDialog("Semester You're Looking For?", "Semester");
            DataTable courses = user.dtCourses();

            courses.DefaultView.RowFilter = "Convert(semester,'System.String') LIKE '%" + semester + "%'";

            courses.Columns.Remove("course_id");
            courses.Columns.Remove("user_id");
            courses.Columns.Remove("note-id");
            courses.Columns["course_name"].ColumnName = "Courses";
            courses.Columns["subject"].ColumnName = "Subject";
            courses.Columns["prof"].ColumnName = "Professor";
            courses.Columns["semester"].ColumnName = "Semester";
            courses.Columns["year"].ColumnName = "Year";
            dataGridView1.DataSource = courses;
            gridResize(dataGridView1);


        }
        private void btnProfessor_Click(object sender, EventArgs e)
        {
            string prof = Prompt.ShowDialog("Professor You're Looking For?", "Professor");
            DataTable courses = user.dtCourses();

            courses.DefaultView.RowFilter = "Convert(prof,'System.String') LIKE '%" + prof + "%'";

            courses.Columns.Remove("course_id");
            courses.Columns.Remove("user_id");
            courses.Columns.Remove("note-id");
            courses.Columns["course_name"].ColumnName = "Courses";
            courses.Columns["subject"].ColumnName = "Subject";
            courses.Columns["prof"].ColumnName = "Professor";
            courses.Columns["semester"].ColumnName = "Semester";
            courses.Columns["year"].ColumnName = "Year";
            dataGridView1.DataSource = courses;
            gridResize(dataGridView1);


        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int course_id=-1;

            String note_title = Prompt.ShowDialog("What's The Title?", "Title");
            int note_chapter = Convert.ToInt32(Prompt.ShowDialog("Chapter?", "Chapter"));
            int note_section = Convert.ToInt32(Prompt.ShowDialog("Section?", "Section"));
            String note_summary = Prompt.ShowDialog("Short Summary?", "Summary");

            using (var courseForm = new SelectCourse(user))
            {
                var result = courseForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string course = courseForm.course;
                    string subject = courseForm.subj;
                    string prof = courseForm.prof;
                    string semester = courseForm.semester;
                    int year = Convert.ToInt32(courseForm.year);
                    if (courseForm.course_id == -5)
                        course_id = user.addCourse(course, subject, prof, semester, year);
                    else
                        course_id = courseForm.course_id;
                }
            }
            if(course_id>-1)
                user.addNotes(note_title, note_chapter, note_section, note_summary, richTextBox1.Text,course_id);
            richTextBox1.Clear();
        }

        private void gridResize(DataGridView dgv)
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            dataGridView1.Width = 447;
            richTextBox1.Show();
            buttonModify.Show();
            buttonSave.Show();
            buttonClose.Show();
            CreateYourNote.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            dataGridView1.Width = 447;
            richTextBox1.Show();
            buttonModify.Show();
            buttonSave.Show();
            buttonClose.Show();
            CreateYourNote.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            dataGridView1.Width = 873;
            richTextBox1.Hide();
            buttonModify.Hide();
            buttonSave.Hide();
            buttonClose.Hide();
            CreateYourNote.Hide();
        }
    }

    internal class Prompt
    {
        internal static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "T-Notes | "+caption,
                StartPosition = FormStartPosition.CenterScreen,
                ShowIcon = false,
                ShowInTaskbar = false
        };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}
