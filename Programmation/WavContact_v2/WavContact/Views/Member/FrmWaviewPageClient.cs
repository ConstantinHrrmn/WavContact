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
using WavContact.Views.Member;
#endregion

namespace WavContact.Views.Member
{
    public partial class FrmWaviewPageClient : Form
    {
        #region Variables privées
        private WaviewPageClientController ctrl;
        #endregion


        /// <summary>
        /// Constructeur par défaut de la form de la page du client
        /// </summary>
        public FrmWaviewPageClient(User u)
        {
            InitializeComponent();
            this.ctrl = new WaviewPageClientController(this, u);
        }

        private void FrmWaviewPageClient_Load(object sender, EventArgs e)
        {   
            this.lblNomClient.Text = string.Format("{0}", this.ctrl.SelectedClient);
            this.SwitchMode();
            
        }

        #region SWTICHMODE
        /// <summary>
        /// Passage du darkmode au lightmode et vice versa
        /// </summary>
        public void SwitchMode()
        {
            this.BackColor = Darkmode.ChangeMode(this.Controls);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            FrmWaviewChat chat = new FrmWaviewChat();
            chat.ShowDialog();
        }


        private void lstListeProjet_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.ctrl.LoadProjectPage(this.lstListeProjet.SelectedItem as Project);
        }
        
    }
}
