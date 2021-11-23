using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region WAVCONTACT using
using WavContact.Controllers;
using WavContact.Metier;
using WavContact.Views;
using WavContact.Models;
using WavContact.DB;
#endregion

namespace WavContact.Controllers
{
    class LoginController
    {
        private FrmLogin frm;

        public LoginController(FrmLogin a_frm)
        {
            this.frm = a_frm;
        }

        public void PerformLogin(string email, string password)
        {
            User loggedInUser = WavContactPDO.Login(email, password);

            //System.Diagnostics.Debug.WriteLine(loggedInUser);

            if (loggedInUser != null)
            {
                PropertiesManager.Login(email, password);

                FrmWaviewMember viewMember = new FrmWaviewMember(loggedInUser);
                viewMember.Show(); 
                
            }
            else
            {
                this.frm.DisplayMessage("Mot de passe ou utilisateur éronné...");
            }
        }
    }
}
