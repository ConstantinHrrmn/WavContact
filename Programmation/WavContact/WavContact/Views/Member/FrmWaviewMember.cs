using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region WAVCONTACT using
using WavContact.Controllers;
using WavContact.Metier;
using WavContact.Models;
using WavContact.Views.Member;
#endregion

namespace WavContact.Views
{
    public partial class FrmWaviewMember : Form
    {
        #region Variables privées
        private WaviewMemberController ctrl;
        #endregion

        /// <summary>
        /// Constructeur par défaut de la form de gestion d'un membre de waview
        /// </summary>
        /// <param name="u">Le membre de waview connecté</param>
        public FrmWaviewMember(User u)
        {
            InitializeComponent();
            // Initialisation du controlleur
            this.ctrl = new WaviewMemberController(this, u);
        }

        private void FrmWaviewMember_Load(object sender, EventArgs e)
        {
            // Affichage du nom de la personne dans la ligne en haut
            this.lblWelcome.Text = string.Format("Hello {0} !", this.ctrl.ConnectedUser);
            // On met a jour le theme de la page en fonction de l'enregistrement de l'utilisateur
            this.SwitchMode();
        }

        #region MouseMoving
        private MovingForms mf = new MovingForms();
        private void frm_MouseDown(object sender, MouseEventArgs e)
        {
            this.mf.MouseDown(this.Location);
        }

        private void frm_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.mf.CanDrag())
                this.Location = this.mf.MouseMove(sender, e);
        }

        private void frm_MouseUp(object sender, MouseEventArgs e)
        {
            this.mf.MouseUp();
        }
        #endregion

        #region Buttons
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.ctrl.Logout();
            Application.Restart();
        }
        
        private void btnSwitchMode_Click(object sender, EventArgs e)
        {
            PropertiesManager.ChangeTheme();
            this.SwitchMode();
        }
        #endregion

        #region SelectedIndexChange
        private void lbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadProjectsForClient(this.ctrl.GetProjectsForUser(this.lbClients.SelectedItem as User));
        }

        private void lbProjets_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ctrl.LoadProjectPage(this.lbProjets.SelectedItem as Project);
        }
        #endregion

        /// <summary>
        /// Passage du darkmode au lightmode et vice versa
        /// </summary>
        public void SwitchMode()
        {
            this.BackColor = Darkmode.ChangeMode(this.Controls);
        }

        /// <summary>
        /// Charger la liste des clients dans la liste de la vue
        /// </summary>
        /// <param name="clients">La liste de clients (user) à afficher dans la vue</param>
        public void LoadClients(List<User> clients)
        {
            this.lbClients.Items.Clear();

            foreach (User item in clients)
            {
                this.lbClients.Items.Add(item);
            }
        }

        /// <summary>
        /// Charger les projets du clients dans la vue
        /// </summary>
        /// <param name="projects">Les projets a afficher</param>
        public void LoadProjectsForClient(List<Project> projects)
        {
            this.lbProjets.Items.Clear();

            foreach (Project item in projects)
            {
                this.lbProjets.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmWaviewChat chat = new FrmWaviewChat();
            chat.ShowDialog();
        }
    }
}
