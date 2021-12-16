
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lstListeParticipants = new System.Windows.Forms.ListBox();
            this.lstMateriel = new System.Windows.Forms.ListBox();
            this.lstListeProjets = new System.Windows.Forms.ListBox();
            this.gpbProjet.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(926, 14);
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
            this.lblListeProjets.Location = new System.Drawing.Point(13, 79);
            this.lblListeProjets.Name = "lblListeProjets";
            this.lblListeProjets.Size = new System.Drawing.Size(86, 32);
            this.lblListeProjets.TabIndex = 7;
            this.lblListeProjets.Text = "Projets";
            // 
            // lblListeMateriel
            // 
            this.lblListeMateriel.AutoSize = true;
            this.lblListeMateriel.Location = new System.Drawing.Point(12, 334);
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
            this.lblHeure.Location = new System.Drawing.Point(330, 279);
            this.lblHeure.Name = "lblHeure";
            this.lblHeure.Size = new System.Drawing.Size(59, 25);
            this.lblHeure.TabIndex = 3;
            this.lblHeure.Text = "Heure";
            // 
            // lblParticipant
            // 
            this.lblParticipant.AutoSize = true;
            this.lblParticipant.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblParticipant.Location = new System.Drawing.Point(330, 142);
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
            this.txtHeure.Location = new System.Drawing.Point(434, 276);
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
            this.gpbProjet.Controls.Add(this.lstMateriel);
            this.gpbProjet.Controls.Add(this.lstLieux);
            this.gpbProjet.Controls.Add(this.txtHeure);
            this.gpbProjet.Controls.Add(this.txtDate);
            this.gpbProjet.Controls.Add(this.lblParticipant);
            this.gpbProjet.Controls.Add(this.lblHeure);
            this.gpbProjet.Controls.Add(this.lblLieu);
            this.gpbProjet.Controls.Add(this.lblDate);
            this.gpbProjet.Controls.Add(this.lblListeMateriel);
            this.gpbProjet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpbProjet.ForeColor = System.Drawing.Color.White;
            this.gpbProjet.Location = new System.Drawing.Point(331, 105);
            this.gpbProjet.Name = "gpbProjet";
            this.gpbProjet.Size = new System.Drawing.Size(645, 592);
            this.gpbProjet.TabIndex = 13;
            this.gpbProjet.TabStop = false;
            this.gpbProjet.Text = "Projet";
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
            this.textBox1.Size = new System.Drawing.Size(512, 78);
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
            this.lstListeParticipants.Location = new System.Drawing.Point(434, 142);
            this.lstListeParticipants.Name = "lstListeParticipants";
            this.lstListeParticipants.Size = new System.Drawing.Size(198, 104);
            this.lstListeParticipants.TabIndex = 11;
            // 
            // lstMateriel
            // 
            this.lstMateriel.BackColor = System.Drawing.Color.Black;
            this.lstMateriel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstMateriel.ForeColor = System.Drawing.Color.White;
            this.lstMateriel.FormattingEnabled = true;
            this.lstMateriel.ItemHeight = 25;
            this.lstMateriel.Location = new System.Drawing.Point(11, 369);
            this.lstMateriel.Name = "lstMateriel";
            this.lstMateriel.Size = new System.Drawing.Size(621, 204);
            this.lstMateriel.TabIndex = 10;
            // 
            // lstListeProjets
            // 
            this.lstListeProjets.BackColor = System.Drawing.Color.Black;
            this.lstListeProjets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstListeProjets.ForeColor = System.Drawing.Color.White;
            this.lstListeProjets.FormattingEnabled = true;
            this.lstListeProjets.ItemHeight = 25;
            this.lstListeProjets.Location = new System.Drawing.Point(13, 120);
            this.lstListeProjets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstListeProjets.Name = "lstListeProjets";
            this.lstListeProjets.Size = new System.Drawing.Size(311, 577);
            this.lstListeProjets.TabIndex = 14;
            // 
            // FrmWaviewGestionReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(989, 711);
            this.Controls.Add(this.lstListeProjets);
            this.Controls.Add(this.gpbProjet);
            this.Controls.Add(this.lblListeProjets);
            this.Controls.Add(this.lblGestionProjet);
            this.Controls.Add(this.btnClose);
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
        private System.Windows.Forms.ListBox lstMateriel;
        private System.Windows.Forms.ListBox lstListeProjets;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ListBox lstListeParticipants;
    }
}