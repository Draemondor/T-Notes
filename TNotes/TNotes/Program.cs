using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TNotes
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            SQLInterface sql = new SQLInterface();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //Demo query:
            string s = "select* from keyword";

            //Demo of print_query:
            sql.print_query(s);

            //Demo of query_to_string:
            Console.WriteLine(sql.query_to_string(s));

            //Demo of login functionality:
            int user_id = sql.login("user", "password");
            Console.WriteLine("user_id: " + user_id);
        }
    }
}
