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

        public void SwitchMode()
        {
            this.btnSwitchMode.Text = Properties.Settings.Default.darkmode ? "Light" : "Dark";
            this.lblWelcome.ForeColor = Properties.Settings.Default.darkmode ? Color.White : Color.Black;
            this.btnSwitchMode.ForeColor = Properties.Settings.Default.darkmode ? Color.White : Color.Black;
            this.BackColor = Properties.Settings.Default.darkmode ? Color.Black : Color.White;
        }
    }
}
