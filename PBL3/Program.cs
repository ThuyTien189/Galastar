using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.VIEWS;
using PBL3.VIEWS.User;
using PBL3.VIEWS.Admin;
using PBL3.VIEWS.Login;

namespace PBL3
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UnLoginPage());
        }
    }
}
