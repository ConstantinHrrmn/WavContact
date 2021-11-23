using System;
using System.Windows.Forms;

#region WAVCONTACT using
using WavContact.Controllers;
using WavContact.Metier;
using WavContact.DB;
using System.Drawing;
#endregion

namespace WavContact
{
    public partial class FrmLogin : Form
    {
        #region Variables privées
        private MovingForms mf;
        private LoginController ctrl;
        #endregion

        /// <summary>
        /// Constructeur par défaut de la form de login
        /// </summary>
        public FrmLogin()
        {
            InitializeComponent();
            this.ctrl = new LoginController(this);
            this.mf = new MovingForms();
        }

        private void textBoxes_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("START APP");
            this.SwitchMode();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region MouseMoving
        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            this.mf.MouseDown(this.Location);
        }

        private void FrmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.mf.CanDrag())
                this.Location = this.mf.MouseMove(sender, e);
        }

        private void FrmLogin_MouseUp(object sender, MouseEventArgs e)
        {
            this.mf.MouseUp();
        }
        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (this.tbxEmail.Text.Length > 0 && this.tbxPassword.Text.Length > 0)
            {
                //System.Diagnostics.Debug.WriteLine(WavContactPDO.Login(this.tbxEmail.Text, this.tbxPassword.Text));
                
                this.ctrl.PerformLogin(this.tbxEmail.Text, this.tbxPassword.Text);
                this.Hide();
            }
            else
            {
                this.DisplayMessage("Merci d'entrer correctement toutes les informations de login");
            }
        }

        /// <summary>
        /// Affiche un message dans un messagebox
        /// </summary>
        /// <param name="message">Le message a afficher</param>
        public void DisplayMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void SwitchMode()
        {
            this.tbxEmail.BackColor = Properties.Settings.Default.darkmode ? Color.Black : Color.White;
            this.tbxPassword.BackColor = Properties.Settings.Default.darkmode ? Color.Black : Color.White;

            this.tbxEmail.ForeColor = Properties.Settings.Default.darkmode ? Color.White : Color.Black;
            this.tbxPassword.ForeColor = Properties.Settings.Default.darkmode ? Color.White : Color.Black;

            this.btnLogin.BackColor = Properties.Settings.Default.darkmode ? Color.Black : Color.White;
            this.btnLogin.ForeColor = Properties.Settings.Default.darkmode ? Color.White : Color.Black;

            this.BackColor = Properties.Settings.Default.darkmode ? Color.Black : Color.White;
            this.btnSwitchMode.ForeColor = Properties.Settings.Default.darkmode ? Color.White : Color.Black;

            this.pbLogo.Image = Properties.Settings.Default.darkmode ? Properties.Resources.blanc_vide_full : Properties.Resources.new_noir_bleu;
            this.btnSwitchMode.Text = Properties.Settings.Default.darkmode ? "Light" : "Dark";
        }

        private void btnSwitchMode_Click(object sender, EventArgs e)
        {
            PropertiesManager.ChangeTheme();
            this.SwitchMode();
        }
    }
}
