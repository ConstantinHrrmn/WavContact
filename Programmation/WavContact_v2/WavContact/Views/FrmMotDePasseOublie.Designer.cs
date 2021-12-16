
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNouveauMotDePasse = new System.Windows.Forms.TextBox();
            this.lblNouveauMotDePasse = new System.Windows.Forms.Label();
            this.txtConfirmationMotDePasse = new System.Windows.Forms.TextBox();
            this.lblConfirmationMotDePasse = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.lblMotDePasseOublie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Black;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(115, 111);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(250, 23);
            this.txtEmail.TabIndex = 21;
            this.txtEmail.Text = "exemple@gmail.com";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(115, 94);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 20;
            this.lblEmail.Text = "Email";
            // 
            // txtNouveauMotDePasse
            // 
            this.txtNouveauMotDePasse.BackColor = System.Drawing.Color.Black;
            this.txtNouveauMotDePasse.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtNouveauMotDePasse.ForeColor = System.Drawing.Color.White;
            this.txtNouveauMotDePasse.Location = new System.Drawing.Point(115, 183);
            this.txtNouveauMotDePasse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNouveauMotDePasse.Multiline = true;
            this.txtNouveauMotDePasse.Name = "txtNouveauMotDePasse";
            this.txtNouveauMotDePasse.ReadOnly = true;
            this.txtNouveauMotDePasse.Size = new System.Drawing.Size(250, 23);
            this.txtNouveauMotDePasse.TabIndex = 23;
            this.txtNouveauMotDePasse.Text = "veuillez saisir votre nouveau mot de passe";
            // 
            // lblNouveauMotDePasse
            // 
            this.lblNouveauMotDePasse.AutoSize = true;
            this.lblNouveauMotDePasse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNouveauMotDePasse.ForeColor = System.Drawing.Color.White;
            this.lblNouveauMotDePasse.Location = new System.Drawing.Point(115, 166);
            this.lblNouveauMotDePasse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNouveauMotDePasse.Name = "lblNouveauMotDePasse";
            this.lblNouveauMotDePasse.Size = new System.Drawing.Size(128, 15);
            this.lblNouveauMotDePasse.TabIndex = 22;
            this.lblNouveauMotDePasse.Text = "Nouveau mot de passe";
            // 
            // txtConfirmationMotDePasse
            // 
            this.txtConfirmationMotDePasse.BackColor = System.Drawing.Color.Black;
            this.txtConfirmationMotDePasse.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtConfirmationMotDePasse.ForeColor = System.Drawing.Color.White;
            this.txtConfirmationMotDePasse.Location = new System.Drawing.Point(115, 253);
            this.txtConfirmationMotDePasse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtConfirmationMotDePasse.Multiline = true;
            this.txtConfirmationMotDePasse.Name = "txtConfirmationMotDePasse";
            this.txtConfirmationMotDePasse.ReadOnly = true;
            this.txtConfirmationMotDePasse.Size = new System.Drawing.Size(250, 23);
            this.txtConfirmationMotDePasse.TabIndex = 25;
            this.txtConfirmationMotDePasse.Text = "veuillez saisir le mot de passe précédent";
            // 
            // lblConfirmationMotDePasse
            // 
            this.lblConfirmationMotDePasse.AutoSize = true;
            this.lblConfirmationMotDePasse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConfirmationMotDePasse.ForeColor = System.Drawing.Color.White;
            this.lblConfirmationMotDePasse.Location = new System.Drawing.Point(115, 236);
            this.lblConfirmationMotDePasse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirmationMotDePasse.Name = "lblConfirmationMotDePasse";
            this.lblConfirmationMotDePasse.Size = new System.Drawing.Size(200, 15);
            this.lblConfirmationMotDePasse.TabIndex = 24;
            this.lblConfirmationMotDePasse.Text = "Confirmation nouveau mot de passe";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.Black;
            this.btnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrer.Location = new System.Drawing.Point(285, 306);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(80, 32);
            this.btnEnregistrer.TabIndex = 26;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            // 
            // lblMotDePasseOublie
            // 
            this.lblMotDePasseOublie.AutoSize = true;
            this.lblMotDePasseOublie.BackColor = System.Drawing.Color.Transparent;
            this.lblMotDePasseOublie.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMotDePasseOublie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMotDePasseOublie.Location = new System.Drawing.Point(107, 28);
            this.lblMotDePasseOublie.Name = "lblMotDePasseOublie";
            this.lblMotDePasseOublie.Size = new System.Drawing.Size(258, 37);
            this.lblMotDePasseOublie.TabIndex = 19;
            this.lblMotDePasseOublie.Text = "Mot de passe oublié";
            // 
            // FrmMotDePasseOublie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.txtConfirmationMotDePasse);
            this.Controls.Add(this.lblConfirmationMotDePasse);
            this.Controls.Add(this.txtNouveauMotDePasse);
            this.Controls.Add(this.lblNouveauMotDePasse);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblMotDePasseOublie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmMotDePasseOublie";
            this.Text = "Mot de passe oublié";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNouveauMotDePasse;
        private System.Windows.Forms.Label lblNouveauMotDePasse;
        private System.Windows.Forms.TextBox txtConfirmationMotDePasse;
        private System.Windows.Forms.Label lblConfirmationMotDePasse;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label lblMotDePasseOublie;
    }
}