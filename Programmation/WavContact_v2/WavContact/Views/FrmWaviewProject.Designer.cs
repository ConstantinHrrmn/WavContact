
namespace WavContact.Views.Member
{
    partial class FrmWaviewProject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbActivity = new System.Windows.Forms.ListBox();
            this.lbDocuments = new System.Windows.Forms.ListBox();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.btnMateriel = new System.Windows.Forms.Button();
            this.gpbProjet = new System.Windows.Forms.GroupBox();
            this.btnRemoveDate = new System.Windows.Forms.Button();
            this.btnAddDate = new System.Windows.Forms.Button();
            this.lstDateTournages = new System.Windows.Forms.ListBox();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lstLieux = new System.Windows.Forms.ListBox();
            this.lblLieu = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnAjouterDocument = new System.Windows.Forms.Button();
            this.btnSupprimerDocument = new System.Windows.Forms.Button();
            this.btnFolderOpen = new System.Windows.Forms.Button();
            this.odf = new System.Windows.Forms.OpenFileDialog();
            this.tbxCommentaires = new System.Windows.Forms.TextBox();
            this.btnSaveCommentary = new System.Windows.Forms.Button();
            this.btnSaveDescription = new System.Windows.Forms.Button();
            this.lblCommentaires = new System.Windows.Forms.Label();
            this.gpbProjet.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbActivity
            // 
            this.lbActivity.BackColor = System.Drawing.Color.Black;
            this.lbActivity.ForeColor = System.Drawing.Color.White;
            this.lbActivity.FormattingEnabled = true;
            this.lbActivity.ItemHeight = 30;
            this.lbActivity.Location = new System.Drawing.Point(653, 734);
            this.lbActivity.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lbActivity.Name = "lbActivity";
            this.lbActivity.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbActivity.Size = new System.Drawing.Size(825, 304);
            this.lbActivity.TabIndex = 14;
            // 
            // lbDocuments
            // 
            this.lbDocuments.BackColor = System.Drawing.Color.Black;
            this.lbDocuments.ForeColor = System.Drawing.Color.White;
            this.lbDocuments.FormattingEnabled = true;
            this.lbDocuments.ItemHeight = 30;
            this.lbDocuments.Location = new System.Drawing.Point(19, 734);
            this.lbDocuments.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lbDocuments.Name = "lbDocuments";
            this.lbDocuments.Size = new System.Drawing.Size(621, 304);
            this.lbDocuments.TabIndex = 13;
            this.lbDocuments.SelectedIndexChanged += new System.EventHandler(this.lbDocuments_SelectedIndexChanged);
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProjectName.ForeColor = System.Drawing.Color.White;
            this.lblProjectName.Location = new System.Drawing.Point(19, 22);
            this.lblProjectName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(181, 49);
            this.lblProjectName.TabIndex = 11;
            this.lblProjectName.Text = "Projet X";
            // 
            // btnMateriel
            // 
            this.btnMateriel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMateriel.ForeColor = System.Drawing.Color.White;
            this.btnMateriel.Location = new System.Drawing.Point(1264, 15);
            this.btnMateriel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnMateriel.Name = "btnMateriel";
            this.btnMateriel.Size = new System.Drawing.Size(214, 58);
            this.btnMateriel.TabIndex = 15;
            this.btnMateriel.Text = "Matériel";
            this.btnMateriel.UseVisualStyleBackColor = true;
            this.btnMateriel.Click += new System.EventHandler(this.btnMateriel_Click);
            // 
            // gpbProjet
            // 
            this.gpbProjet.BackColor = System.Drawing.Color.Black;
            this.gpbProjet.Controls.Add(this.btnRemoveDate);
            this.gpbProjet.Controls.Add(this.btnAddDate);
            this.gpbProjet.Controls.Add(this.lstDateTournages);
            this.gpbProjet.Controls.Add(this.tbxDescription);
            this.gpbProjet.Controls.Add(this.lblDescription);
            this.gpbProjet.Controls.Add(this.lstLieux);
            this.gpbProjet.Controls.Add(this.lblLieu);
            this.gpbProjet.Controls.Add(this.lblDate);
            this.gpbProjet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpbProjet.ForeColor = System.Drawing.Color.White;
            this.gpbProjet.Location = new System.Drawing.Point(19, 170);
            this.gpbProjet.Margin = new System.Windows.Forms.Padding(4);
            this.gpbProjet.Name = "gpbProjet";
            this.gpbProjet.Padding = new System.Windows.Forms.Padding(4);
            this.gpbProjet.Size = new System.Drawing.Size(856, 554);
            this.gpbProjet.TabIndex = 19;
            this.gpbProjet.TabStop = false;
            this.gpbProjet.Text = "Informations";
            // 
            // btnRemoveDate
            // 
            this.btnRemoveDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveDate.Font = new System.Drawing.Font("Segoe UI", 5.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveDate.ForeColor = System.Drawing.Color.White;
            this.btnRemoveDate.Location = new System.Drawing.Point(768, 431);
            this.btnRemoveDate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnRemoveDate.Name = "btnRemoveDate";
            this.btnRemoveDate.Size = new System.Drawing.Size(79, 55);
            this.btnRemoveDate.TabIndex = 46;
            this.btnRemoveDate.Text = "Supp.";
            this.btnRemoveDate.UseVisualStyleBackColor = true;
            this.btnRemoveDate.Visible = false;
            this.btnRemoveDate.Click += new System.EventHandler(this.btnRemoveDate_Click);
            // 
            // btnAddDate
            // 
            this.btnAddDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDate.Font = new System.Drawing.Font("Segoe UI", 5.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddDate.ForeColor = System.Drawing.Color.White;
            this.btnAddDate.Location = new System.Drawing.Point(768, 362);
            this.btnAddDate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAddDate.Name = "btnAddDate";
            this.btnAddDate.Size = new System.Drawing.Size(79, 55);
            this.btnAddDate.TabIndex = 45;
            this.btnAddDate.Text = "Ajouter";
            this.btnAddDate.UseVisualStyleBackColor = true;
            this.btnAddDate.Click += new System.EventHandler(this.btnAddDate_Click);
            // 
            // lstDateTournages
            // 
            this.lstDateTournages.BackColor = System.Drawing.Color.Black;
            this.lstDateTournages.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstDateTournages.ForeColor = System.Drawing.Color.White;
            this.lstDateTournages.FormattingEnabled = true;
            this.lstDateTournages.ItemHeight = 30;
            this.lstDateTournages.Location = new System.Drawing.Point(144, 362);
            this.lstDateTournages.Margin = new System.Windows.Forms.Padding(4);
            this.lstDateTournages.Name = "lstDateTournages";
            this.lstDateTournages.Size = new System.Drawing.Size(615, 124);
            this.lstDateTournages.TabIndex = 40;
            this.lstDateTournages.SelectedIndexChanged += new System.EventHandler(this.lstDateTournages_SelectedIndexChanged);
            // 
            // tbxDescription
            // 
            this.tbxDescription.BackColor = System.Drawing.Color.Black;
            this.tbxDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxDescription.ForeColor = System.Drawing.Color.White;
            this.tbxDescription.Location = new System.Drawing.Point(144, 46);
            this.tbxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(615, 92);
            this.tbxDescription.TabIndex = 13;
            this.tbxDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxDescription_KeyPress);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.Location = new System.Drawing.Point(12, 74);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(118, 30);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Description";
            // 
            // lstLieux
            // 
            this.lstLieux.BackColor = System.Drawing.Color.Black;
            this.lstLieux.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstLieux.ForeColor = System.Drawing.Color.White;
            this.lstLieux.FormattingEnabled = true;
            this.lstLieux.ItemHeight = 30;
            this.lstLieux.Location = new System.Drawing.Point(145, 194);
            this.lstLieux.Margin = new System.Windows.Forms.Padding(4);
            this.lstLieux.Name = "lstLieux";
            this.lstLieux.Size = new System.Drawing.Size(612, 124);
            this.lstLieux.TabIndex = 8;
            this.lstLieux.SelectedIndexChanged += new System.EventHandler(this.lstLieux_SelectedIndexChanged);
            // 
            // lblLieu
            // 
            this.lblLieu.AutoSize = true;
            this.lblLieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLieu.Location = new System.Drawing.Point(17, 192);
            this.lblLieu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLieu.Name = "lblLieu";
            this.lblLieu.Size = new System.Drawing.Size(66, 30);
            this.lblLieu.TabIndex = 4;
            this.lblLieu.Text = "Lieu.x";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(17, 360);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(71, 30);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date.s";
            // 
            // btnAjouterDocument
            // 
            this.btnAjouterDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterDocument.ForeColor = System.Drawing.Color.White;
            this.btnAjouterDocument.Location = new System.Drawing.Point(427, 1054);
            this.btnAjouterDocument.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAjouterDocument.Name = "btnAjouterDocument";
            this.btnAjouterDocument.Size = new System.Drawing.Size(214, 60);
            this.btnAjouterDocument.TabIndex = 20;
            this.btnAjouterDocument.Text = "Ajouter";
            this.btnAjouterDocument.UseVisualStyleBackColor = true;
            this.btnAjouterDocument.Click += new System.EventHandler(this.btnAjouterDocument_Click);
            // 
            // btnSupprimerDocument
            // 
            this.btnSupprimerDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerDocument.ForeColor = System.Drawing.Color.White;
            this.btnSupprimerDocument.Location = new System.Drawing.Point(204, 1054);
            this.btnSupprimerDocument.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSupprimerDocument.Name = "btnSupprimerDocument";
            this.btnSupprimerDocument.Size = new System.Drawing.Size(214, 60);
            this.btnSupprimerDocument.TabIndex = 21;
            this.btnSupprimerDocument.Text = "Supprimer";
            this.btnSupprimerDocument.UseVisualStyleBackColor = true;
            this.btnSupprimerDocument.Click += new System.EventHandler(this.btnSupprimerDocument_Click);
            // 
            // btnFolderOpen
            // 
            this.btnFolderOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFolderOpen.ForeColor = System.Drawing.Color.White;
            this.btnFolderOpen.Location = new System.Drawing.Point(19, 1054);
            this.btnFolderOpen.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnFolderOpen.Name = "btnFolderOpen";
            this.btnFolderOpen.Size = new System.Drawing.Size(175, 60);
            this.btnFolderOpen.TabIndex = 22;
            this.btnFolderOpen.Text = "Dossier";
            this.btnFolderOpen.UseVisualStyleBackColor = true;
            this.btnFolderOpen.Click += new System.EventHandler(this.btnFolderOpen_Click);
            // 
            // tbxCommentaires
            // 
            this.tbxCommentaires.BackColor = System.Drawing.Color.Black;
            this.tbxCommentaires.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxCommentaires.ForeColor = System.Drawing.Color.White;
            this.tbxCommentaires.Location = new System.Drawing.Point(883, 189);
            this.tbxCommentaires.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCommentaires.Multiline = true;
            this.tbxCommentaires.Name = "tbxCommentaires";
            this.tbxCommentaires.Size = new System.Drawing.Size(595, 535);
            this.tbxCommentaires.TabIndex = 41;
            this.tbxCommentaires.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCommentaires_KeyPress);
            // 
            // btnSaveCommentary
            // 
            this.btnSaveCommentary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCommentary.ForeColor = System.Drawing.Color.White;
            this.btnSaveCommentary.Location = new System.Drawing.Point(1264, 118);
            this.btnSaveCommentary.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSaveCommentary.Name = "btnSaveCommentary";
            this.btnSaveCommentary.Size = new System.Drawing.Size(214, 58);
            this.btnSaveCommentary.TabIndex = 42;
            this.btnSaveCommentary.Text = "Enregistrer";
            this.btnSaveCommentary.UseVisualStyleBackColor = true;
            this.btnSaveCommentary.Visible = false;
            this.btnSaveCommentary.Click += new System.EventHandler(this.btnSaveCommentary_Click);
            // 
            // btnSaveDescription
            // 
            this.btnSaveDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDescription.ForeColor = System.Drawing.Color.White;
            this.btnSaveDescription.Location = new System.Drawing.Point(787, 216);
            this.btnSaveDescription.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSaveDescription.Name = "btnSaveDescription";
            this.btnSaveDescription.Size = new System.Drawing.Size(79, 92);
            this.btnSaveDescription.TabIndex = 43;
            this.btnSaveDescription.Text = "OK";
            this.btnSaveDescription.UseVisualStyleBackColor = true;
            this.btnSaveDescription.Visible = false;
            this.btnSaveDescription.Click += new System.EventHandler(this.btnSaveDescription_Click);
            // 
            // lblCommentaires
            // 
            this.lblCommentaires.AutoSize = true;
            this.lblCommentaires.Location = new System.Drawing.Point(883, 149);
            this.lblCommentaires.Name = "lblCommentaires";
            this.lblCommentaires.Size = new System.Drawing.Size(147, 30);
            this.lblCommentaires.TabIndex = 44;
            this.lblCommentaires.Text = "Commentaires";
            // 
            // FrmWaviewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1492, 1122);
            this.Controls.Add(this.lblCommentaires);
            this.Controls.Add(this.btnSaveDescription);
            this.Controls.Add(this.btnSaveCommentary);
            this.Controls.Add(this.tbxCommentaires);
            this.Controls.Add(this.btnFolderOpen);
            this.Controls.Add(this.btnSupprimerDocument);
            this.Controls.Add(this.btnAjouterDocument);
            this.Controls.Add(this.gpbProjet);
            this.Controls.Add(this.btnMateriel);
            this.Controls.Add(this.lbActivity);
            this.Controls.Add(this.lbDocuments);
            this.Controls.Add(this.lblProjectName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "FrmWaviewProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Projet";
            this.Load += new System.EventHandler(this.FrmWaviewProject_Load);
            this.gpbProjet.ResumeLayout(false);
            this.gpbProjet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbActivity;
        private System.Windows.Forms.ListBox lbDocuments;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Button btnMateriel;
        private System.Windows.Forms.GroupBox gpbProjet;
        private System.Windows.Forms.ListBox lstDateTournages;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ListBox lstLieux;
        private System.Windows.Forms.Label lblLieu;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnAjouterDocument;
        private System.Windows.Forms.Button btnSupprimerDocument;
        private System.Windows.Forms.Button btnFolderOpen;
        private System.Windows.Forms.OpenFileDialog odf;
        private System.Windows.Forms.TextBox tbxCommentaires;
        private System.Windows.Forms.Button btnSaveCommentary;
        private System.Windows.Forms.Button btnSaveDescription;
        private System.Windows.Forms.Label lblCommentaires;
        private System.Windows.Forms.Button btnRemoveDate;
        private System.Windows.Forms.Button btnAddDate;
    }
}