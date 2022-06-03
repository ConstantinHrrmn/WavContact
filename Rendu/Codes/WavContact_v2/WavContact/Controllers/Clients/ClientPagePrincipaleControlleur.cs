using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using WavContact;
using WavContact.Chat;
using WavContact.DB;
using WavContact.Models;
using WavContact.Views.Client;
using WavContact.Views.Member;

namespace WavContact.Controllers.Clients
{
    public class ClientPagePrincipaleControlleur
    {
        #region Variables privées
        private FrmClientPagePrincipale _form;
        private User _connectedUser;
        private List<Project> projets;
        #endregion

        #region Variables publiques
        public FrmClientPagePrincipale Form { get => _form; set => _form = value; }
        public User ConnectedUser { get => _connectedUser; set => _connectedUser = value; }
        #endregion


        /// <summary>
        /// Constructeur par défaut 
        /// </summary>
        /// <param name="a_form">La form mère</param>
        /// <param name="a_user">L'utilisateur connecté</param>
        public ClientPagePrincipaleControlleur(FrmClientPagePrincipale a_form, User a_user)
        {
            this.Form = a_form;
            this.ConnectedUser = a_user;
            this.projets = new List<Project>();
        }

        /// <summary>
        /// Met a jour la forme
        /// </summary>
        public void UpdateForm()
        {
            this.Form.UpdateForm();
        }

        /// <summary>
        /// Récupère et met a jour la liste des projets
        /// Met a jour la liste des projets dan la forme
        /// </summary>
        public void UpdateProjects()
        {
            this.ConnectedUser.Projets = WavContact.DB.WavContactPDO.ProjectsForUser(this.ConnectedUser);
            this.Form.UpdateProjectList(this.ConnectedUser.Projets);
        }

        /// <summary>
        /// Déconnecte l'utilisateur et quitte l'application
        /// </summary>
        public void Logout()
        {
            PropertiesManager.Logout();
        }

        /// <summary>
        /// Afficher la page du projet
        /// </summary>
        /// <param name="p">Le projet que l'on souhaite afficher</param>
        public void LoadProjectPage(Project p)
        {
            FrmWaviewProject frm = new FrmWaviewProject(p, this.ConnectedUser);
            frm.Show();
        }

        /// <summary>
        /// Met a jour (dans un Thread) le nombre de messages non-lus
        /// </summary>
        public void UpdateChatCount()
        {
            Thread t = new Thread(() =>
            {
                int amount = WavChatPDO.GetUnreadMessagesCount(this.ConnectedUser);
                this._form.UpdateChatCount(amount);
            });

            t.Start();
        }

        /// <summary>
        /// Met a jour (dans un Thread) le calendrier
        /// </summary>
        public void UpdateCalendar()
        {
            Thread t = new Thread(() =>
            {
                this._form.UpdateCalendar(DateTime.Now, WavContactPDO.GetCalendarClient(DateTime.Now, this.ConnectedUser));
            });

            t.Start();
        }

        /// <summary>
        /// Met a jour le calendrier (dans un Thread) a partir d'une date de début
        /// </summary>
        /// <param name="firstDay">La date de début</param>
        public void UpdateCalendar(DateTime firstDay)
        {
            Thread t = new Thread(() =>
            {
                this._form.UpdateCalendar(firstDay, WavContactPDO.GetCalendarClient(firstDay, this.ConnectedUser));
            });

            t.Start();
        }
        
        
    }
}
