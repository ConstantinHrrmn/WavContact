﻿
namespace WavContact.Views.Client
{
    partial class FrmMotDePasseOublie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMotDePasseOublie));
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbxMdp1 = new System.Windows.Forms.TextBox();
            this.lblNouveauMotDePasse = new System.Windows.Forms.Label();
            this.tbxMdp2 = new System.Windows.Forms.TextBox();
            this.lblConfirmationMotDePasse = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.lblMotDePasseOublie = new System.Windows.Forms.Label();
            this.btnSendCode = new System.Windows.Forms.Button();
            this.tbxCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxEmail
            // 
            this.tbxEmail.BackColor = System.Drawing.Color.Black;
            this.tbxEmail.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tbxEmail.ForeColor = System.Drawing.Color.White;
            this.tbxEmail.Location = new System.Drawing.Point(197, 184);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbxEmail.Multiline = true;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.PlaceholderText = "exemple@gmail.com";
            this.tbxEmail.Size = new System.Drawing.Size(425, 42);
            this.tbxEmail.TabIndex = 21;
            this.tbxEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxEmail_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(197, 150);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 30);
            this.lblEmail.TabIndex = 20;
            this.lblEmail.Text = "Email";
            // 
            // tbxMdp1
            // 
            this.tbxMdp1.BackColor = System.Drawing.Color.Black;
            this.tbxMdp1.Enabled = false;
            this.tbxMdp1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tbxMdp1.ForeColor = System.Drawing.Color.White;
            this.tbxMdp1.Location = new System.Drawing.Point(197, 448);
            this.tbxMdp1.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMdp1.Multiline = true;
            this.tbxMdp1.Name = "tbxMdp1";
            this.tbxMdp1.PlaceholderText = "veuillez saisir votre nouveau mot de passe";
            this.tbxMdp1.Size = new System.Drawing.Size(425, 42);
            this.tbxMdp1.TabIndex = 23;
            this.tbxMdp1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCode_KeyPress);
            // 
            // lblNouveauMotDePasse
            // 
            this.lblNouveauMotDePasse.AutoSize = true;
            this.lblNouveauMotDePasse.Enabled = false;
            this.lblNouveauMotDePasse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNouveauMotDePasse.ForeColor = System.Drawing.Color.White;
            this.lblNouveauMotDePasse.Location = new System.Drawing.Point(197, 414);
            this.lblNouveauMotDePasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNouveauMotDePasse.Name = "lblNouveauMotDePasse";
            this.lblNouveauMotDePasse.Size = new System.Drawing.Size(227, 30);
            this.lblNouveauMotDePasse.TabIndex = 22;
            this.lblNouveauMotDePasse.Text = "Nouveau mot de passe";
            // 
            // tbxMdp2
            // 
            this.tbxMdp2.BackColor = System.Drawing.Color.Black;
            this.tbxMdp2.Enabled = false;
            this.tbxMdp2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tbxMdp2.ForeColor = System.Drawing.Color.White;
            this.tbxMdp2.Location = new System.Drawing.Point(197, 540);
            this.tbxMdp2.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMdp2.Multiline = true;
            this.tbxMdp2.Name = "tbxMdp2";
            this.tbxMdp2.PlaceholderText = "veuillez saisir le mot de passe précédent";
            this.tbxMdp2.Size = new System.Drawing.Size(425, 42);
            this.tbxMdp2.TabIndex = 25;
            this.tbxMdp2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCode_KeyPress);
            // 
            // lblConfirmationMotDePasse
            // 
            this.lblConfirmationMotDePasse.AutoSize = true;
            this.lblConfirmationMotDePasse.Enabled = false;
            this.lblConfirmationMotDePasse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConfirmationMotDePasse.ForeColor = System.Drawing.Color.White;
            this.lblConfirmationMotDePasse.Location = new System.Drawing.Point(197, 506);
            this.lblConfirmationMotDePasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmationMotDePasse.Name = "lblConfirmationMotDePasse";
            this.lblConfirmationMotDePasse.Size = new System.Drawing.Size(350, 30);
            this.lblConfirmationMotDePasse.TabIndex = 24;
            this.lblConfirmationMotDePasse.Text = "Confirmation nouveau mot de passe";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.Black;
            this.btnEnregistrer.Enabled = false;
            this.btnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrer.Location = new System.Drawing.Point(412, 612);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(214, 64);
            this.btnEnregistrer.TabIndex = 26;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // lblMotDePasseOublie
            // 
            this.lblMotDePasseOublie.AutoSize = true;
            this.lblMotDePasseOublie.BackColor = System.Drawing.Color.Transparent;
            this.lblMotDePasseOublie.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMotDePasseOublie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMotDePasseOublie.Location = new System.Drawing.Point(184, 18);
            this.lblMotDePasseOublie.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMotDePasseOublie.Name = "lblMotDePasseOublie";
            this.lblMotDePasseOublie.Size = new System.Drawing.Size(456, 65);
            this.lblMotDePasseOublie.TabIndex = 19;
            this.lblMotDePasseOublie.Text = "Mot de passe oublié";
            // 
            // btnSendCode
            // 
            this.btnSendCode.BackColor = System.Drawing.Color.Black;
            this.btnSendCode.Enabled = false;
            this.btnSendCode.ForeColor = System.Drawing.Color.White;
            this.btnSendCode.Location = new System.Drawing.Point(409, 240);
            this.btnSendCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.Size = new System.Drawing.Size(217, 64);
            this.btnSendCode.TabIndex = 27;
            this.btnSendCode.Text = "Envoyer code";
            this.btnSendCode.UseVisualStyleBackColor = false;
            this.btnSendCode.Click += new System.EventHandler(this.btnSendCode_Click);
            // 
            // tbxCode
            // 
            this.tbxCode.BackColor = System.Drawing.Color.Black;
            this.tbxCode.Enabled = false;
            this.tbxCode.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tbxCode.ForeColor = System.Drawing.Color.White;
            this.tbxCode.Location = new System.Drawing.Point(200, 354);
            this.tbxCode.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCode.Multiline = true;
            this.tbxCode.Name = "tbxCode";
            this.tbxCode.PlaceholderText = "Code reçu par email";
            this.tbxCode.Size = new System.Drawing.Size(425, 42);
            this.tbxCode.TabIndex = 29;
            this.tbxCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCode_KeyPress);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Enabled = false;
            this.lblCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCode.ForeColor = System.Drawing.Color.White;
            this.lblCode.Location = new System.Drawing.Point(200, 320);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(107, 30);
            this.lblCode.TabIndex = 28;
            this.lblCode.Text = "Code reçu";
            // 
            // FrmMotDePasseOublie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(829, 722);
            this.Controls.Add(this.tbxCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.btnSendCode);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.tbxMdp2);
            this.Controls.Add(this.lblConfirmationMotDePasse);
            this.Controls.Add(this.tbxMdp1);
            this.Controls.Add(this.lblNouveauMotDePasse);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblMotDePasseOublie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmMotDePasseOublie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mot de passe oublié";
            this.Load += new System.EventHandler(this.FrmMotDePasseOublie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbxMdp1;
        private System.Windows.Forms.Label lblNouveauMotDePasse;
        private System.Windows.Forms.TextBox tbxMdp2;
        private System.Windows.Forms.Label lblConfirmationMotDePasse;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label lblMotDePasseOublie;
        private System.Windows.Forms.Button btnSendCode;
        private System.Windows.Forms.TextBox tbxCode;
        private System.Windows.Forms.Label lblCode;
    }
}