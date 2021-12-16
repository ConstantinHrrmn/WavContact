
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblNomClient = new System.Windows.Forms.Label();
            this.lblNomMandant = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblAdresseRue = new System.Windows.Forms.Label();
            this.lblAdresseCP = new System.Windows.Forms.Label();
            this.lblAdresseVille = new System.Windows.Forms.Label();
            this.lblListeProjet = new System.Windows.Forms.Label();
            this.btnChat = new System.Windows.Forms.Button();
            this.lstProjet = new System.Windows.Forms.ListBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.txtNomMandant = new System.Windows.Forms.TextBox();
            this.btnSauvegarder = new System.Windows.Forms.Button();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtAdresseRue = new System.Windows.Forms.TextBox();
            this.txtAdresseCP = new System.Windows.Forms.TextBox();
            this.txtAdresseVille = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(969, 20);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 48);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblNomClient
            // 
            this.lblNomClient.AutoSize = true;
            this.lblNomClient.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomClient.ForeColor = System.Drawing.Color.White;
            this.lblNomClient.Location = new System.Drawing.Point(17, 20);
            this.lblNomClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomClient.Name = "lblNomClient";
            this.lblNomClient.Size = new System.Drawing.Size(217, 55);
            this.lblNomClient.TabIndex = 6;
            this.lblNomClient.Text = "NomClient";
            // 
            // lblNomMandant
            // 
            this.lblNomMandant.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNomMandant.AutoSize = true;
            this.lblNomMandant.ForeColor = System.Drawing.Color.White;
            this.lblNomMandant.Location = new System.Drawing.Point(29, 165);
            this.lblNomMandant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomMandant.Name = "lblNomMandant";
            this.lblNomMandant.Size = new System.Drawing.Size(154, 25);
            this.lblNomMandant.TabIndex = 7;
            this.lblNomMandant.Text = "Nom du mandant";
            // 
            // lblTelephone
            // 
            this.lblTelephone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.ForeColor = System.Drawing.Color.White;
            this.lblTelephone.Location = new System.Drawing.Point(29, 260);
            this.lblTelephone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(85, 25);
            this.lblTelephone.TabIndex = 8;
            this.lblTelephone.Text = "N° de tél.";
            // 
            // lblAdresseRue
            // 
            this.lblAdresseRue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAdresseRue.AutoSize = true;
            this.lblAdresseRue.ForeColor = System.Drawing.Color.White;
            this.lblAdresseRue.Location = new System.Drawing.Point(29, 437);
            this.lblAdresseRue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdresseRue.Name = "lblAdresseRue";
            this.lblAdresseRue.Size = new System.Drawing.Size(75, 25);
            this.lblAdresseRue.TabIndex = 9;
            this.lblAdresseRue.Text = "Adresse";
            // 
            // lblAdresseCP
            // 
            this.lblAdresseCP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAdresseCP.AutoSize = true;
            this.lblAdresseCP.ForeColor = System.Drawing.Color.White;
            this.lblAdresseCP.Location = new System.Drawing.Point(29, 533);
            this.lblAdresseCP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdresseCP.Name = "lblAdresseCP";
            this.lblAdresseCP.Size = new System.Drawing.Size(108, 25);
            this.lblAdresseCP.TabIndex = 10;
            this.lblAdresseCP.Text = "Code postal";
            // 
            // lblAdresseVille
            // 
            this.lblAdresseVille.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAdresseVille.AutoSize = true;
            this.lblAdresseVille.ForeColor = System.Drawing.Color.White;
            this.lblAdresseVille.Location = new System.Drawing.Point(303, 533);
            this.lblAdresseVille.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdresseVille.Name = "lblAdresseVille";
            this.lblAdresseVille.Size = new System.Drawing.Size(44, 25);
            this.lblAdresseVille.TabIndex = 11;
            this.lblAdresseVille.Text = "Ville";
            // 
            // lblListeProjet
            // 
            this.lblListeProjet.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblListeProjet.AutoSize = true;
            this.lblListeProjet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblListeProjet.ForeColor = System.Drawing.Color.White;
            this.lblListeProjet.Location = new System.Drawing.Point(630, 123);
            this.lblListeProjet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListeProjet.Name = "lblListeProjet";
            this.lblListeProjet.Size = new System.Drawing.Size(186, 32);
            this.lblListeProjet.TabIndex = 12;
            this.lblListeProjet.Text = "Liste des projets";
            // 
            // btnChat
            // 
            this.btnChat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChat.BackColor = System.Drawing.Color.Black;
            this.btnChat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChat.ForeColor = System.Drawing.Color.White;
            this.btnChat.Location = new System.Drawing.Point(827, 578);
            this.btnChat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(191, 53);
            this.btnChat.TabIndex = 13;
            this.btnChat.Text = "Chat";
            this.btnChat.UseVisualStyleBackColor = false;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // lstProjet
            // 
            this.lstProjet.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lstProjet.BackColor = System.Drawing.Color.Black;
            this.lstProjet.ForeColor = System.Drawing.Color.White;
            this.lstProjet.FormattingEnabled = true;
            this.lstProjet.ItemHeight = 25;
            this.lstProjet.Location = new System.Drawing.Point(630, 160);
            this.lstProjet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstProjet.Name = "lstProjet";
            this.lstProjet.Size = new System.Drawing.Size(387, 404);
            this.lstProjet.TabIndex = 14;
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifier.BackColor = System.Drawing.Color.Black;
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Location = new System.Drawing.Point(827, 20);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(133, 48);
            this.btnModifier.TabIndex = 15;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // txtNomMandant
            // 
            this.txtNomMandant.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNomMandant.BackColor = System.Drawing.Color.Black;
            this.txtNomMandant.ForeColor = System.Drawing.Color.White;
            this.txtNomMandant.Location = new System.Drawing.Point(183, 160);
            this.txtNomMandant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomMandant.Name = "txtNomMandant";
            this.txtNomMandant.ReadOnly = true;
            this.txtNomMandant.Size = new System.Drawing.Size(405, 31);
            this.txtNomMandant.TabIndex = 16;
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSauvegarder.BackColor = System.Drawing.Color.Black;
            this.btnSauvegarder.ForeColor = System.Drawing.Color.White;
            this.btnSauvegarder.Location = new System.Drawing.Point(673, 20);
            this.btnSauvegarder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.Size = new System.Drawing.Size(146, 48);
            this.btnSauvegarder.TabIndex = 17;
            this.btnSauvegarder.Text = "Sauvegarder";
            this.btnSauvegarder.UseVisualStyleBackColor = false;
            this.btnSauvegarder.Click += new System.EventHandler(this.btnSauvegarder_Click);
            // 
            // txtTel
            // 
            this.txtTel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTel.BackColor = System.Drawing.Color.Black;
            this.txtTel.ForeColor = System.Drawing.Color.White;
            this.txtTel.Location = new System.Drawing.Point(183, 255);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTel.Name = "txtTel";
            this.txtTel.ReadOnly = true;
            this.txtTel.Size = new System.Drawing.Size(405, 31);
            this.txtTel.TabIndex = 18;
            // 
            // lblMail
            // 
            this.lblMail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMail.AutoSize = true;
            this.lblMail.ForeColor = System.Drawing.Color.White;
            this.lblMail.Location = new System.Drawing.Point(29, 350);
            this.lblMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(45, 25);
            this.lblMail.TabIndex = 19;
            this.lblMail.Text = "Mail";
            // 
            // txtMail
            // 
            this.txtMail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMail.BackColor = System.Drawing.Color.Black;
            this.txtMail.ForeColor = System.Drawing.Color.White;
            this.txtMail.Location = new System.Drawing.Point(183, 345);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMail.Name = "txtMail";
            this.txtMail.ReadOnly = true;
            this.txtMail.Size = new System.Drawing.Size(405, 31);
            this.txtMail.TabIndex = 20;
            // 
            // txtAdresseRue
            // 
            this.txtAdresseRue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAdresseRue.BackColor = System.Drawing.Color.Black;
            this.txtAdresseRue.ForeColor = System.Drawing.Color.White;
            this.txtAdresseRue.Location = new System.Drawing.Point(183, 432);
            this.txtAdresseRue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAdresseRue.Name = "txtAdresseRue";
            this.txtAdresseRue.ReadOnly = true;
            this.txtAdresseRue.Size = new System.Drawing.Size(405, 31);
            this.txtAdresseRue.TabIndex = 21;
            // 
            // txtAdresseCP
            // 
            this.txtAdresseCP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAdresseCP.BackColor = System.Drawing.Color.Black;
            this.txtAdresseCP.ForeColor = System.Drawing.Color.White;
            this.txtAdresseCP.Location = new System.Drawing.Point(183, 528);
            this.txtAdresseCP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAdresseCP.Name = "txtAdresseCP";
            this.txtAdresseCP.ReadOnly = true;
            this.txtAdresseCP.Size = new System.Drawing.Size(110, 31);
            this.txtAdresseCP.TabIndex = 22;
            // 
            // txtAdresseVille
            // 
            this.txtAdresseVille.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAdresseVille.BackColor = System.Drawing.Color.Black;
            this.txtAdresseVille.ForeColor = System.Drawing.Color.White;
            this.txtAdresseVille.Location = new System.Drawing.Point(353, 528);
            this.txtAdresseVille.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAdresseVille.Name = "txtAdresseVille";
            this.txtAdresseVille.ReadOnly = true;
            this.txtAdresseVille.Size = new System.Drawing.Size(235, 31);
            this.txtAdresseVille.TabIndex = 23;
            // 
            // FrmWaviewPageClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1036, 663);
            this.Controls.Add(this.txtAdresseVille);
            this.Controls.Add(this.txtAdresseCP);
            this.Controls.Add(this.txtAdresseRue);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.btnSauvegarder);
            this.Controls.Add(this.txtNomMandant);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.lstProjet);
            this.Controls.Add(this.btnChat);
            this.Controls.Add(this.lblListeProjet);
            this.Controls.Add(this.lblAdresseVille);
            this.Controls.Add(this.lblAdresseCP);
            this.Controls.Add(this.lblAdresseRue);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.lblNomMandant);
            this.Controls.Add(this.lblNomClient);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmWaviewPageClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPageClient";
            this.Load += new System.EventHandler(this.FrmWaviewPageClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblNomClient;
        private System.Windows.Forms.Label lblNomMandant;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblAdresseRue;
        private System.Windows.Forms.Label lblAdresseCP;
        private System.Windows.Forms.Label lblAdresseVille;
        private System.Windows.Forms.Label lblListeProjet;
        private System.Windows.Forms.Button btnChat;
        private System.Windows.Forms.ListBox lstProjet;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.TextBox txtNomMandant;
        private System.Windows.Forms.Button btnSauvegarder;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtAdresseRue;
        private System.Windows.Forms.TextBox txtAdresseCP;
        private System.Windows.Forms.TextBox txtAdresseVille;
    }
}