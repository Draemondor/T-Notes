using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;

public class SQLInterface
{
    // You may need to change "port" in the string below to reflect the port you used in the initial setup.
    string connStr = "server=localhost;user=root;database=t-notes;port=1286;password=pain";
    MySqlConnection conn;

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
    public void print_query(string s)
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
    public string query_to_string(string s)
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
        int id;
        string q = "select user.user_id, user.first_name, user.last_name from user where user.username = '"+un+"' and user.password = '"+pw+"';";
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

}