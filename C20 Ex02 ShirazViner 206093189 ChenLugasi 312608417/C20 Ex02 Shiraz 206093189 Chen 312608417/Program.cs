using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace C20_Ex02_Shiraz_206093189_Chen_312608417
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormFacebook());
        }
    }
}
