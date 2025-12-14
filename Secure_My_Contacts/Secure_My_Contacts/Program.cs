using Secure_My_Contacts.Froms.Main_Forms;
using Secure_My_Contacts.Froms.Welcome;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secure_My_Contacts
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
            //Application.Run(new Welcome_Window());
            Application.Run(new Main_window());
        }
    }
}
