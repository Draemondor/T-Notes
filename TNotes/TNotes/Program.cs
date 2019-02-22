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



            /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());       
            */

            Console.WriteLine(sql.changeUserName(1, "bob", "BOB"));
            Console.WriteLine(sql.changePassword(1, "Frank", "frank"));
            sql.login("BOB", "frank");
            
        }
    }
}
