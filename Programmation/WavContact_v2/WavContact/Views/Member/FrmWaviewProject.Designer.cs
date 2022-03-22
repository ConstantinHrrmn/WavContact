
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
            this.btnOpenChatWaview = new System.Windows.Forms.Button();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.btnMateriel = new System.Windows.Forms.Button();
            this.gpbProjet = new System.Windows.Forms.GroupBox();
            this.lstDateTournages = new System.Windows.Forms.ListBox();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lstLieux = new System.Windows.Forms.ListBox();
            this.lblLieu = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnAjouterDocument = new System.Windows.Forms.Button();
            this.btnSupprimerDocument = new System.Windows.Forms.Button();
            this.gpbProjet.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbActivity
            // 
            this.lbActivity.BackColor = System.Drawing.Color.Black;
            this.lbActivity.ForeColor = System.Drawing.Color.White;
            this.lbActivity.FormattingEnabled = true;
            this.lbActivity.ItemHeight = 25;
            this.lbActivity.Location = new System.Drawing.Point(544, 612);
            this.lbActivity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbActivity.Name = "lbActivity";
            this.lbActivity.Size = new System.Drawing.Size(557, 254);
            this.lbActivity.TabIndex = 14;
            // 
            // lbDocuments
            // 
            this.lbDocuments.BackColor = System.Drawing.Color.Black;
            this.lbDocuments.ForeColor = System.Drawing.Color.White;
            this.lbDocuments.FormattingEnabled = true;
            this.lbDocuments.ItemHeight = 25;
            this.lbDocuments.Location = new System.Drawing.Point(16, 612);
            this.lbDocuments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbDocuments.Name = "lbDocuments";
            this.lbDocuments.Size = new System.Drawing.Size(518, 254);
            this.lbDocuments.TabIndex = 13;
            // 
            // btnOpenChatWaview
            // 
            this.btnOpenChatWaview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenChatWaview.ForeColor = System.Drawing.Color.White;
            this.btnOpenChatWaview.Location = new System.Drawing.Point(929, 13);
            this.btnOpenChatWaview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpenChatWaview.Name = "btnOpenChatWaview";
            this.btnOpenChatWaview.Size = new System.Drawing.Size(178, 48);
            this.btnOpenChatWaview.TabIndex = 12;
            this.btnOpenChatWaview.Text = "Ouvrir chat";
            this.btnOpenChatWaview.UseVisualStyleBackColor = true;
            this.btnOpenChatWaview.Click += new System.EventHandler(this.btnOpenChatWaview_Click);
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProjectName.ForeColor = System.Drawing.Color.White;
            this.lblProjectName.Location = new System.Drawing.Point(16, 18);
            this.lblProjectName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(155, 43);
            this.lblProjectName.TabIndex = 11;
            this.lblProjectName.Text = "Projet X";
            // 
            // btnMateriel
            // 
            this.btnMateriel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMateriel.ForeColor = System.Drawing.Color.White;
            this.btnMateriel.Location = new System.Drawing.Point(743, 13);
            this.btnMateriel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMateriel.Name = "btnMateriel";
            this.btnMateriel.Size = new System.Drawing.Size(178, 48);
            this.btnMateriel.TabIndex = 15;
            this.btnMateriel.Text = "Matériel";
            this.btnMateriel.UseVisualStyleBackColor = true;
            this.btnMateriel.Click += new System.EventHandler(this.btnMateriel_Click);
            // 
            // gpbProjet
            // 
            this.gpbProjet.BackColor = System.Drawing.Color.Black;
            this.gpbProjet.Controls.Add(this.lstDateTournages);
            this.gpbProjet.Controls.Add(this.tbxDescription);
            this.gpbProjet.Controls.Add(this.lblDescription);
            this.gpbProjet.Controls.Add(this.lstLieux);
            this.gpbProjet.Controls.Add(this.lblLieu);
            this.gpbProjet.Controls.Add(this.lblDate);
            this.gpbProjet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpbProjet.ForeColor = System.Drawing.Color.White;
            this.gpbProjet.Location = new System.Drawing.Point(16, 142);
            this.gpbProjet.Name = "gpbProjet";
            this.gpbProjet.Size = new System.Drawing.Size(713, 462);
            this.gpbProjet.TabIndex = 19;
            this.gpbProjet.TabStop = false;
            this.gpbProjet.Text = "Informations";
            // 
            // lstDateTournages
            // 
            this.lstDateTournages.BackColor = System.Drawing.Color.Black;
            this.lstDateTournages.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstDateTournages.ForeColor = System.Drawing.Color.White;
            this.lstDateTournages.FormattingEnabled = true;
            this.lstDateTournages.ItemHeight = 25;
            this.lstDateTournages.Location = new System.Drawing.Point(120, 302);
            this.lstDateTournages.Name = "lstDateTournages";
            this.lstDateTournages.Size = new System.Drawing.Size(513, 104);
            this.lstDateTournages.TabIndex = 40;
            // 
            // tbxDescription
            // 
            this.tbxDescription.BackColor = System.Drawing.Color.Black;
            this.tbxDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxDescription.ForeColor = System.Drawing.Color.White;
            this.tbxDescription.Location = new System.Drawing.Point(120, 38);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.ReadOnly = true;
            this.tbxDescription.Size = new System.Drawing.Size(513, 77);
            this.tbxDescription.TabIndex = 13;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.Location = new System.Drawing.Point(10, 62);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(102, 25);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Description";
            // 
            // lstLieux
            // 
            this.lstLieux.BackColor = System.Drawing.Color.Black;
            this.lstLieux.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstLieux.ForeColor = System.Drawing.Color.White;
            this.lstLieux.FormattingEnabled = true;
            this.lstLieux.ItemHeight = 25;
            this.lstLieux.Location = new System.Drawing.Point(121, 162);
            this.lstLieux.Name = "lstLieux";
            this.lstLieux.Size = new System.Drawing.Size(511, 104);
            this.lstLieux.TabIndex = 8;
            // 
            // lblLieu
            // 
            this.lblLieu.AutoSize = true;
            this.lblLieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLieu.Location = new System.Drawing.Point(14, 160);
            this.lblLieu.Name = "lblLieu";
            this.lblLieu.Size = new System.Drawing.Size(55, 25);
            this.lblLieu.TabIndex = 4;
            this.lblLieu.Text = "Lieu.x";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(14, 300);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(49, 25);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // btnAjouterDocument
            // 
            this.btnAjouterDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterDocument.ForeColor = System.Drawing.Color.White;
            this.btnAjouterDocument.Location = new System.Drawing.Point(356, 878);
            this.btnAjouterDocument.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAjouterDocument.Name = "btnAjouterDocument";
            this.btnAjouterDocument.Size = new System.Drawing.Size(178, 50);
            this.btnAjouterDocument.TabIndex = 20;
            this.btnAjouterDocument.Text = "Ajouter";
            this.btnAjouterDocument.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerDocument
            // 
            this.btnSupprimerDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerDocument.ForeColor = System.Drawing.Color.White;
            this.btnSupprimerDocument.Location = new System.Drawing.Point(170, 878);
            this.btnSupprimerDocument.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSupprimerDocument.Name = "btnSupprimerDocument";
            this.btnSupprimerDocument.Size = new System.Drawing.Size(178, 50);
            this.btnSupprimerDocument.TabIndex = 21;
            this.btnSupprimerDocument.Text = "Supprimer";
            this.btnSupprimerDocument.UseVisualStyleBackColor = true;
            // 
            // FrmWaviewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1120, 935);
            this.Controls.Add(this.btnSupprimerDocument);
            this.Controls.Add(this.btnAjouterDocument);
            this.Controls.Add(this.gpbProjet);
            this.Controls.Add(this.btnMateriel);
            this.Controls.Add(this.lbActivity);
            this.Controls.Add(this.lbDocuments);
            this.Controls.Add(this.btnOpenChatWaview);
            this.Controls.Add(this.lblProjectName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button btnOpenChatWaview;
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
    }
}