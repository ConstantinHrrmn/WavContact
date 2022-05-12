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
using WavContact.DB;
using WavContact.Metier;
using WavContact.Models;

namespace WavContact.Views.Member
{
    public partial class FrmWaviewProject : Form
    {
        private ProjectWaviewMemberController ctrl;

        public FrmWaviewProject(Project p)
        {
            InitializeComponent();
            this.ctrl = new ProjectWaviewMemberController(this, p);
        }

        private void FrmWaviewProject_Load(object sender, EventArgs e)
        {
            this.SwitchMode();
        }

        /// <summary>
        /// Passage du darkmode au lightmode et vice versa
        /// </summary>
        public void SwitchMode()
        {
            this.BackColor = Darkmode.ChangeMode(this.Controls);

            Color backcolor = Properties.Settings.Default.darkmode ? Color.Black : Color.White;
            Color invertedColor = Properties.Settings.Default.darkmode ? Color.White : Color.Black;

            tbxDescription.BackColor = backcolor;
            tbxDescription.ForeColor = invertedColor;

            lstLieux.BackColor = backcolor;
            lstLieux.ForeColor = invertedColor;

            lstDateTournages.BackColor = backcolor;
            lstDateTournages.ForeColor = invertedColor;
        }

        public void ShowData(Project p)
        {
            this.lblProjectName.Text = p.Name;
            this.tbxDescription.Text = p.Description;

            
        }

        public void UpdateDocumentList(List<WavFile> files)
        {
            this.lbDocuments.Items.Clear();

            foreach (WavFile f in files)
            {
                this.lbDocuments.Items.Add(f.Name);
            }
        }

        private void btnOpenChatWaview_Click(object sender, EventArgs e)
        {
            FrmWaviewChat frmChat = new FrmWaviewChat();
            frmChat.Show();
        }

        private void btnMateriel_Click(object sender, EventArgs e)
        {
            FrmWaviewGestionStock frmMateriel = new FrmWaviewGestionStock();
            frmMateriel.Show();
        }

        private void lbDocuments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFolderOpen_Click(object sender, EventArgs e)
        {
            if (!this.ctrl.OpenFolderInExplorer())
            {
                MessageBox.Show("Ouverture du dossier échouée, dossier inexistant, création en cours...");
            }
        }
    }
}
