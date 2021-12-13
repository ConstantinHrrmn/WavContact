using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WavContact.Views;
using WavContact.DB;

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
