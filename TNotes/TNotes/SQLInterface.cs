using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Data;

public class SQLInterface
{
    // You may need to change "port" in the string below to reflect the port you used in the initial setup.
    string connStr = "server=localhost;user=root;database=t-notes;port=3306;password=pain";
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
    //Return -3 if illegal character detected.
    public int login(string un, string pw)
    {
        un = un.Trim();
        pw = pw.Trim();

        //Illegal Character detection and filtration:
        char[] illegalChars = { '\'', '\"', ';', '@' };
        for (int i = 0; i < illegalChars.Length; i++)
            if (pw.Contains(illegalChars[i]) || un.Contains(illegalChars[i]))
                return -3;

        //If no illegal characters were detected, proceed.
        int id;
        string q = "select user.user_id, user.first_name, user.last_name from user where user.username = '" + un + "' and user.password = '" + pw + "';";
        Console.WriteLine(q);
        List<List<string>> result = query(q);
        if (result.Count == 1)
        {
            Console.WriteLine("Welcome, " + result.ElementAt(0).ElementAt(1) + " " + result.ElementAt(0).ElementAt(2) + "!");
            id = Convert.ToInt32(result.ElementAt(0).ElementAt(0));
        }
        else if (result.Count > 1)
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

        //Illegal Character detection and filtration:
        char[] illegalChars = { '\'', '\"', ';', '@' };
        for (int i = 0; i < illegalChars.Length; i++)
            if (newUN.Contains(illegalChars[i]))
                return false;

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
            q = "update User set username = '" + newUN + "' where username = '" + oldUN + "' and user_id = " + id + ";";
            //Generate and append verification query.            
            q += "select username from user where username = \'" + newUN + "\' and user_id = " + id + ";";
            r = query(q);
            //Verify the update query succeeded in changing the username.
            return r.ElementAt(0).ElementAt(0).Equals(newUN);

        }
        else return false;
    }
    public bool changePassword(int id, string oldPW, string newPW)
    {
        //Trim the information. 
        oldPW = oldPW.Trim();
        newPW = newPW.Trim();

        //Illegal Character detection and filtration:
        char[] illegalChars = { '\'', '\"', ';', '@' };
        for (int i = 0; i < illegalChars.Length; i++)
            if (newPW.Contains(illegalChars[i]))
                return false;

        //Verify existing information.
        string q = "select * from user where password = \'" + oldPW + "\' and user_id = " + id;
        List<List<string>> r = query(q);
        //If the info checks out, go ahead with the password change.
        if (r.Count == 1)
        {
            //Generate the password change query.
            q = "update User set password = '" + newPW + "' where password = '" + oldPW + "' and user_id = " + id + ";";
            //Generate and appaned a verification query.
            q += "select password from user where password = \'" + newPW + "\' and user_id = " + id + ";";
            //Execute the query.
            r = query(q);
            //Verify that the password was changed correctly.
            return r.ElementAt(0).ElementAt(0).Equals(newPW);

        }
        else return false;
    }
    //Add a user to the database. Return the user id. Return -1 on failure. 
    //Return -3 for illegal characters. 
    public int addUser(string username, string password, string first, string last)
    {
        //Illegal Character detection and filtration:
        char[] illegalChars = { '\'', '\"', ';', '@' };
        for (int i = 0; i < illegalChars.Length; i++)
            if (password.Contains(illegalChars[i]) || username.Contains(illegalChars[i])
            || first.Contains(illegalChars[i]) || last.Contains(illegalChars[i]))
                return -3;

        //Check to see if username is already taken. 
        string q = "select count(username) from user where username = '" + username + "';";
        List<List<string>> r = query(q);
        //If it's not, then proceed to add the user. 
        if (Convert.ToInt32(r.ElementAt(0).ElementAt(0)) == 0)
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
    //Associate a keyword with a note by note_id.
    private void include(string keyword, int note_id)
    {
        //Trim the keyword of leading and trailing spaces.
        keyword = keyword.Trim();
        //Check to see if the keyword is already registered as a keyword.
        string s = "keyword_id from keyword where keyword LIKE '" + keyword + "';";
        List<List<string>> r = query(s);
        int count = r.Count;

        //If it's a keyword already, follow up with the contains table.
        if (count > 0)
        {
            //See if the keyword is already associated with the note_id provided. 
            int keyword_id = Convert.ToInt32(r.ElementAt(0).ElementAt(0));
            s = "select keyword_id, note_id from contains where keyword_id = " + keyword_id + " and note_id = " + note_id + ";";
            r = query(s);
            // If they're already associated, say so.
            if (r.Count > 0)
            {
                Console.WriteLine(keyword + " is alreardy registered for Note ID " + note_id + ".");
            }
            //If the keyword isn't associated, we need to add an entry in the contains table.
            else
            {
                //Generate the value.
                string value = "(" + keyword_id + "," + note_id + ")";
                //Generate the query.
                s = "insert into contains(keyword_id, note_id) value " + value + ";";
                //Execture the query.
                query(s);
            }
        }
        //If the keyword doesn't already exist, we need to create it.
        else
        {
            //The keyword id will be one more than the number of existing keywords.
            int keyword_id = count + 1;
            //Generate keyword table record.
            string value = "(" + keyword_id + "," + keyword + ")";
            //Generate instruction to add record to keyword.
            s = "insert into keyword(keyword_id, keyword) value " + value + ";";
            //Generate contains table record.
            value = "(" + keyword_id + "," + note_id + ")";
            //Generate and append an instruction to add the contains record.
            s += "insert into contains(keyword_id, note_id) value " + value + ";";
            //Execute the query.
            query(s);
        }
    }
    //Associate a list of keywords with a note by note_id.
    public void includeMultiple(List<string> keysIn, int note_id)
    {
        List<string> keywords = new List<string>();
        //Trim the elements of the list: 
        for (int i = 0; i < keysIn.Count; i++)
            keywords.Add(keywords.ElementAt(i).Trim());
        //Eliminate Duplicates.
        List<string> keys = keywords.Distinct().ToList();
        //For each keyword, include it in the database.
        for (int i = 0; i < keys.Count; i++)
            include(keys.ElementAt(i), note_id);
    }

    void deleteNote(int id)
    {
        //Delete the note directly.
        string s = "delete from Note where note_id = " + id + ";";
        //Delete references to the note in the is_taking relation.
        s += "delete from is_taking where note_id = " + id + ";";
        //Delete isolated keywords:
        //Get the keywords associated with the notes.
        string t = "select C.keyword_id, count(C.keyword_id) from (select keyword_id, from contains where note_id = " + id + ") as T, contains as C where C.keyword_id = T.keyword_id;";
        List<List<string>> q = query(t);
        for (int i = 0; i < q.Count; i++)
        {
            if (Convert.ToInt32(q[i][1]) == 1)
                s += "deleteNote from keywords where keyword_id = " + q[i][0] + ";";
        }
        //Delete contains entries associated with the note.
        s += "delete from contains where note_id = " + id + ";";
        query(s);
    }

    //UPDATE NOTE:

    bool changeTitle(int note_id, string title)
    {
        //Verify data integrity
        title = title.Trim();
        char[] illegalChars = { '\'', '\"', ';', '@' };
        for (int i = 0; i < illegalChars.Length; i++)
            if (title.Contains(illegalChars[i]))
                return false;

        //Make the change
        string s = "update note set title = '" + title + "' where note_id = " + note_id + ";";

        //Verify the change
        s += "select title from note where note_id = " + note_id + ";";
        List<List<string>> q = query(s);

        //Report success/fail.
        return q[0][0].Equals(title);
    }
    bool changeChapter(int note_id, int chapter)
    {
        //Verify input integrity
        if (chapter < 0) return false;

        //Make the change
        string s = "update note set chapter = " + chapter + " where note_id = " + note_id + ";";

        //Verify the change
        s += "select chapter from note where note_id = " + note_id + ";";
        List<List<string>> q = query(s);

        //Report success/fail.
        return q[0][0].Equals(chapter + "");
    }
    bool changeSection(int note_id, int section)
    {
        //Verify input integrity
        if (section < 0) return false;

        //Make the change
        string s = "update note set section = " + section + " where note_id = " + note_id + ";";

        //Verify the change
        s += "select section from note where note_id = " + note_id + ";";
        List<List<string>> q = query(s);

        //Report success/fail.
        return q[0][0].Equals(section + "");
    }
    bool changeDate(int note_id, string date)
    {
        //Verify input integrity
        date = date.Trim();
        char[] illegalChars = { '\'', '\"', ';', '@' };
        for (int i = 0; i < illegalChars.Length; i++)
            if (date.Contains(illegalChars[i]))
                return false;
        //Make the change
        string s = "update note set date = '" + date + "' where note_id = " + note_id + ";";

        //Verify the change
        s += "select date from note where note_id = " + note_id + ";";
        List<List<string>> q = query(s);

        //Report success/fail.
        return q[0][0].Equals(date);
    }
    bool changeSummary(int note_id, string summary)
    {
        summary = summary.Trim();
        //Verify input integrity
        char[] illegalChars = { '\'', '\"', ';', '@' };
        for (int i = 0; i < illegalChars.Length; i++)
            if (summary.Contains(illegalChars[i]))
                return false;

        //Make the change
        string s = "update note set summary = '" + summary + "' where note_id = " + note_id + ";";

        //Verify the change
        s += "select summary from note where note_id = " + note_id + ";";
        List<List<string>> q = query(s);

        //Report success/fail.
        return q[0][0].Equals(summary);
    }/*
    bool changeBody(int note_id, byte[] body)
    {
        updateKeywords(note_id, body);
        //update the body
        string s = "update note set body = '" + body + "' where note_id = " + note_id + ";";
        //verify the body updated successfully
        s += "select body from note where note_id = "+note_id + ";";
        List<List<string>> q = query(s);
        //Report success/fail.
        bool good = true; 
        for(int i = 0; i < body.Count(); i++)
        {
            good = good && q[0][0].Equals(body[i] + "");
        }
        return good;
    }/*
    */

    //get all notes
    List<List<string>> getAllNotes()
    {
        return query("select note_id, note_title, chapter, section, date, summary from note");
    }
    //get all notes under a course by id
    List<List<string>> getNoteByCourse(int id)
    {
        return query("select note_id, note_title, chapter, section, date, summary from note, " +
            "(select note_id from isTaking where course_id = " + id + ") as T" +
            "where note.note_id = T.note_id");
    }
    //get note by id
    List<List<string>> getNoteById(int id)
    {
        return query("select * from note where note_id = " + id + ";");
    }
    //get notes by keywords
    //getCourseByKeywords framework: See phone picture

    List<List<string>> getCourseByKeywords(List<string> keywords)
    {
        //remove duplicates and SQL injection potentials.
        List<string> keys = keywords.Distinct().ToList();
        char[] illegalChars = { '\'', '\"', ';', '@' };
        for (int i = 0; i < illegalChars.Length; i++)
            for (int j = keys.Count; j > -1; j--)
                if (keys.ElementAt(j).Contains(illegalChars[i]))
                    keys.RemoveAt(j);
        //generate query
        string s = "select note.note_id, note.note_title, note.chapter" +
                   ", note.section, note.date, note.summary from note, (";
        s += "select L.note_id sum(L.note_id) from (";
        for (int i = 0; i < keys.Count - 1; i++)
        {
            s += "( select note_id from keywords, contains where keywords.keyword like '"
                + keys.ElementAt(i) + "' and contains.keyword_id = keyword.keyword_id ) union";
        }
        s += "( select note_id from keywords, contains where keywords.keyword like '"
                + keys.ElementAt(keys.Count - 1) + "' and contains.keyword_id = keyword.keyword_id )";
        s += ") AS L group by L.note_id order by sum(L.note_id)) AS T where note.note_id = T.note_id;";
        return query(s);
    }
    //Add course
    public int addCourse(string name, string subject, string prof, int year, string semester)
    {
        //Illegal Character detection and filtration:
        char[] illegalChars = { '\'', '\"', ';', '@' };
        for (int i = 0; i < illegalChars.Length; i++)
            if (name.Contains(illegalChars[i]) || subject.Contains(illegalChars[i])
            || prof.Contains(illegalChars[i]) || semester.Contains(illegalChars[i]))
                return -3;

        //Check for already existing course with the same attributes.

        string s = "select id from coruse where (((course_name like '" + name + "' and (subject like '" + subject
            + "'))and ((prof like '" + prof + "') and (semester like '" + semester + "'))) and (year = " + year + ")";
        List<List<string>> q = query(s);
        //If it does, return its id instead.
        if (q.Count > 0)
            return Convert.ToInt32(q.ElementAt(0).ElementAt(0));


        //Get number of courses for id
        s = "select count(*) from course;";
        q = query(s);
        int id = Convert.ToInt32(q.ElementAt(0).ElementAt(0)) + 1;
        //Generate and execute course addition query
        s = "insert into course(course_id, course_name, subject, prof, semester, year) value (";
        s += id + ", ";
        s += name + ", ";
        s += subject + ", ";
        s += prof + ", ";
        s += semester + ", ";
        s += year + "); ";
        s += "select * from course where course_id = " + id + ";";
        q = query(s);
        //test result
        if (q.Count == 1)
            return id;
        return -1; // Something went horribly wrong.
    }

    //get all courses
    List<List<string>> getAllCourses()
    {
        return query("select * from course;");
    }

    public DataTable dtAllCourses()
    {
        conn.Open();
        DataTable dtCourse = new DataTable();
        MySqlDataAdapter da = new MySqlDataAdapter("select * from course;", conn);
        da.Fill(dtCourse);
        conn.Close();
        return dtCourse;
    }

    //get course by id
    List<List<string>> getCourseById(int id)
    {
        return query("select * from course where course_id = " + id + ";");
    }

}