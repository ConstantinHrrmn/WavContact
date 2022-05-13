using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
            this.btnSupprimerDocument.Enabled = false;
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
            this.lbDocuments.Invoke(() => this.lbDocuments.Items.Clear());
            if (files != null)
            {
                foreach (WavFile f in files)
                {
                    this.lbDocuments.Invoke(() => this.lbDocuments.Items.Add(f.Name));
                }

                this.btnSupprimerDocument.Invoke(() => this.btnSupprimerDocument.Enabled = true);
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
            WavFile file = this.ctrl.SelectedFile(this.lbDocuments.SelectedIndex);
            this.ctrl.DownloadFile(file);

            this.ctrl.OpenFolderInExplorer();
        }

        private void btnFolderOpen_Click(object sender, EventArgs e)
        {
            if (!this.ctrl.OpenFolderInExplorer())
            {
                MessageBox.Show("Ouverture du dossier échouée, dossier inexistant, création en cours...");
            }
        }

        private void btnAjouterDocument_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.odf.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string sourcePath = this.odf.FileName;

                this.ctrl.UploadFile(sourcePath);
            }
        }
    }
}
