using hrAPP.Helpers;
using System;
using System.Windows.Forms;

namespace hrAPP
{
    internal static class hrAPP
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DatabaseHelper.InitalizeAccessDb();
            Application.Run(new LoginForm());
        }
    }
}
