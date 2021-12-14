
namespace WavContact.Views.Client
{
    partial class FrmProjet
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
            this.lblProjet = new System.Windows.Forms.Label();
            this.lstProjets = new System.Windows.Forms.ListBox();
            this.lblListeProjets = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.gpbProjet = new System.Windows.Forms.GroupBox();
            this.lstDateTournages = new System.Windows.Forms.ListBox();
            this.lblAste = new System.Windows.Forms.Label();
            this.lblCHF = new System.Windows.Forms.Label();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.lblPrix = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lstParticipants = new System.Windows.Forms.ListBox();
            this.lstLieux = new System.Windows.Forms.ListBox();
            this.lblParticipant = new System.Windows.Forms.Label();
            this.lblLieu = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAsteri = new System.Windows.Forms.Label();
            this.lblTextePrix = new System.Windows.Forms.Label();
            this.btnSwitchMode = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.gpbProjet.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProjet
            // 
            this.lblProjet.AutoSize = true;
            this.lblProjet.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProjet.ForeColor = System.Drawing.Color.White;
            this.lblProjet.Location = new System.Drawing.Point(13, 61);
            this.lblProjet.Name = "lblProjet";
            this.lblProjet.Size = new System.Drawing.Size(114, 48);
            this.lblProjet.TabIndex = 7;
            this.lblProjet.Text = "Projet";
            // 
            // lstProjets
            // 
            this.lstProjets.BackColor = System.Drawing.Color.Black;
            this.lstProjets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstProjets.ForeColor = System.Drawing.Color.White;
            this.lstProjets.FormattingEnabled = true;
            this.lstProjets.ItemHeight = 25;
            this.lstProjets.Location = new System.Drawing.Point(13, 177);
            this.lstProjets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstProjets.Name = "lstProjets";
            this.lstProjets.Size = new System.Drawing.Size(325, 527);
            this.lstProjets.TabIndex = 15;
            // 
            // lblListeProjets
            // 
            this.lblListeProjets.AutoSize = true;
            this.lblListeProjets.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblListeProjets.ForeColor = System.Drawing.Color.White;
            this.lblListeProjets.Location = new System.Drawing.Point(13, 140);
            this.lblListeProjets.Name = "lblListeProjets";
            this.lblListeProjets.Size = new System.Drawing.Size(186, 32);
            this.lblListeProjets.TabIndex = 16;
            this.lblListeProjets.Text = "Liste des projets";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(997, 14);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 48);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gpbProjet
            // 
            this.gpbProjet.BackColor = System.Drawing.Color.Black;
            this.gpbProjet.Controls.Add(this.lstDateTournages);
            this.gpbProjet.Controls.Add(this.lblAste);
            this.gpbProjet.Controls.Add(this.lblCHF);
            this.gpbProjet.Controls.Add(this.txtPrix);
            this.gpbProjet.Controls.Add(this.lblPrix);
            this.gpbProjet.Controls.Add(this.textBox1);
            this.gpbProjet.Controls.Add(this.lblDescription);
            this.gpbProjet.Controls.Add(this.lstParticipants);
            this.gpbProjet.Controls.Add(this.lstLieux);
            this.gpbProjet.Controls.Add(this.lblParticipant);
            this.gpbProjet.Controls.Add(this.lblLieu);
            this.gpbProjet.Controls.Add(this.lblDate);
            this.gpbProjet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpbProjet.ForeColor = System.Drawing.Color.White;
            this.gpbProjet.Location = new System.Drawing.Point(362, 177);
            this.gpbProjet.Name = "gpbProjet";
            this.gpbProjet.Size = new System.Drawing.Size(685, 527);
            this.gpbProjet.TabIndex = 18;
            this.gpbProjet.TabStop = false;
            this.gpbProjet.Text = "Projet";
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
            this.lstDateTournages.Size = new System.Drawing.Size(198, 104);
            this.lstDateTournages.TabIndex = 40;
            // 
            // lblAste
            // 
            this.lblAste.AutoSize = true;
            this.lblAste.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAste.Location = new System.Drawing.Point(51, 443);
            this.lblAste.Name = "lblAste";
            this.lblAste.Size = new System.Drawing.Size(20, 25);
            this.lblAste.TabIndex = 22;
            this.lblAste.Text = "*";
            // 
            // lblCHF
            // 
            this.lblCHF.AutoSize = true;
            this.lblCHF.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCHF.Location = new System.Drawing.Point(331, 446);
            this.lblCHF.Name = "lblCHF";
            this.lblCHF.Size = new System.Drawing.Size(45, 25);
            this.lblCHF.TabIndex = 21;
            this.lblCHF.Text = "CHF";
            // 
            // txtPrix
            // 
            this.txtPrix.BackColor = System.Drawing.Color.Black;
            this.txtPrix.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrix.ForeColor = System.Drawing.Color.White;
            this.txtPrix.Location = new System.Drawing.Point(120, 443);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.ReadOnly = true;
            this.txtPrix.Size = new System.Drawing.Size(198, 31);
            this.txtPrix.TabIndex = 20;
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrix.Location = new System.Drawing.Point(16, 446);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(40, 25);
            this.lblPrix.TabIndex = 19;
            this.lblPrix.Text = "Prix";
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
            // lstParticipants
            // 
            this.lstParticipants.BackColor = System.Drawing.Color.Black;
            this.lstParticipants.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstParticipants.ForeColor = System.Drawing.Color.White;
            this.lstParticipants.FormattingEnabled = true;
            this.lstParticipants.ItemHeight = 25;
            this.lstParticipants.Location = new System.Drawing.Point(434, 162);
            this.lstParticipants.Name = "lstParticipants";
            this.lstParticipants.Size = new System.Drawing.Size(198, 104);
            this.lstParticipants.TabIndex = 11;
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
            this.lstLieux.Size = new System.Drawing.Size(198, 104);
            this.lstLieux.TabIndex = 8;
            // 
            // lblParticipant
            // 
            this.lblParticipant.AutoSize = true;
            this.lblParticipant.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblParticipant.Location = new System.Drawing.Point(331, 162);
            this.lblParticipant.Name = "lblParticipant";
            this.lblParticipant.Size = new System.Drawing.Size(102, 25);
            this.lblParticipant.TabIndex = 5;
            this.lblParticipant.Text = "Participants";
            // 
            // lblLieu
            // 
            this.lblLieu.AutoSize = true;
            this.lblLieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLieu.Location = new System.Drawing.Point(16, 162);
            this.lblLieu.Name = "lblLieu";
            this.lblLieu.Size = new System.Drawing.Size(55, 25);
            this.lblLieu.TabIndex = 4;
            this.lblLieu.Text = "Lieu.x";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(16, 302);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(49, 25);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // lblAsteri
            // 
            this.lblAsteri.AutoSize = true;
            this.lblAsteri.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAsteri.ForeColor = System.Drawing.Color.White;
            this.lblAsteri.Location = new System.Drawing.Point(13, 726);
            this.lblAsteri.Name = "lblAsteri";
            this.lblAsteri.Size = new System.Drawing.Size(20, 25);
            this.lblAsteri.TabIndex = 24;
            this.lblAsteri.Text = "*";
            // 
            // lblTextePrix
            // 
            this.lblTextePrix.AutoSize = true;
            this.lblTextePrix.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTextePrix.ForeColor = System.Drawing.Color.White;
            this.lblTextePrix.Location = new System.Drawing.Point(28, 728);
            this.lblTextePrix.Name = "lblTextePrix";
            this.lblTextePrix.Size = new System.Drawing.Size(580, 21);
            this.lblTextePrix.TabIndex = 25;
            this.lblTextePrix.Text = "Le prix n\'est pas définitif, c\'est une estimation il peut-être à la hausse ou à l" +
    "a baisse";
            // 
            // btnSwitchMode
            // 
            this.btnSwitchMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitchMode.ForeColor = System.Drawing.Color.White;
            this.btnSwitchMode.Location = new System.Drawing.Point(729, 12);
            this.btnSwitchMode.Name = "btnSwitchMode";
            this.btnSwitchMode.Size = new System.Drawing.Size(81, 48);
            this.btnSwitchMode.TabIndex = 28;
            this.btnSwitchMode.Text = "Light";
            this.btnSwitchMode.UseVisualStyleBackColor = true;
            this.btnSwitchMode.Click += new System.EventHandler(this.btnSwitchMode_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(817, 14);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(169, 48);
            this.btnLogout.TabIndex = 39;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // FrmProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1060, 758);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSwitchMode);
            this.Controls.Add(this.lblTextePrix);
            this.Controls.Add(this.lblAsteri);
            this.Controls.Add(this.gpbProjet);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblListeProjets);
            this.Controls.Add(this.lstProjets);
            this.Controls.Add(this.lblProjet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProjet";
            this.Text = "FrmClientProjet";
            this.Load += new System.EventHandler(this.FrmClientProjet_Load);
            this.gpbProjet.ResumeLayout(false);
            this.gpbProjet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjet;
        private System.Windows.Forms.ListBox lstProjets;
        private System.Windows.Forms.Label lblListeProjets;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gpbProjet;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ListBox lstParticipants;
        private System.Windows.Forms.ListBox lstLieux;
        private System.Windows.Forms.Label lblParticipant;
        private System.Windows.Forms.Label lblLieu;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAste;
        private System.Windows.Forms.Label lblCHF;
        private System.Windows.Forms.Label lblAsteri;
        private System.Windows.Forms.Label lblTextePrix;
        private System.Windows.Forms.Button btnSwitchMode;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ListBox lstDateTournages;
    }
}