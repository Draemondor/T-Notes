using System;
using static SQLInterface;
namespace TNotes
{
    public class User
    {
        public User()
        {
        }
        public int login(string username, string password)
        {//takes in username and password as strings
         //returns userID
            SQLInterface connection = new SQLInterface();
            
            return connection.login(username, password);
        }
        public int changePass()
        {//takes in userID, old password and new password
            //returns 0 or 1 on success or fail
            return 0;
        }
        public int changeUser()
        {
            //takes in userID, old username, new username
            //returns 0 or 1 on success or fail
            return 0;
        }
    }
}
