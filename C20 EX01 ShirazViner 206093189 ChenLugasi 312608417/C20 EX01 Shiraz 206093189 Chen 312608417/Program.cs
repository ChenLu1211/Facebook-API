using System;
using System.Windows.Forms;
using FacebookWrapper;

namespace C20_EX01_Shiraz_206093189_Chen_312608417
{
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormFacebook());
        }
    }
}
