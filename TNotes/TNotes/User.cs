using System;
using System.Data;
using static SQLInterface;
using System.Collections.Generic;
namespace TNotes
{
    public class User
    {
        SQLInterface connection = new SQLInterface();
        int user_id;
        string username;
        string password;
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
        public List<List<string>> searchByKeyword(List<string> keywords)
        {
            return connection.getNotesByKeywords(keywords);
        }
        public int addCourse(string course, string subject, string prof, string semester, int year)
        {
            return connection.addCourse(course, subject, prof, year, semester);
        }
        public int addNotes(string title, int chapter, int section, string summary, string body, int course_id)
        {
            return connection.addNote(title, chapter, section, DateTime.Today.ToString("MM/dd/yyyy"), summary, body, user_id, course_id);
        }
        public DataTable dtCourses()
        {
            return connection.dtAllCourses(this.user_id);
        }
    }
}
