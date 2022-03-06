using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region WAVCONTACT using
using WavContact.Controllers;
using WavContact.Metier;
using WavContact.Views.Member;
using WavContact.Models;
using WavContact.Views;
#endregion

namespace WavContact.Controllers.Waview
{
    public class WaviewPageClientController
    {
        #region Variables privées
        private FrmWaviewPageClient frm;
        private User client;
        #endregion

        #region GETTER / SETTER
        public User SelectedClient { 
            get => client; 
            set => client = value; 
        }

        /// <summary>
        /// Constructeur par défaut d'un contrôleur de vue de FrmWaviewPageClient
        /// </summary>
        /// <param name="frm">La forme que le contrôleur contrôle</param>
        /// <param name="client">Le client en question</param>
        public WaviewPageClientController(FrmWaviewPageClient frm, User client)
        {
            this.frm = frm;
            this.SelectedClient = client;
        }
        #endregion

        public List<Project> GetProjectsOfClient(User u)
        {
            return u.Projets;
        }

        public void LoadProjectPage(Project p)
        {
            FrmWaviewProject frm = new FrmWaviewProject(p);
            frm.Show();
        }
    }
}
