using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WavContact.Controllers;
using WavContact.Metier;
using WavContact.DB;

namespace WavContact.Views.Client
{
    public partial class FrmMotDePasseOublie : Form
    {

        private string code = null;

        public FrmMotDePasseOublie()
        {
            InitializeComponent();
            this.SwitchMode();
        }

        public void SwitchMode()
        {
            this.BackColor = Darkmode.ChangeMode(this.Controls);
        }

        private void btnSwitchMode_Click(object sender, EventArgs e)
        {
            PropertiesManager.ChangeTheme();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSendCode_Click(object sender, EventArgs e)
        {
            if (WavContactPDO.UserExists(this.tbxEmail.Text))
            {
                this.ChangeSecondPart();

                //Génération du code à envoyer au client + stockage du code
                this.code = WavContactPDO.SendCodeEmail(this.tbxEmail.Text);
            }
            else
            {
                MessageBox.Show("Email doesn't match with any account...");
            }
        }

        private void ChangeButtonSendStatus()
        {
            this.btnSendCode.Enabled = this.tbxEmail.Text.Length > 1;
        }

        private void ChangeSecondPart()
        {
            this.lblCode.Enabled = true;
            this.tbxCode.Enabled = true;

            this.tbxMdp1.Enabled = true;
            this.tbxMdp2.Enabled = true;

            this.lblNouveauMotDePasse.Enabled = true;
            this.lblConfirmationMotDePasse.Enabled = true;

            this.tbxEmail.Enabled = false;
            this.btnSendCode.Enabled=false;
        }

        private void ChangeValidateButton()
        {
            this.btnEnregistrer.Enabled = this.tbxCode.Text.Length > 1 && this.tbxMdp1.Text.Length > 1 && this.tbxMdp2.Text.Length > 1;
        }

        private void tbxCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ChangeValidateButton();
        }

        private void tbxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ChangeButtonSendStatus();
        }

        private void FrmMotDePasseOublie_Load(object sender, EventArgs e)
        {

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (tbxCode.Text == this.code)
            {
                if (tbxMdp1.Text == tbxMdp2.Text)
                {
                    WavContactPDO.ResetUserPassword(tbxEmail.Text, tbxMdp1.Text);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Code dosen't match... Try again");
            }
        }
    }
}
