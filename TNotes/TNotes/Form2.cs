using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TNotes
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void userSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread myThread = new Thread((ThreadStart)delegate { Application.Run(new UserSettings()); });
            myThread.Start();
        }
    }
}
