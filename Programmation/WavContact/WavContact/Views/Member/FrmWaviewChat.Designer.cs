
namespace WavContact.Views.Member
{
    partial class FrmWaviewChat
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
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.txtListeMessage = new System.Windows.Forms.TextBox();
            this.cboListeProjet = new System.Windows.Forms.ComboBox();
            this.lstListeClient = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEnvoye = new System.Windows.Forms.Button();
            this.lblChat = new System.Windows.Forms.Label();
            this.lblClients = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(886, 20);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 48);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.BackColor = System.Drawing.Color.Black;
            this.btnSelectionner.ForeColor = System.Drawing.Color.White;
            this.btnSelectionner.Location = new System.Drawing.Point(811, 150);
            this.btnSelectionner.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(124, 33);
            this.btnSelectionner.TabIndex = 7;
            this.btnSelectionner.Text = "Sélectionner";
            this.btnSelectionner.UseVisualStyleBackColor = false;
            // 
            // txtListeMessage
            // 
            this.txtListeMessage.BackColor = System.Drawing.Color.Black;
            this.txtListeMessage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtListeMessage.ForeColor = System.Drawing.Color.White;
            this.txtListeMessage.Location = new System.Drawing.Point(337, 198);
            this.txtListeMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtListeMessage.Multiline = true;
            this.txtListeMessage.Name = "txtListeMessage";
            this.txtListeMessage.ReadOnly = true;
            this.txtListeMessage.Size = new System.Drawing.Size(597, 592);
            this.txtListeMessage.TabIndex = 8;
            // 
            // cboListeProjet
            // 
            this.cboListeProjet.BackColor = System.Drawing.Color.Black;
            this.cboListeProjet.ForeColor = System.Drawing.Color.White;
            this.cboListeProjet.FormattingEnabled = true;
            this.cboListeProjet.Location = new System.Drawing.Point(337, 150);
            this.cboListeProjet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboListeProjet.Name = "cboListeProjet";
            this.cboListeProjet.Size = new System.Drawing.Size(464, 33);
            this.cboListeProjet.TabIndex = 9;
            // 
            // lstListeClient
            // 
            this.lstListeClient.BackColor = System.Drawing.Color.Black;
            this.lstListeClient.ForeColor = System.Drawing.Color.White;
            this.lstListeClient.FormattingEnabled = true;
            this.lstListeClient.ItemHeight = 25;
            this.lstListeClient.Location = new System.Drawing.Point(17, 150);
            this.lstListeClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstListeClient.Name = "lstListeClient";
            this.lstListeClient.Size = new System.Drawing.Size(310, 704);
            this.lstListeClient.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(337, 803);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(464, 51);
            this.textBox1.TabIndex = 11;
            // 
            // btnEnvoye
            // 
            this.btnEnvoye.BackColor = System.Drawing.Color.Black;
            this.btnEnvoye.ForeColor = System.Drawing.Color.White;
            this.btnEnvoye.Location = new System.Drawing.Point(811, 803);
            this.btnEnvoye.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnvoye.Name = "btnEnvoye";
            this.btnEnvoye.Size = new System.Drawing.Size(124, 53);
            this.btnEnvoye.TabIndex = 12;
            this.btnEnvoye.Text = "Envoyer";
            this.btnEnvoye.UseVisualStyleBackColor = false;
            // 
            // lblChat
            // 
            this.lblChat.AutoSize = true;
            this.lblChat.BackColor = System.Drawing.Color.Transparent;
            this.lblChat.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblChat.Location = new System.Drawing.Point(17, 20);
            this.lblChat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChat.Name = "lblChat";
            this.lblChat.Size = new System.Drawing.Size(107, 55);
            this.lblChat.TabIndex = 13;
            this.lblChat.Text = "Chat";
            // 
            // lblClients
            // 
            this.lblClients.AutoSize = true;
            this.lblClients.BackColor = System.Drawing.Color.Transparent;
            this.lblClients.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClients.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblClients.Location = new System.Drawing.Point(17, 113);
            this.lblClients.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClients.Name = "lblClients";
            this.lblClients.Size = new System.Drawing.Size(181, 32);
            this.lblClients.TabIndex = 14;
            this.lblClients.Text = "Liste des clients";
            // 
            // FrmWaviewChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(953, 869);
            this.Controls.Add(this.lblClients);
            this.Controls.Add(this.lblChat);
            this.Controls.Add(this.btnEnvoye);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lstListeClient);
            this.Controls.Add(this.cboListeProjet);
            this.Controls.Add(this.txtListeMessage);
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmWaviewChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmWaviewChat";
            this.Load += new System.EventHandler(this.FrmWaviewChat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.TextBox txtListeMessage;
        private System.Windows.Forms.ComboBox cboListeProjet;
        private System.Windows.Forms.ListBox lstListeClient;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEnvoye;
        private System.Windows.Forms.Label lblChat;
        private System.Windows.Forms.Label lblClients;
    }
}