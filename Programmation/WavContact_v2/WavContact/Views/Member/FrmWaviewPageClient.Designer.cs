
namespace WavContact.Views.Member
{
    partial class FrmWaviewPageClient
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
            this.lblNomClient = new System.Windows.Forms.Label();
            this.lblNomMandant = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblAdresseRue = new System.Windows.Forms.Label();
            this.lblAdresseCP = new System.Windows.Forms.Label();
            this.lblAdresseVille = new System.Windows.Forms.Label();
            this.tbxPrenom = new System.Windows.Forms.TextBox();
            this.btnSauvegarder = new System.Windows.Forms.Button();
            this.tbxTel = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.tbxMail = new System.Windows.Forms.TextBox();
            this.tbxAdresseRue = new System.Windows.Forms.TextBox();
            this.tbxAdresseCP = new System.Windows.Forms.TextBox();
            this.tbxAdresseVille = new System.Windows.Forms.TextBox();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNomClient
            // 
            this.lblNomClient.AutoSize = true;
            this.lblNomClient.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomClient.ForeColor = System.Drawing.Color.White;
            this.lblNomClient.Location = new System.Drawing.Point(12, 12);
            this.lblNomClient.Name = "lblNomClient";
            this.lblNomClient.Size = new System.Drawing.Size(238, 37);
            this.lblNomClient.TabIndex = 6;
            this.lblNomClient.Text = "Informations client";
            // 
            // lblNomMandant
            // 
            this.lblNomMandant.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNomMandant.AutoSize = true;
            this.lblNomMandant.ForeColor = System.Drawing.Color.White;
            this.lblNomMandant.Location = new System.Drawing.Point(20, 99);
            this.lblNomMandant.Name = "lblNomMandant";
            this.lblNomMandant.Size = new System.Drawing.Size(49, 15);
            this.lblNomMandant.TabIndex = 7;
            this.lblNomMandant.Text = "Prenom";
            // 
            // lblTelephone
            // 
            this.lblTelephone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.ForeColor = System.Drawing.Color.White;
            this.lblTelephone.Location = new System.Drawing.Point(20, 156);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(56, 15);
            this.lblTelephone.TabIndex = 8;
            this.lblTelephone.Text = "N° de tél.";
            // 
            // lblAdresseRue
            // 
            this.lblAdresseRue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAdresseRue.AutoSize = true;
            this.lblAdresseRue.ForeColor = System.Drawing.Color.White;
            this.lblAdresseRue.Location = new System.Drawing.Point(20, 258);
            this.lblAdresseRue.Name = "lblAdresseRue";
            this.lblAdresseRue.Size = new System.Drawing.Size(48, 15);
            this.lblAdresseRue.TabIndex = 9;
            this.lblAdresseRue.Text = "Adresse";
            // 
            // lblAdresseCP
            // 
            this.lblAdresseCP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAdresseCP.AutoSize = true;
            this.lblAdresseCP.ForeColor = System.Drawing.Color.White;
            this.lblAdresseCP.Location = new System.Drawing.Point(20, 287);
            this.lblAdresseCP.Name = "lblAdresseCP";
            this.lblAdresseCP.Size = new System.Drawing.Size(70, 15);
            this.lblAdresseCP.TabIndex = 10;
            this.lblAdresseCP.Text = "Code postal";
            // 
            // lblAdresseVille
            // 
            this.lblAdresseVille.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAdresseVille.AutoSize = true;
            this.lblAdresseVille.ForeColor = System.Drawing.Color.White;
            this.lblAdresseVille.Location = new System.Drawing.Point(212, 287);
            this.lblAdresseVille.Name = "lblAdresseVille";
            this.lblAdresseVille.Size = new System.Drawing.Size(29, 15);
            this.lblAdresseVille.TabIndex = 11;
            this.lblAdresseVille.Text = "Ville";
            // 
            // tbxPrenom
            // 
            this.tbxPrenom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbxPrenom.BackColor = System.Drawing.Color.Black;
            this.tbxPrenom.ForeColor = System.Drawing.Color.White;
            this.tbxPrenom.Location = new System.Drawing.Point(128, 96);
            this.tbxPrenom.Name = "tbxPrenom";
            this.tbxPrenom.ReadOnly = true;
            this.tbxPrenom.Size = new System.Drawing.Size(285, 23);
            this.tbxPrenom.TabIndex = 16;
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSauvegarder.BackColor = System.Drawing.Color.Black;
            this.btnSauvegarder.ForeColor = System.Drawing.Color.White;
            this.btnSauvegarder.Location = new System.Drawing.Point(311, 324);
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.Size = new System.Drawing.Size(102, 29);
            this.btnSauvegarder.TabIndex = 17;
            this.btnSauvegarder.Text = "Sauvegarder";
            this.btnSauvegarder.UseVisualStyleBackColor = false;
            this.btnSauvegarder.Click += new System.EventHandler(this.btnSauvegarder_Click);
            // 
            // tbxTel
            // 
            this.tbxTel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbxTel.BackColor = System.Drawing.Color.Black;
            this.tbxTel.ForeColor = System.Drawing.Color.White;
            this.tbxTel.Location = new System.Drawing.Point(128, 153);
            this.tbxTel.Name = "tbxTel";
            this.tbxTel.ReadOnly = true;
            this.tbxTel.Size = new System.Drawing.Size(285, 23);
            this.tbxTel.TabIndex = 18;
            // 
            // lblMail
            // 
            this.lblMail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMail.AutoSize = true;
            this.lblMail.ForeColor = System.Drawing.Color.White;
            this.lblMail.Location = new System.Drawing.Point(20, 210);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(30, 15);
            this.lblMail.TabIndex = 19;
            this.lblMail.Text = "Mail";
            // 
            // tbxMail
            // 
            this.tbxMail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbxMail.BackColor = System.Drawing.Color.Black;
            this.tbxMail.ForeColor = System.Drawing.Color.White;
            this.tbxMail.Location = new System.Drawing.Point(128, 202);
            this.tbxMail.Name = "tbxMail";
            this.tbxMail.ReadOnly = true;
            this.tbxMail.Size = new System.Drawing.Size(285, 23);
            this.tbxMail.TabIndex = 20;
            // 
            // tbxAdresseRue
            // 
            this.tbxAdresseRue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbxAdresseRue.BackColor = System.Drawing.Color.Black;
            this.tbxAdresseRue.ForeColor = System.Drawing.Color.White;
            this.tbxAdresseRue.Location = new System.Drawing.Point(128, 255);
            this.tbxAdresseRue.Name = "tbxAdresseRue";
            this.tbxAdresseRue.ReadOnly = true;
            this.tbxAdresseRue.Size = new System.Drawing.Size(285, 23);
            this.tbxAdresseRue.TabIndex = 21;
            // 
            // tbxAdresseCP
            // 
            this.tbxAdresseCP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbxAdresseCP.BackColor = System.Drawing.Color.Black;
            this.tbxAdresseCP.ForeColor = System.Drawing.Color.White;
            this.tbxAdresseCP.Location = new System.Drawing.Point(128, 284);
            this.tbxAdresseCP.Name = "tbxAdresseCP";
            this.tbxAdresseCP.ReadOnly = true;
            this.tbxAdresseCP.Size = new System.Drawing.Size(78, 23);
            this.tbxAdresseCP.TabIndex = 22;
            // 
            // tbxAdresseVille
            // 
            this.tbxAdresseVille.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbxAdresseVille.BackColor = System.Drawing.Color.Black;
            this.tbxAdresseVille.ForeColor = System.Drawing.Color.White;
            this.tbxAdresseVille.Location = new System.Drawing.Point(247, 284);
            this.tbxAdresseVille.Name = "tbxAdresseVille";
            this.tbxAdresseVille.ReadOnly = true;
            this.tbxAdresseVille.Size = new System.Drawing.Size(166, 23);
            this.tbxAdresseVille.TabIndex = 23;
            // 
            // tbxNom
            // 
            this.tbxNom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbxNom.BackColor = System.Drawing.Color.Black;
            this.tbxNom.ForeColor = System.Drawing.Color.White;
            this.tbxNom.Location = new System.Drawing.Point(128, 67);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.ReadOnly = true;
            this.tbxNom.Size = new System.Drawing.Size(285, 23);
            this.tbxNom.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nom";
            // 
            // FrmWaviewPageClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(434, 398);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxNom);
            this.Controls.Add(this.tbxAdresseVille);
            this.Controls.Add(this.tbxAdresseCP);
            this.Controls.Add(this.tbxAdresseRue);
            this.Controls.Add(this.tbxMail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.tbxTel);
            this.Controls.Add(this.btnSauvegarder);
            this.Controls.Add(this.tbxPrenom);
            this.Controls.Add(this.lblAdresseVille);
            this.Controls.Add(this.lblAdresseCP);
            this.Controls.Add(this.lblAdresseRue);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.lblNomMandant);
            this.Controls.Add(this.lblNomClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmWaviewPageClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.Load += new System.EventHandler(this.FrmWaviewPageClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNomClient;
        private System.Windows.Forms.Label lblNomMandant;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblAdresseRue;
        private System.Windows.Forms.Label lblAdresseCP;
        private System.Windows.Forms.Label lblAdresseVille;
        private System.Windows.Forms.TextBox tbxPrenom;
        private System.Windows.Forms.Button btnSauvegarder;
        private System.Windows.Forms.TextBox tbxTel;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox tbxMail;
        private System.Windows.Forms.TextBox tbxAdresseRue;
        private System.Windows.Forms.TextBox tbxAdresseCP;
        private System.Windows.Forms.TextBox tbxAdresseVille;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.Label label1;
    }
}