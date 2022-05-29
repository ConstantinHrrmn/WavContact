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
using WavContact.Views.Client;

using Activity = WavContact.DB.Activity;

namespace WavContact.Views.Member
{
    public partial class FrmWaviewProject : Form
    {
        private ProjectWaviewMemberController ctrl;

        private bool isAdmin = false;

        private User loggedUser;

        public User LoggedUser { get => loggedUser; set => loggedUser = value; }

        Tournage selectedTournage = null;
        WavFile selectedFile = null;
        
        public FrmWaviewProject(Project p, User u )
        {
            InitializeComponent();
            this.ctrl = new ProjectWaviewMemberController(this, p);

            this.LoggedUser = u;

            if (u.IdRole == 1)
            {
                isAdmin = true;
            }

            this.btnMateriel.Visible = this.isAdmin;
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
            this.tbxCommentaires.Text = p.Commentaire;
        }

        public void UpdateDocumentList(List<WavFile> files)
        {
            try
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
            catch (Exception)
            {
            }
            
        }

        public void UpdateLieuxList(List<Lieu> lieux)
        {
            try
            {
                this.lstLieux.Invoke(() => this.lstLieux.Items.Clear());
                if (lieux != null)
                {
                    foreach (Lieu l in lieux)
                    {
                        this.lstLieux.Invoke(() => this.lstLieux.Items.Add(l));
                    }
                }
            }
            catch (Exception)
            {
            }
        }
        public void UpdateActivityList(List<Activity> activites)
        {
            try
            {
                this.lbActivity.Invoke(() => this.lbActivity.Items.Clear());
                if (activites != null)
                {
                    foreach (Activity a in activites)
                    {
                        this.lbActivity.Invoke(() => this.lbActivity.Items.Add(a));
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnOpenChatWaview_Click(object sender, EventArgs e)
        {
            if (this.isAdmin)
            {
                FrmWaviewChat frmChat = new FrmWaviewChat(this.loggedUser);
                frmChat.Show();
            }
            else
            {
                FrmClientChat frm = new FrmClientChat(this.loggedUser);
                frm.Show();
            }
            
        }

        private void btnMateriel_Click(object sender, EventArgs e)
        {
            //FrmWaviewGestionStock frmMateriel = new FrmWaviewGestionStock();
            //frmMateriel.Show();

            FrmMaterielTournage frmMaterielTournage = new FrmMaterielTournage(this.ctrl.GetProject());
            frmMaterielTournage.Show();
        }

        private void lbDocuments_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            WavFile file = this.ctrl.SelectedFile(this.lbDocuments.SelectedIndex);

            if (MessageBox.Show("Voulez-vous télécharger le fichier ?", "Téléchargement", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.ctrl.DownloadFile(file);

                this.ctrl.OpenFolderInExplorer();

            }
            /*
            if (this.selectedFile == null || this.selectedFile != file)
            {
                this.selectedFile = file;
            }
            else
            {
                this.selectedFile = null;
                
                
            }*/
            
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

        private void btnSupprimerDocument_Click(object sender, EventArgs e)
        {
            if(this.lbDocuments.SelectedIndex != -1)
            {
                WavFile file = this.ctrl.SelectedFile(this.lbDocuments.SelectedIndex);
                this.ctrl.DeleteFile(file);
            }
        }

        private void tbxDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!this.btnSaveDescription.Visible)
            {
                this.btnSaveDescription.Visible = true;
            }
        }

        private void tbxCommentaires_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!this.btnSaveCommentary.Visible)
            {
                this.btnSaveCommentary.Visible = true;
            }
        }

        private void btnSaveDescription_Click(object sender, EventArgs e)
        {
            this.ctrl.UpdateProjectDescription(this.tbxDescription.Text);
            this.btnSaveDescription.Visible = false;
            
        }

        private void btnSaveCommentary_Click(object sender, EventArgs e)
        {
            this.ctrl.UpdateProjectCommentary(this.tbxCommentaires.Text);
            this.btnSaveCommentary.Visible = false;
        }

        public void UpdateDateList(List<Tournage> tournages)
        {
            try
            {
                this.lstDateTournages.Invoke(() => this.lstDateTournages.Items.Clear());
                if (tournages != null)
                {
                    foreach (Tournage a in tournages)
                    {
                        this.lstDateTournages.Invoke(() => this.lstDateTournages.Items.Add(a));
                    }
                }
            }
            catch (Exception)
            {
            }
           
            
        }

        private void btnAddDate_Click(object sender, EventArgs e)
        {
            this.ctrl.AddDate();
        }

        private void btnRemoveDate_Click(object sender, EventArgs e)
        {
            if (this.lstDateTournages.SelectedIndex != -1)
            {
                Tournage tournage = this.lstDateTournages.SelectedItem as Tournage;
                this.ctrl.DeleteDate(tournage);
            }
        }

        private void lstDateTournages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDateTournages.SelectedIndex != -1 && lstDateTournages.SelectedIndex >= 0)
            {
                this.btnRemoveDate.Visible = true;
                Tournage selectedDate = this.lstDateTournages.SelectedItem as Tournage;

                if (this.selectedTournage == null || this.selectedTournage != selectedDate)
                {
                    this.selectedTournage = selectedDate;
                }
                else
                {
                    this.ctrl.UpdateDate(selectedDate);
                }

                
            }
        }

        private void lstLieux_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lieu l = this.lstLieux.SelectedItem as Lieu;
            Debug.WriteLine(l.ToMaps());
            Clipboard.SetText(l.ToMaps());
            PlaceBox pb = new PlaceBox(l);

            if (pb.ShowDialog() == DialogResult.Yes)
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer le lieu du projet ?", "Supprimer ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.ctrl.DeletePlace(pb.SelectedLieu);
                }
            }
            
            //MessageBox.Show("URL copié ! \n \n" + l.ToMaps(), "URL GoogleMaps du lieu");
        }
    }
}
