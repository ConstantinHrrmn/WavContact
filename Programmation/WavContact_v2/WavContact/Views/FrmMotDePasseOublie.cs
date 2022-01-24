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

namespace WavContact.Views.Client
{
    public partial class FrmMotDePasseOublie : Form
    {
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
            this.ChangeSecondPart();
            WavContact.DB.WavContactPDO.SendCodeEmail(this.tbxEmail.Text);
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
    }
}
