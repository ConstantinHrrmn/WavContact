using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WavContact;
using WavContact.Models;
using WavContact.Views.Client;

namespace WavContact.Controllers.Clients
{
    class ClientPagePrincipaleControlleur
    {
        private FrmClientPagePrincipale _form;
        private User _connectedUser;

        private List<Project> projets;

        public ClientPagePrincipaleControlleur(FrmClientPagePrincipale a_form, User a_user)
        {
            this.Form = a_form;
            this.ConnectedUser = a_user;
            this.projets = new List<Project>();
        }

        public void UpdateForm()
        {
            this.Form.UpdateForm();
        }

        public void UpdateProjects()
        {
            this.ConnectedUser.Projets = WavContact.DB.WavContactPDO.ProjectsForUser(this.ConnectedUser);
            this.Form.UpdateProjectList(this.ConnectedUser.Projets);
        }

        public void Logout()
        {
            PropertiesManager.Logout();
        }

        public FrmClientPagePrincipale Form { get => _form; set => _form = value; }
        public User ConnectedUser { get => _connectedUser; set => _connectedUser = value; }
    }
}
