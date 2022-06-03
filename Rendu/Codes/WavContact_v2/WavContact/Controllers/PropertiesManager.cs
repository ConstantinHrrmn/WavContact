using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WavContact.Controllers
{
    public class PropertiesManager
    {
        public static void Login(string email, string password)
        {
            Properties.Settings.Default.email = email;
            Properties.Settings.Default.password = password;
            Properties.Settings.Default.Save();
        }

        public static void Logout()
        {
            Properties.Settings.Default.email = "";
            Properties.Settings.Default.password = "";
            Properties.Settings.Default.Save();
        }

        public static void ChangeTheme()
        {
            Properties.Settings.Default.darkmode = !Properties.Settings.Default.darkmode;
            Properties.Settings.Default.Save();
        }
    }
}
