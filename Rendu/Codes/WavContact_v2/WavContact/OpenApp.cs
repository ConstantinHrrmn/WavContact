using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WavContact.Models;
using WavContact.Views;
using WavContact.Views.Member;

namespace WavContact
{
    public class OpenApp
    {
        public static void Open(User u) {
            int h = Screen.PrimaryScreen.WorkingArea.Height;
            int w = Screen.PrimaryScreen.WorkingArea.Width;

            if (w < 2000 || h < 1200)
            {
                Debug.WriteLine("Small screen");
                Application.Run(new FrmWaviewPagePrincipale1080(u));
            }
            else
            {
                Debug.WriteLine("Big screen");
                Application.Run(new FrmWaviewPagePrincipale(u));
            }
        }

        public static void OpenLogged(User u)
        {
            int h = Screen.PrimaryScreen.WorkingArea.Height;
            int w = Screen.PrimaryScreen.WorkingArea.Width;

            if (w < 2000 || h < 1200)
            {
                Debug.WriteLine("Small screen");
                new FrmWaviewPagePrincipale1080(u).Show();
            }
            else
            {
                Debug.WriteLine("Big screen");
                new FrmWaviewPagePrincipale(u).Show();
            }
        }
    }
}
