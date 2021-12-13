
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
            this.lblGestionReservation = new System.Windows.Forms.Label();
            this.lblProjets = new System.Windows.Forms.Label();
            this.lstListeClient = new System.Windows.Forms.ListBox();
            this.clbMateriel = new System.Windows.Forms.CheckedListBox();
            this.lblListeMateriel = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblLieu = new System.Windows.Forms.Label();
            this.lblHeure = new System.Windows.Forms.Label();
            this.lblParticipant = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtHeure = new System.Windows.Forms.TextBox();
            this.lstLieux = new System.Windows.Forms.ListBox();
            this.lstParticipant = new System.Windows.Forms.ListBox();
            this.gpbReservation = new System.Windows.Forms.GroupBox();
            this.gpbReservation.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(867, 14);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 48);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblGestionReservation
            // 
            this.lblGestionReservation.AutoSize = true;
            this.lblGestionReservation.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGestionReservation.Location = new System.Drawing.Point(12, 14);
            this.lblGestionReservation.Name = "lblGestionReservation";
            this.lblGestionReservation.Size = new System.Drawing.Size(392, 48);
            this.lblGestionReservation.TabIndex = 6;
            this.lblGestionReservation.Text = "Gestion de réservations";
            // 
            // lblProjets
            // 
            this.lblProjets.AutoSize = true;
            this.lblProjets.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProjets.Location = new System.Drawing.Point(12, 104);
            this.lblProjets.Name = "lblProjets";
            this.lblProjets.Size = new System.Drawing.Size(86, 32);
            this.lblProjets.TabIndex = 7;
            this.lblProjets.Text = "Clients";
            // 
            // lstListeClient
            // 
            this.lstListeClient.BackColor = System.Drawing.Color.Black;
            this.lstListeClient.ForeColor = System.Drawing.Color.White;
            this.lstListeClient.FormattingEnabled = true;
            this.lstListeClient.ItemHeight = 25;
            this.lstListeClient.Location = new System.Drawing.Point(13, 143);
            this.lstListeClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstListeClient.Name = "lstListeClient";
            this.lstListeClient.Size = new System.Drawing.Size(310, 479);
            this.lstListeClient.TabIndex = 12;
            // 
            // clbMateriel
            // 
            this.clbMateriel.BackColor = System.Drawing.Color.Black;
            this.clbMateriel.ForeColor = System.Drawing.Color.White;
            this.clbMateriel.FormattingEnabled = true;
            this.clbMateriel.Location = new System.Drawing.Point(6, 268);
            this.clbMateriel.Name = "clbMateriel";
            this.clbMateriel.Size = new System.Drawing.Size(572, 220);
            this.clbMateriel.TabIndex = 0;
            // 
            // lblListeMateriel
            // 
            this.lblListeMateriel.AutoSize = true;
            this.lblListeMateriel.Location = new System.Drawing.Point(6, 233);
            this.lblListeMateriel.Name = "lblListeMateriel";
            this.lblListeMateriel.Size = new System.Drawing.Size(191, 32);
            this.lblListeMateriel.TabIndex = 1;
            this.lblListeMateriel.Text = "Liste du matériel";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(11, 171);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(49, 25);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // lblLieu
            // 
            this.lblLieu.AutoSize = true;
            this.lblLieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLieu.Location = new System.Drawing.Point(9, 50);
            this.lblLieu.Name = "lblLieu";
            this.lblLieu.Size = new System.Drawing.Size(55, 25);
            this.lblLieu.TabIndex = 4;
            this.lblLieu.Text = "Lieu.x";
            // 
            // lblHeure
            // 
            this.lblHeure.AutoSize = true;
            this.lblHeure.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeure.Location = new System.Drawing.Point(276, 171);
            this.lblHeure.Name = "lblHeure";
            this.lblHeure.Size = new System.Drawing.Size(59, 25);
            this.lblHeure.TabIndex = 3;
            this.lblHeure.Text = "Heure";
            // 
            // lblParticipant
            // 
            this.lblParticipant.AutoSize = true;
            this.lblParticipant.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblParticipant.Location = new System.Drawing.Point(276, 50);
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
            this.txtDate.Location = new System.Drawing.Point(66, 168);
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
            this.txtHeure.Location = new System.Drawing.Point(380, 168);
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
            this.lstLieux.Location = new System.Drawing.Point(66, 50);
            this.lstLieux.Name = "lstLieux";
            this.lstLieux.Size = new System.Drawing.Size(198, 104);
            this.lstLieux.TabIndex = 8;
            // 
            // lstParticipant
            // 
            this.lstParticipant.BackColor = System.Drawing.Color.Black;
            this.lstParticipant.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstParticipant.ForeColor = System.Drawing.Color.White;
            this.lstParticipant.FormattingEnabled = true;
            this.lstParticipant.ItemHeight = 25;
            this.lstParticipant.Location = new System.Drawing.Point(380, 50);
            this.lstParticipant.Name = "lstParticipant";
            this.lstParticipant.Size = new System.Drawing.Size(198, 104);
            this.lstParticipant.TabIndex = 9;
            // 
            // gpbReservation
            // 
            this.gpbReservation.BackColor = System.Drawing.Color.Black;
            this.gpbReservation.Controls.Add(this.lstParticipant);
            this.gpbReservation.Controls.Add(this.lstLieux);
            this.gpbReservation.Controls.Add(this.txtHeure);
            this.gpbReservation.Controls.Add(this.txtDate);
            this.gpbReservation.Controls.Add(this.lblParticipant);
            this.gpbReservation.Controls.Add(this.lblHeure);
            this.gpbReservation.Controls.Add(this.lblLieu);
            this.gpbReservation.Controls.Add(this.lblDate);
            this.gpbReservation.Controls.Add(this.lblListeMateriel);
            this.gpbReservation.Controls.Add(this.clbMateriel);
            this.gpbReservation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpbReservation.ForeColor = System.Drawing.Color.White;
            this.gpbReservation.Location = new System.Drawing.Point(330, 128);
            this.gpbReservation.Name = "gpbReservation";
            this.gpbReservation.Size = new System.Drawing.Size(587, 494);
            this.gpbReservation.TabIndex = 13;
            this.gpbReservation.TabStop = false;
            this.gpbReservation.Text = "Réservation";
            // 
            // FrmWaviewGestionReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(930, 636);
            this.Controls.Add(this.gpbReservation);
            this.Controls.Add(this.lstListeClient);
            this.Controls.Add(this.lblProjets);
            this.Controls.Add(this.lblGestionReservation);
            this.Controls.Add(this.btnClose);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmWaviewGestionReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmWaviewGestionReservation";
            this.gpbReservation.ResumeLayout(false);
            this.gpbReservation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblGestionReservation;
        private System.Windows.Forms.Label lblProjets;
        private System.Windows.Forms.ListBox lstListeClient;
        private System.Windows.Forms.CheckedListBox clbMateriel;
        private System.Windows.Forms.Label lblListeMateriel;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblLieu;
        private System.Windows.Forms.Label lblHeure;
        private System.Windows.Forms.Label lblParticipant;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtHeure;
        private System.Windows.Forms.ListBox lstLieux;
        private System.Windows.Forms.ListBox lstParticipant;
        private System.Windows.Forms.GroupBox gpbReservation;
    }
}