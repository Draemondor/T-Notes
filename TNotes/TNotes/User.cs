using System;
using static SQLInterface;
namespace TNotes
{
    public class User
    {
        SQLInterface connection = new SQLInterface();
        int user_id;
        public User()
        {

        }
        public int login(string username, string password)
        {
            //takes in username and password as strings
            //returns userID
            
            
            user_id = connection.login(username, password);
            return user_id;
        }
        public int changePass(string oldPass, string newPass)
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
        public int changeUser(string oldUser, string newUser)
        {
            //takes in userID, old username, new username
            //passes these into an interface function along with userID
            //returns 0 or 1 on success or fail
            if (connection.changeUserName(user_id, oldUser, newUser))
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
            //user_id = connection.addUser(username, password, first, last);
            if (user_id >=0)
            {
                return 1;
            }
            else return 0;
        }
        public int removeUser(string username, string password)
        {
            //takes in username and password for user to remove
            //passes these to an interface function along with userID
            //if (connection.removeUser(user_id, username, password))
           // {
                return 1;
           // }
           // else return 0;
        }
    }
}
