using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WavContact.Views;
using WavContact.DB;
using System.Diagnostics;

namespace WavContact
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Debug.WriteLine(Properties.Settings.Default.email);
            Debug.WriteLine(Properties.Settings.Default.password);

            if (Properties.Settings.Default.email == "")
            {
                Application.Run(new FrmLogin());
            }
            else
            {
                Application.Run(new FrmWaviewPagePrincipale(WavContactPDO.Login(Properties.Settings.Default.email, Properties.Settings.Default.password)));
            }
        }
    }
}
