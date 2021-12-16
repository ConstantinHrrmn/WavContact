﻿
namespace WavContact.Views.Member
{
    partial class FrmWaviewGestionReservation
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblGestionProjet = new System.Windows.Forms.Label();
            this.lblListeProjets = new System.Windows.Forms.Label();
            this.lblListeMateriel = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblLieu = new System.Windows.Forms.Label();
            this.lblHeure = new System.Windows.Forms.Label();
            this.lblParticipant = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtHeure = new System.Windows.Forms.TextBox();
            this.lstLieux = new System.Windows.Forms.ListBox();
            this.gpbProjet = new System.Windows.Forms.GroupBox();
            this.lblDocuments = new System.Windows.Forms.Label();
            this.lstDocuments = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lstListeParticipants = new System.Windows.Forms.ListBox();
            this.lstMateriaux = new System.Windows.Forms.ListBox();
            this.cboListeProjet = new System.Windows.Forms.ComboBox();
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.lstActivites = new System.Windows.Forms.ListBox();
            this.lblListeActivite = new System.Windows.Forms.Label();
            this.gpbProjet.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(645, 14);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 48);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblGestionProjet
            // 
            this.lblGestionProjet.AutoSize = true;
            this.lblGestionProjet.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGestionProjet.Location = new System.Drawing.Point(12, 14);
            this.lblGestionProjet.Name = "lblGestionProjet";
            this.lblGestionProjet.Size = new System.Drawing.Size(297, 48);
            this.lblGestionProjet.TabIndex = 6;
            this.lblGestionProjet.Text = "Gestion du projet";
            // 
            // lblListeProjets
            // 
            this.lblListeProjets.AutoSize = true;
            this.lblListeProjets.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblListeProjets.Location = new System.Drawing.Point(13, 117);
            this.lblListeProjets.Name = "lblListeProjets";
            this.lblListeProjets.Size = new System.Drawing.Size(86, 32);
            this.lblListeProjets.TabIndex = 7;
            this.lblListeProjets.Text = "Projets";
            // 
            // lblListeMateriel
            // 
            this.lblListeMateriel.AutoSize = true;
            this.lblListeMateriel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblListeMateriel.Location = new System.Drawing.Point(13, 552);
            this.lblListeMateriel.Name = "lblListeMateriel";
            this.lblListeMateriel.Size = new System.Drawing.Size(191, 32);
            this.lblListeMateriel.TabIndex = 1;
            this.lblListeMateriel.Text = "Liste du matériel";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(12, 279);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(49, 25);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // lblLieu
            // 
            this.lblLieu.AutoSize = true;
            this.lblLieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLieu.Location = new System.Drawing.Point(12, 142);
            this.lblLieu.Name = "lblLieu";
            this.lblLieu.Size = new System.Drawing.Size(55, 25);
            this.lblLieu.TabIndex = 4;
            this.lblLieu.Text = "Lieu.x";
            // 
            // lblHeure
            // 
            this.lblHeure.AutoSize = true;
            this.lblHeure.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeure.Location = new System.Drawing.Point(356, 279);
            this.lblHeure.Name = "lblHeure";
            this.lblHeure.Size = new System.Drawing.Size(59, 25);
            this.lblHeure.TabIndex = 3;
            this.lblHeure.Text = "Heure";
            // 
            // lblParticipant
            // 
            this.lblParticipant.AutoSize = true;
            this.lblParticipant.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblParticipant.Location = new System.Drawing.Point(356, 142);
            this.lblParticipant.Name = "lblParticipant";
            this.lblParticipant.Size = new System.Drawing.Size(102, 25);
            this.lblParticipant.TabIndex = 5;
            this.lblParticipant.Text = "Participants";
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.Black;
            this.txtDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDate.ForeColor = System.Drawing.Color.White;
            this.txtDate.Location = new System.Drawing.Point(120, 276);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(198, 31);
            this.txtDate.TabIndex = 6;
            // 
            // txtHeure
            // 
            this.txtHeure.BackColor = System.Drawing.Color.Black;
            this.txtHeure.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHeure.ForeColor = System.Drawing.Color.White;
            this.txtHeure.Location = new System.Drawing.Point(464, 276);
            this.txtHeure.Name = "txtHeure";
            this.txtHeure.ReadOnly = true;
            this.txtHeure.Size = new System.Drawing.Size(198, 31);
            this.txtHeure.TabIndex = 7;
            // 
            // lstLieux
            // 
            this.lstLieux.BackColor = System.Drawing.Color.Black;
            this.lstLieux.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstLieux.ForeColor = System.Drawing.Color.White;
            this.lstLieux.FormattingEnabled = true;
            this.lstLieux.ItemHeight = 25;
            this.lstLieux.Location = new System.Drawing.Point(120, 142);
            this.lstLieux.Name = "lstLieux";
            this.lstLieux.Size = new System.Drawing.Size(198, 104);
            this.lstLieux.TabIndex = 8;
            // 
            // gpbProjet
            // 
            this.gpbProjet.BackColor = System.Drawing.Color.Black;
            this.gpbProjet.Controls.Add(this.textBox1);
            this.gpbProjet.Controls.Add(this.lblDescription);
            this.gpbProjet.Controls.Add(this.lstListeParticipants);
            this.gpbProjet.Controls.Add(this.lstLieux);
            this.gpbProjet.Controls.Add(this.txtHeure);
            this.gpbProjet.Controls.Add(this.txtDate);
            this.gpbProjet.Controls.Add(this.lblParticipant);
            this.gpbProjet.Controls.Add(this.lblHeure);
            this.gpbProjet.Controls.Add(this.lblLieu);
            this.gpbProjet.Controls.Add(this.lblDate);
            this.gpbProjet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpbProjet.ForeColor = System.Drawing.Color.White;
            this.gpbProjet.Location = new System.Drawing.Point(13, 189);
            this.gpbProjet.Name = "gpbProjet";
            this.gpbProjet.Size = new System.Drawing.Size(683, 328);
            this.gpbProjet.TabIndex = 13;
            this.gpbProjet.TabStop = false;
            this.gpbProjet.Text = "Information du projet";
            // 
            // lblDocuments
            // 
            this.lblDocuments.AutoSize = true;
            this.lblDocuments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDocuments.Location = new System.Drawing.Point(338, 552);
            this.lblDocuments.Name = "lblDocuments";
            this.lblDocuments.Size = new System.Drawing.Size(232, 32);
            this.lblDocuments.TabIndex = 16;
            this.lblDocuments.Text = "Liste des documents";
            // 
            // lstDocuments
            // 
            this.lstDocuments.BackColor = System.Drawing.Color.Black;
            this.lstDocuments.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstDocuments.ForeColor = System.Drawing.Color.White;
            this.lstDocuments.FormattingEnabled = true;
            this.lstDocuments.ItemHeight = 25;
            this.lstDocuments.Location = new System.Drawing.Point(338, 587);
            this.lstDocuments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstDocuments.Name = "lstDocuments";
            this.lstDocuments.Size = new System.Drawing.Size(358, 204);
            this.lstDocuments.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(120, 38);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(542, 78);
            this.textBox1.TabIndex = 13;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.Location = new System.Drawing.Point(12, 64);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(102, 25);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Description";
            // 
            // lstListeParticipants
            // 
            this.lstListeParticipants.BackColor = System.Drawing.Color.Black;
            this.lstListeParticipants.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstListeParticipants.ForeColor = System.Drawing.Color.White;
            this.lstListeParticipants.FormattingEnabled = true;
            this.lstListeParticipants.ItemHeight = 25;
            this.lstListeParticipants.Location = new System.Drawing.Point(464, 142);
            this.lstListeParticipants.Name = "lstListeParticipants";
            this.lstListeParticipants.Size = new System.Drawing.Size(198, 104);
            this.lstListeParticipants.TabIndex = 11;
            // 
            // lstMateriaux
            // 
            this.lstMateriaux.BackColor = System.Drawing.Color.Black;
            this.lstMateriaux.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstMateriaux.ForeColor = System.Drawing.Color.White;
            this.lstMateriaux.FormattingEnabled = true;
            this.lstMateriaux.ItemHeight = 25;
            this.lstMateriaux.Location = new System.Drawing.Point(13, 587);
            this.lstMateriaux.Name = "lstMateriaux";
            this.lstMateriaux.Size = new System.Drawing.Size(318, 204);
            this.lstMateriaux.TabIndex = 10;
            // 
            // cboListeProjet
            // 
            this.cboListeProjet.BackColor = System.Drawing.Color.Black;
            this.cboListeProjet.ForeColor = System.Drawing.Color.White;
            this.cboListeProjet.FormattingEnabled = true;
            this.cboListeProjet.Location = new System.Drawing.Point(106, 120);
            this.cboListeProjet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboListeProjet.Name = "cboListeProjet";
            this.cboListeProjet.Size = new System.Drawing.Size(290, 33);
            this.cboListeProjet.TabIndex = 16;
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.BackColor = System.Drawing.Color.Black;
            this.btnSelectionner.ForeColor = System.Drawing.Color.White;
            this.btnSelectionner.Location = new System.Drawing.Point(404, 120);
            this.btnSelectionner.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(117, 33);
            this.btnSelectionner.TabIndex = 15;
            this.btnSelectionner.Text = "Sélectionner";
            this.btnSelectionner.UseVisualStyleBackColor = false;
            // 
            // lstActivites
            // 
            this.lstActivites.BackColor = System.Drawing.Color.Black;
            this.lstActivites.ForeColor = System.Drawing.Color.White;
            this.lstActivites.FormattingEnabled = true;
            this.lstActivites.ItemHeight = 25;
            this.lstActivites.Location = new System.Drawing.Point(12, 861);
            this.lstActivites.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstActivites.Name = "lstActivites";
            this.lstActivites.Size = new System.Drawing.Size(683, 154);
            this.lstActivites.TabIndex = 17;
            // 
            // lblListeActivite
            // 
            this.lblListeActivite.AutoSize = true;
            this.lblListeActivite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblListeActivite.Location = new System.Drawing.Point(12, 824);
            this.lblListeActivite.Name = "lblListeActivite";
            this.lblListeActivite.Size = new System.Drawing.Size(199, 32);
            this.lblListeActivite.TabIndex = 18;
            this.lblListeActivite.Text = "Liste des activités";
            // 
            // FrmWaviewGestionReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(708, 1029);
            this.Controls.Add(this.lblListeActivite);
            this.Controls.Add(this.lstActivites);
            this.Controls.Add(this.lblDocuments);
            this.Controls.Add(this.cboListeProjet);
            this.Controls.Add(this.lstDocuments);
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.gpbProjet);
            this.Controls.Add(this.lstMateriaux);
            this.Controls.Add(this.lblListeProjets);
            this.Controls.Add(this.lblGestionProjet);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblListeMateriel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmWaviewGestionReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmWaviewGestionReservation";
            this.gpbProjet.ResumeLayout(false);
            this.gpbProjet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblGestionProjet;
        private System.Windows.Forms.Label lblListeProjets;
        private System.Windows.Forms.Label lblListeMateriel;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblLieu;
        private System.Windows.Forms.Label lblHeure;
        private System.Windows.Forms.Label lblParticipant;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtHeure;
        private System.Windows.Forms.ListBox lstLieux;
        private System.Windows.Forms.GroupBox gpbProjet;
        private System.Windows.Forms.ListBox lstMateriaux;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ListBox lstListeParticipants;
        private System.Windows.Forms.Label lblDocuments;
        private System.Windows.Forms.ListBox lstDocuments;
        private System.Windows.Forms.ComboBox cboListeProjet;
        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.ListBox lstActivites;
        private System.Windows.Forms.Label lblListeActivite;
    }
}