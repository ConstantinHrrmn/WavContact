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
            this.lblWelcome.Text = string.Format("Hello {0} !", this.ctrl.ConnectedUser);
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

        /// <summary>
        /// Passage du darkmode au lightmode et vice versa
        /// </summary>
        public void SwitchMode()
        {
            Color backcolor = Properties.Settings.Default.darkmode ? Color.Black : Color.White;
            Color invertedColor = Properties.Settings.Default.darkmode ? Color.White : Color.Black;

            this.BackColor = backcolor;

            foreach (Control item in this.Controls)
            {
                item.BackColor = backcolor;
                item.ForeColor = invertedColor;

                if (item.Name == "btnClose")
                {
                    item.ForeColor = Color.Red;
                }

                if (item.Name == "btnSwitchMode")
                {
                    item.Text = Properties.Settings.Default.darkmode ? "Light" : "Dark";
                }
            }
        }

        public void LoadClients(List<User> clients)
        {
            this.lbClients.Items.Clear();

            foreach (User item in clients)
            {
                this.lbClients.Items.Add(item);
            }
        }

        public void LoadProjectsForClient(List<Project> projects)
        {
            this.lbProjets.Items.Clear();

            foreach (Project item in projects)
            {
                this.lbProjets.Items.Add(item);
            }
        }

        private void lbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadProjectsForClient(this.ctrl.GetProjectsForUser(this.lbClients.SelectedItem as User));
        }

        private void lbProjets_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ctrl.LoadProjectPage(this.lbProjets.SelectedItem as Project);
        }
    }
}
