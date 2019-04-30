using System;
using System.Data;
using static SQLInterface;
using System.Collections.Generic;
using System.Linq;

namespace TNotes
{
    public class User
    {
        SQLInterface connection = new SQLInterface();
        int user_id;
        string username;
        string password;
        List<List<string>> arr = new List<List<string>>();
        public User()
        {

        }
        
        public void setAttributes(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string getUsername()
        {
            return this.username;
        }

        public string getPassword()
        {
            return this.password;
        }

        public int login(string username, string password)
        {
            //takes in username and password as strings
            //returns userID
            
            
            user_id = connection.login(username, password);
            return user_id;
        }
        public int changePass(int uid, string oldPass, string newPass)
        {
            //takes in userID, old password and new password
            //passes these into an interface function along with userID
            //returns 0 or 1 on success or fail
            if (connection.changePassword(user_id, oldPass, newPass))
            {
                return 1;
            }
            else return 0;
        }
        public int weakChangePass(string username, string newPass)
        {
            if (connection.weakChangePassword(username, newPass)>0)
            {
                return 1;
            }
            else return 0;
        }
        public int changeUser(int uid, string oldUser, string newUser)
        {
            //takes in userID, old username, new username
            //passes these into an interface function along with userID
            //returns 0 or 1 on success or fail
            if (connection.changeUserName(uid, oldUser, newUser))
            {
                return 1;
            }
            else return 0;
        }
        public int addUser(string username, string password, string first, string last)
        {
            //takes in username and password for new user
            //passes these into an interface function
            //returns userID
            user_id = connection.addUser(username, password, first, last);
            if (user_id >=0)
            {
                return 1;
            }
            else return 0;
        }
        public bool removeUser(int uid, string password)
        {
            //takes in username and password for user to remove
            //passes these to an interface function along with userID
            if (connection.removeUser(uid,  password))
            {
                return true;
            }
            else return false;
        }
        public DataTable searchByKeyword(List<string> keywords)
        {
            
            this.arr = connection.getNotesByKeywords(keywords);

            DataTable notes;
            DataColumn column;
            DataRow row;
            if (arr.Count <= 0)
                return null;
            int i = arr.ElementAt(0).Count;
            int j = arr.Count;
            notes = new DataTable("Notes");
            
            //add first column
            column = new DataColumn("Note ID");
            column.DataType = System.Type.GetType("System.String");
            column.Caption = "Note ID";
            column.ReadOnly = true;
            column.Unique = true;
            notes.Columns.Add(column);
            //add second column
            column = new DataColumn("Note Name");
            column.DataType = System.Type.GetType("System.String");
            column.Caption = "Note Name";
            column.ReadOnly = true;
            notes.Columns.Add(column);
            //add third column
            column = new DataColumn("Chapter");
            column.DataType = System.Type.GetType("System.String");
            column.Caption = "Chapter";
            column.ReadOnly = true;
            notes.Columns.Add(column);
            //add fourth column
            column = new DataColumn("Section");
            column.DataType = System.Type.GetType("System.String");
            column.Caption = "Section";
            column.ReadOnly = true;
            notes.Columns.Add(column);
            //add fifth column
            column = new DataColumn("Date");
            column.DataType = System.Type.GetType("System.String");
            column.Caption = "Date";
            column.ReadOnly = true;
            notes.Columns.Add(column);
            //add sixth column
            column = new DataColumn("Summary");
            column.DataType = System.Type.GetType("System.String");
            column.Caption = "Summary";
            column.ReadOnly = true;
            notes.Columns.Add(column);

            //add rows of data

            while (0 < j)
            {
                row = notes.NewRow();
                row["Note ID"] = (arr.ElementAt(j - 1).ElementAt(0));
                row["Note Name"] = arr.ElementAt(j - 1).ElementAt(1);
                row["Chapter"] = arr.ElementAt(j - 1).ElementAt(2);
                row["Section"] = arr.ElementAt(j - 1).ElementAt(3);
                row["Date"] = arr.ElementAt(j - 1).ElementAt(4);
                row["Summary"] = arr.ElementAt(j - 1).ElementAt(5);
                notes.Rows.Add(row);
                j--;
            }
            



            return notes;
        }

        public List<List<string>> getNoteArr()
        {
            return this.arr;
        }

        public int addCourse(string course, string subject, string prof, string semester, int year)
        {
            return connection.addCourse(course, subject, prof, year, semester);
        }
        public int addNotes(string title, int chapter, int section, string summary, string body, int course_id)
        {
            string date = DateTime.Today.ToString("yyyy-MM-dd");
            Console.WriteLine(date);
            return connection.addNote(title, chapter, section, date, summary, body, user_id, course_id);
        }
        public DataTable dtCourses()
        {
            return connection.dtAllCourses(this.user_id);
        }

        public List<string> openNote(int note_id)
        {
            List<List<string>> response = new List<List<string>>();
            response = connection.getNoteById(note_id);
            Console.WriteLine("Retrieved");
            List<string> note = response.ElementAt(0);
            return note;
        }

        public void updateBody(int note_id, string body)
        {
            connection.updateBody(note_id, body);
        }

        public DataTable getNotesByCourse(int course_id)
        {
            List<List<string>> arr = new List<List<string>>();
            arr = connection.getNoteByCourse(course_id, this.user_id);


            DataTable notes;
            DataColumn column;
            DataRow row;
            if (arr.Count <= 0)
                return null;
            int i = arr.ElementAt(0).Count;
            int j = arr.Count;
            notes = new DataTable("Notes");

            //add first column
            column = new DataColumn("Note ID");
            column.DataType = System.Type.GetType("System.String");
            column.Caption = "Note ID";
            column.ReadOnly = true;
            column.Unique = true;
            notes.Columns.Add(column);
            //add second column
            column = new DataColumn("Note Name");
            column.DataType = System.Type.GetType("System.String");
            column.Caption = "Note Name";
            column.ReadOnly = true;
            notes.Columns.Add(column);
            //add third column
            column = new DataColumn("Chapter");
            column.DataType = System.Type.GetType("System.String");
            column.Caption = "Chapter";
            column.ReadOnly = true;
            notes.Columns.Add(column);
            //add fourth column
            column = new DataColumn("Section");
            column.DataType = System.Type.GetType("System.String");
            column.Caption = "Section";
            column.ReadOnly = true;
            notes.Columns.Add(column);
            //add fifth column
            column = new DataColumn("Date");
            column.DataType = System.Type.GetType("System.String");
            column.Caption = "Date";
            column.ReadOnly = true;
            notes.Columns.Add(column);
            //add sixth column
            column = new DataColumn("Summary");
            column.DataType = System.Type.GetType("System.String");
            column.Caption = "Summary";
            column.ReadOnly = true;
            notes.Columns.Add(column);

            //add rows of data

            while (0 < j)
            {
                row = notes.NewRow();
                row["Note ID"] = (arr.ElementAt(j - 1).ElementAt(0));
                row["Note Name"] = arr.ElementAt(j - 1).ElementAt(1);
                row["Chapter"] = arr.ElementAt(j - 1).ElementAt(2);
                row["Section"] = arr.ElementAt(j - 1).ElementAt(3);
                row["Date"] = arr.ElementAt(j - 1).ElementAt(4);
                row["Summary"] = arr.ElementAt(j - 1).ElementAt(5);
                notes.Rows.Add(row);
                j--;
            }
            if (notes != null)
                Console.Write("Success");
            return notes;
        }


        public void deleteNote(int note_id)
        {
            connection.deleteNote(note_id);
        }
    }
}
