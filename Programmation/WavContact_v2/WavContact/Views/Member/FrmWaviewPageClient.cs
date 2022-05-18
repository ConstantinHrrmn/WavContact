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

        private bool newClient;
        private User _client;

        public User Client { get => _client; set => _client = value; }
        #endregion


        /// <summary>
        /// Constructeur par défaut de la form de la page du client
        /// </summary>
        public FrmWaviewPageClient(User u)
        {
            InitializeComponent();
            this.ctrl = new WaviewPageClientController(this, u);
            this.newClient = false;

            this.Client = this.ctrl.SelectedClient;
            this.lblNomClient.Text = string.Format("{0}", u.ToString());
            this.tbxNom.Text = u.Last_name;
            this.tbxPrenom.Text = u.First_name;
            this.tbxMail.Text = u.Email;
            this.tbxTel.Text = u.Phone;
            this.SwitchMode();
        }

        public FrmWaviewPageClient()
        {
            InitializeComponent();
            this.newClient = true;
            this.SwitchMode();
        }

        private void FrmWaviewPageClient_Load(object sender, EventArgs e)
        {
            
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
            tbxPrenom.Enabled = true;
            tbxMail.Enabled = true;
            tbxTel.Enabled = true;
            tbxAdresseRue.Enabled = true;
            tbxAdresseVille.Enabled = true;
            tbxAdresseCP.Enabled = true;
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            if(this.newClient == false)
            {
                DialogResult res = MessageBox.Show("Modification d'éléments", "Es-tu sûr d'apporter ces modications ?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (res.Equals(DialogResult.Yes))
                {
                    this.Client.Last_name = tbxNom.Text;
                    this.Client.First_name = tbxPrenom.Text;
                    this.Client.Email = tbxMail.Text;
                    this.Client.Phone = tbxTel.Text;
                    this.Client.IdRole = this.rbAdmin.Checked ? 1 : this.rbClient.Checked ? 2 : 3;
                    
                    string adresse = tbxAdresseRue.Text;
                    string CP = tbxAdresseCP.Text;
                    string ville = tbxAdresseVille.Text;

                   

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    
                }
            }
            else
            {
                DialogResult res = MessageBox.Show("Nouveau client", "Ajouter le nouveau client ?", MessageBoxButtons.OKCancel);
                if (res.Equals(DialogResult.OK))
                {
                    string nom = tbxNom.Text;
                    string prenom = tbxPrenom.Text;
                    string email = tbxMail.Text;
                    string tel = tbxTel.Text;
                    string adresse = tbxAdresseRue.Text;
                    string CP = tbxAdresseCP.Text;
                    string ville = tbxAdresseVille.Text;
                    int idRole = this.rbAdmin.Checked ? 1 : this.rbClient.Checked ? 2 : 3;

                    this.Client = new User(-1, email, prenom, nom, idRole, tel);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
              
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            FrmWaviewChat chat = new FrmWaviewChat(this.Client);
            chat.ShowDialog();
        }


        private void lstListeProjet_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.ctrl.LoadProjectPage(this.lstListeProjet.SelectedItem as Project);
        }

        private void tbx_change(object sender, EventArgs e)
        {
            this.btnSauvegarder.Enabled = this.tbxNom.Text.Trim().Length > 0 && this.tbxPrenom.Text.Trim().Length > 0 && this.tbxMail.Text.Trim().Length > 0;
        }
    }
}
