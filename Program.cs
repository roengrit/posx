using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PosX
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
            Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;
            Application.Run(new FormMain());
        }
    }
}
