using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;

public class SQLInterface
{
    // You may need to change "port" in the string below to reflect the port you used in the initial setup.
    string connStr = "server=localhost;user=root;database=t-notes;port=1286;password=pain";
    MySqlConnection conn;
    static int transcount = 0;

    public SQLInterface()
    {
        //Establish connection path to the database. 
        conn = new MySqlConnection(connStr);
    }

    //Send a query wholesale to the server, and get back the raw data from its use. 
    private List<List<string>> query(string q)
    {
        //Create storage container for query result:
        List<List<string>> result = new List<List<string>>();
        //Create storage container for each row of the query:
        List<string> row = new List<string>();

        //The connection attempt could fail, so try catch is used. 
        try
        {
            //Attempt to connect to the database. 
            Console.WriteLine("Connecting to MySQL...");
            conn.Open();

            //Once connected, package and send the query to the database. 
            MySqlCommand cmd = new MySqlCommand(q, conn);
            //Unpack the result from the database. 
            MySqlDataReader rdr = cmd.ExecuteReader();

            //For each row in the unpacked result, do the following:
            while (rdr.Read())
            {
                //Create a new row to be added to the result list. 
                row = new List<string>();
                // for each element in the row of the result:
                for (int i = 0; i < rdr.FieldCount; i++)
                {
                    // Add it to the row as a string.
                    row.Add(rdr[i].ToString());
                }
                //Add each complete row to the overall container.
                result.Add(row);
            }
            //IMPORTANT: Close the resulting temporary output from the database.
            rdr.Close();
        }
        //If for some reason the connection failed, display the exception in the console and continue the program. 
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        //IMPORTANT: Close the connection to the server! If we failed to connect, it
        // will do nothing. If we connected, we must close the connection. We're done for now.
        conn.Close();

        //Give the result to whatevr requested it.
        return result;
    }
    //Print a query directly to console. 
    private void print_query(string s)
    {
        //Submit the query to the server.
        List<List<string>> result = query(s);

        //Break the query into columns and rows for output, and output on the fly.
        for (int i = 0; i < result.Count; i++)
        {
            for (int j = 0; j < result.ElementAt(i).Count; j++)
            {
                Console.Write(result.ElementAt(i).ElementAt(j) + "\t, ");
            }
            Console.WriteLine();
        }
    }
    //This generates a string identical to that which would be produced in the console by print_query. 
    private string query_to_string(string s)
    {
        string output = "";
        //Submit the query to the server. 
        List<List<string>> result = query(s);

        //Generate a string in the same manner as would be used for printing the query results to the console. 
        for (int i = 0; i < result.Count; i++)
        {
            for (int j = 0; j < result.ElementAt(i).Count; j++)
            {
                output += result.ElementAt(i).ElementAt(j) + "\t, ";
            }
            output += "\n";
        }

        //Give the string to whatever asked for it.
        return output;
    }
    //Create login query to the database according to the username and password provided. 
    //Return user_id of logged in user if successful.
    //Retuern -1 if the login failed, or -2 if there's a database error. 
    public int login(string un, string pw)
    {
        un = un.Trim();
        pw = pw.Trim();
        int id;
        string q = "select user.user_id, user.first_name, user.last_name from user where user.username = '"+un+"' and user.password = '"+pw+"';";
        Console.WriteLine(q);
        List<List<string>> result = query(q);
        if (result.Count == 1)
        {
            Console.WriteLine("Welcome, " + result.ElementAt(0).ElementAt(1) + " " + result.ElementAt(0).ElementAt(2) + "!");
            id = Convert.ToInt32(result.ElementAt(0).ElementAt(0));
        }else if(result.Count > 1)
        {
            Console.WriteLine("Database Error: Multiple username, password pairs identified.");
            id = -2;
        }
        else
        {
            Console.WriteLine("Login incorrect, or the account doesn't exist.");
            id = -1;
        }
        return id;
    }

    public bool changeUserName(int id, string oldUN, string newUN)
    {
        //Trim input.
        oldUN = oldUN.Trim();
        newUN = newUN.Trim();

        //Pull old information from the database to verify it.
        string q = "select * from user where username = \'" + oldUN + "\' and user_id = " + id;
        Console.WriteLine(q);
        List<List<string>> r = query(q);

        //If a unique id - UN was found, proceed. 
        if (r.Count == 1)
        {
            //Check to see if the new username is currently in use. 
            q = "select username from user where username = \'" + newUN + "\';";
            r = query(q);
            if (r.Count != 0)
            {
                //Immediately fail if it is. 
                return false;
            } //Otherwise, continue.

            //Generate the update query.
            q = "update User set username = '"+newUN+"' where username = '"+oldUN+ "' and user_id = " + id+";";
            query(q);
            //Verify the update query succeeded in changing the username.
            q = "select username from user where username = \'" + newUN + "\' and user_id = " + id;
            r = query(q);
            if (r.ElementAt(0).ElementAt(0).Equals(newUN))
                return true;
            else return false;

        }
        else return false;
    }
    public bool changePassword(int id, string oldPW, string newPW)
    {
        //Trim the information. 
        oldPW = oldPW.Trim();
        newPW = newPW.Trim();
        //Verify existing information.
        string q = "select * from user where password = \'" + oldPW + "\' and user_id = " + id;
        List<List<string>> r = query(q);
        //If the info checks out, go ahead with the password change.
        if (r.Count == 1)
        {
            //Generate the password change query.
            q = "update User set password = '" + newPW + "' where password = '" + oldPW + "' and user_id = " + id + ";";
            query(q);
            //Verify that the password was changed correctly.
            q = "select password from user where password = \'" + newPW + "\' and user_id = " + id;
            r = query(q);
            if (r.ElementAt(0).ElementAt(0).Equals(newPW))
                return true;
            else return false;

        }
        else return false;
    }
    //Add a user to the database. Return the user id. Return -1 on failure.
    public int addUser(string username, string password, string first, string last)
    {
        //Check to see if username is already taken. 
        string q = "select count(username) from user where username = '" + username + "';";
        List<List<string>> r = query(q);
        //If it's not, then proceed to add the user. 
        if(Convert.ToInt32(r.ElementAt(0).ElementAt(0)) == 0)
        {
            //Get the current count of users.
            q = "select count(*) from user;";
            r = query(q);
            //Add 1 to it for the new id.
            int id = Convert.ToInt32(r.ElementAt(0).ElementAt(0)) + 1;
            //Generate the new user record.
            q = "insert into user(user_id, username, password, first_name, last_name) value ("
                + id + ", '"
                + username + "', '"
                + password + "', '"
                + first + "', '"
                + last + "');";
            //Submit it to the database.
            r = query(q);
            //return the id for the new user. 
            return id;
        }
        //Otherwise, return -1.
        else
        {
            return -1;
        }
    }
    //Remove a user from the database. Return boolean success or fail. 
    //Additionally modifies trailing ids to keep count and latest id in lockstep.
    public bool removeUser(int id, string password)
    {

        //Verify that the id and password pair is good. 
        string s = "select id from user where id = " + id + "and password = '" + password + "';";
        List<List<string>> r = query(s);
        if (Convert.ToInt32(r.ElementAt(0).ElementAt(0)) == id)
        {
            //Delete user. 
            s = "delete from User where user_id = " + id + ";";
            r = query(s);
            //Generate cascade of id adjustments for remainder of users.
            s = "update User set user_id = user_id - 1 where user_id > " + id + ";";
            r = query(s);

            //report success.
            return true;
        }        
        //Report Failure.
        return false;
    }
}