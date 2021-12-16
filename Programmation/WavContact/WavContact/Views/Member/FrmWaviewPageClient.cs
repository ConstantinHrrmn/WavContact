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
using WavContact.Controllers.Waview;
using WavContact.Metier;
using WavContact.Models;
using WavContact.Views;
#endregion

namespace WavContact.Views.Member
{
    public partial class FrmWaviewPageClient : Form
    {
        /// <summary>
        /// Constructeur par défaut de la form de la page du client
        /// </summary>
        public FrmWaviewPageClient(User u)
        {
            InitializeComponent();
        }

        private void FrmWaviewPageClient_Load(object sender, EventArgs e)
        {   
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

        #region SWITCHMODE
        /// <summary>
        /// Change between dark and light mode
        /// </summary>
        public void SwitchMode()
        {
            this.BackColor = Darkmode.ChangeMode(this.Controls);
        }
        #endregion

        #region BUTTONS
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpenChatWaview_Click(object sender, EventArgs e)
        {

        }
        #endregion


        private void btnModifier_Click(object sender, EventArgs e)
        {
            txtNomMandant.Enabled = true;
            txtMail.Enabled = true;
            txtTel.Enabled = true;
            txtAdresseRue.Enabled = true;
            txtAdresseVille.Enabled = true;
            txtAdresseCP.Enabled = true;
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Modification d'éléments", "Es-tu sûr d'apporter ces modications ?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (res.Equals(DialogResult.Yes))
            {
                txtNomMandant.Enabled = true;
                txtMail.Enabled = true;
                txtTel.Enabled = true;
                txtAdresseRue.Enabled = true;
                txtAdresseVille.Enabled = true;
                txtAdresseCP.Enabled = true;
            }
            
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            FrmWaviewChat chat = new FrmWaviewChat();
            chat.ShowDialog();
        }        
    }
}
