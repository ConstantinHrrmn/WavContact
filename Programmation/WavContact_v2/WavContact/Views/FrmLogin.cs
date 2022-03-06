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

        public LoginController Ctrl { get => ctrl; set => ctrl = value; }
        #endregion

        /// <summary>
        /// Constructeur par défaut de la form de login
        /// </summary>
        public FrmLogin()
        {
            InitializeComponent();
            this.Ctrl = new LoginController(this);
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
            this.PerformLogin();
        }

        public void PerformLogin()
        {
            if (this.tbxEmail.Text.Length > 0 && this.tbxPassword.Text.Length > 0)
            {
                //System.Diagnostics.Debug.WriteLine(WavContactPDO.Login(this.tbxEmail.Text, this.tbxPassword.Text));
                if (this.Ctrl.PerformLogin(this.tbxEmail.Text, this.tbxPassword.Text))
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
            this.BackColor = Darkmode.ChangeMode(this.Controls);
            if (this.BackColor == Color.Black)
            {
                this.pbLogo.Image = Properties.Resources.Illustration_sans_titre_2;
            }
            else
            {
                this.pbLogo.Image = Properties.Resources.Illustration_sans_titre;
            }
        }

        private void btnSwitchMode_Click(object sender, EventArgs e)
        {
            PropertiesManager.ChangeTheme();
            this.SwitchMode();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Views.Client.FrmMotDePasseOublie frm = new Views.Client.FrmMotDePasseOublie();
            frm.ShowDialog();
        }
    }
}
