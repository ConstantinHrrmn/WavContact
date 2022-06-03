using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region WAVCONTACT using
using WavContact.Controllers;
using WavContact.Metier;
using WavContact.Views;
using WavContact.Views.Client;
using WavContact.Models;
using WavContact.DB;
using System.Diagnostics;
#endregion

namespace WavContact.Controllers
{
    public class LoginController
    {
        private FrmLogin frm;

        public LoginController(FrmLogin a_frm)
        {
            this.frm = a_frm;
        }

        public bool PerformLogin(string email, string password)
        {
            

            User loggedInUser = WavContactPDO.Login(email, password);

            //System.Diagnostics.Debug.WriteLine(loggedInUser);

            if (loggedInUser != null)
            {
                PropertiesManager.Login(email, password);

                if (loggedInUser.IdRole == 1)
                {
                    OpenApp.OpenLogged(loggedInUser);
                    return true;
                }
                else if(loggedInUser.IdRole == 2)
                {
                    FrmClientPagePrincipale viewClient = new FrmClientPagePrincipale(loggedInUser);
                    viewClient.Show();
                    return true;
                }
            }
            else
            {
                this.frm.DisplayMessage("Mot de passe ou utilisateur erroné...");
                return false;
            }

            return false;
        }
    }
}
