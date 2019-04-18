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
        [MTAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            User currUser = new User();
            Form1 login = new Form1(currUser);
            //login.Show();
            Application.Run(login);  
        }
    }
}
