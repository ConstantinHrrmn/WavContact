using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WavContact.Views;
using WavContact.DB;
using WavContact.Models;
using System.Diagnostics;
using WavContact.Views.Client;
using WavContact.Views.Member;

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
                User u = WavContactPDO.Login(Properties.Settings.Default.email, Properties.Settings.Default.password);

                if (u == null)
                {
                    Application.Run(new FrmLogin());
                }
                else
                {
                    if (u.IdRole == 1)
                    {
                        OpenApp.Open(u);
                        
                    }
                    else if (u.IdRole == 2)
                    {
                        Application.Run(new FrmClientPagePrincipale(u));
                    }
                }
            }
        }
    }
}
