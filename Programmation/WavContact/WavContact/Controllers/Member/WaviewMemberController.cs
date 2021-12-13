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
#endregion

namespace WavContact.Controllers
{
    class WaviewMemberController
    {
        #region Variables privées
        private FrmWaviewPagePrincipale frm;
        private User connectedUser;

        private List<User> clients;
        #endregion

        #region GETTER / SETTER
        public User ConnectedUser { get => connectedUser; set => connectedUser = value; }
        #endregion

        /// <summary>
        /// Constructeur par défaut d'un controlleur de vue de la form Waview member
        /// </summary>
        /// <param name="a_frm">la form que controlle le controlleur</param>
        /// <param name="a_connectedUser">L'utilisateur connecté</param>
        public WaviewMemberController(FrmWaviewPagePrincipale a_frm, User a_connectedUser)
        {
            this.frm = a_frm;
            this.ConnectedUser = a_connectedUser;
            this.clients = new List<User>();
            this.clients = WavContact.DB.WavContactPDO.Clients();

            this.frm.LoadClients(this.clients);
        }

        public List<Project> GetProjectsForUser(User u)
        {
            return u.Projets;
        }

        public void Logout()
        {
            PropertiesManager.Logout();
        }

        public void LoadProjectPage(Project p)
        {
            FrmWaviewProjet frm = new FrmWaviewProjet(p);
            frm.Show();
        }


    }
}
