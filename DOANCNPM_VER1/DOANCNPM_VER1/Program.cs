using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOANCNPM_VER1.GUI;
using System.Data.SqlClient;

namespace DOANCNPM_VER1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DOANCNPM_VER1.GUI.GUI_MAIN.frmMain());
        }
    }
}
