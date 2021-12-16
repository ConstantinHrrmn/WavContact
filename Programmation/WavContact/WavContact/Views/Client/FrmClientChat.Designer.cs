
namespace WavContact.Views.Client
{
    partial class FrmClientChat
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
            this.btnEnvoyer = new System.Windows.Forms.Button();
            this.txbEcrireMessage = new System.Windows.Forms.TextBox();
            this.txtListeMessage = new System.Windows.Forms.TextBox();
            this.lblRecherche = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnvoyer
            // 
            this.btnEnvoyer.BackColor = System.Drawing.Color.Black;
            this.btnEnvoyer.ForeColor = System.Drawing.Color.White;
            this.btnEnvoyer.Location = new System.Drawing.Point(392, 717);
            this.btnEnvoyer.Name = "btnEnvoyer";
            this.btnEnvoyer.Size = new System.Drawing.Size(80, 32);
            this.btnEnvoyer.TabIndex = 17;
            this.btnEnvoyer.Text = "Envoyer";
            this.btnEnvoyer.UseVisualStyleBackColor = false;
            // 
            // txbEcrireMessage
            // 
            this.txbEcrireMessage.BackColor = System.Drawing.Color.Black;
            this.txbEcrireMessage.Location = new System.Drawing.Point(12, 716);
            this.txbEcrireMessage.Multiline = true;
            this.txbEcrireMessage.Name = "txbEcrireMessage";
            this.txbEcrireMessage.Size = new System.Drawing.Size(374, 33);
            this.txbEcrireMessage.TabIndex = 16;
            // 
            // txtListeMessage
            // 
            this.txtListeMessage.BackColor = System.Drawing.Color.Black;
            this.txtListeMessage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtListeMessage.ForeColor = System.Drawing.Color.White;
            this.txtListeMessage.Location = new System.Drawing.Point(12, 12);
            this.txtListeMessage.Multiline = true;
            this.txtListeMessage.Name = "txtListeMessage";
            this.txtListeMessage.ReadOnly = true;
            this.txtListeMessage.Size = new System.Drawing.Size(460, 699);
            this.txtListeMessage.TabIndex = 18;
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.BackColor = System.Drawing.Color.Transparent;
            this.lblRecherche.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblRecherche.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRecherche.Location = new System.Drawing.Point(33, 113);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(0, 15);
            this.lblRecherche.TabIndex = 19;
            // 
            // FrmClientChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(484, 761);
            this.Controls.Add(this.lblRecherche);
            this.Controls.Add(this.txtListeMessage);
            this.Controls.Add(this.btnEnvoyer);
            this.Controls.Add(this.txbEcrireMessage);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmClientChat";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.FrmClientChat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEnvoyer;
        private System.Windows.Forms.TextBox txbEcrireMessage;
        private System.Windows.Forms.TextBox txtListeMessage;
        private System.Windows.Forms.Label lblRecherche;
    }
}