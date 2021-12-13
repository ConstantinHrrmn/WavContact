
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblChat = new System.Windows.Forms.Label();
            this.lstListeProjet = new System.Windows.Forms.ListBox();
            this.btnEnvoyer = new System.Windows.Forms.Button();
            this.txbEcrireMessage = new System.Windows.Forms.TextBox();
            this.txtListeMessage = new System.Windows.Forms.TextBox();
            this.lblRecherche = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnSwitchMode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(868, 14);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 48);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblChat
            // 
            this.lblChat.AutoSize = true;
            this.lblChat.BackColor = System.Drawing.Color.Transparent;
            this.lblChat.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblChat.Location = new System.Drawing.Point(13, 9);
            this.lblChat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChat.Name = "lblChat";
            this.lblChat.Size = new System.Drawing.Size(107, 55);
            this.lblChat.TabIndex = 14;
            this.lblChat.Text = "Chat";
            // 
            // lstListeProjet
            // 
            this.lstListeProjet.BackColor = System.Drawing.Color.Black;
            this.lstListeProjet.ForeColor = System.Drawing.Color.White;
            this.lstListeProjet.FormattingEnabled = true;
            this.lstListeProjet.ItemHeight = 25;
            this.lstListeProjet.Location = new System.Drawing.Point(13, 144);
            this.lstListeProjet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstListeProjet.Name = "lstListeProjet";
            this.lstListeProjet.Size = new System.Drawing.Size(310, 629);
            this.lstListeProjet.TabIndex = 15;
            // 
            // btnEnvoyer
            // 
            this.btnEnvoyer.BackColor = System.Drawing.Color.Black;
            this.btnEnvoyer.ForeColor = System.Drawing.Color.White;
            this.btnEnvoyer.Location = new System.Drawing.Point(803, 720);
            this.btnEnvoyer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnvoyer.Name = "btnEnvoyer";
            this.btnEnvoyer.Size = new System.Drawing.Size(115, 53);
            this.btnEnvoyer.TabIndex = 17;
            this.btnEnvoyer.Text = "Envoyer";
            this.btnEnvoyer.UseVisualStyleBackColor = false;
            // 
            // txbEcrireMessage
            // 
            this.txbEcrireMessage.BackColor = System.Drawing.Color.Black;
            this.txbEcrireMessage.Location = new System.Drawing.Point(331, 720);
            this.txbEcrireMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbEcrireMessage.Multiline = true;
            this.txbEcrireMessage.Name = "txbEcrireMessage";
            this.txbEcrireMessage.Size = new System.Drawing.Size(464, 53);
            this.txbEcrireMessage.TabIndex = 16;
            // 
            // txtListeMessage
            // 
            this.txtListeMessage.BackColor = System.Drawing.Color.Black;
            this.txtListeMessage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtListeMessage.ForeColor = System.Drawing.Color.White;
            this.txtListeMessage.Location = new System.Drawing.Point(331, 94);
            this.txtListeMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtListeMessage.Multiline = true;
            this.txtListeMessage.Name = "txtListeMessage";
            this.txtListeMessage.ReadOnly = true;
            this.txtListeMessage.Size = new System.Drawing.Size(587, 616);
            this.txtListeMessage.TabIndex = 18;
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.BackColor = System.Drawing.Color.Transparent;
            this.lblRecherche.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblRecherche.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRecherche.Location = new System.Drawing.Point(50, 102);
            this.lblRecherche.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(236, 25);
            this.lblRecherche.TabIndex = 19;
            this.lblRecherche.Text = "Rechercher un nom de projet";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(13, 94);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(310, 40);
            this.textBox1.TabIndex = 20;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblMessage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMessage.Location = new System.Drawing.Point(497, 734);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(153, 25);
            this.lblMessage.TabIndex = 21;
            this.lblMessage.Text = "Taper un message";
            // 
            // btnSwitchMode
            // 
            this.btnSwitchMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitchMode.ForeColor = System.Drawing.Color.White;
            this.btnSwitchMode.Location = new System.Drawing.Point(802, 14);
            this.btnSwitchMode.Name = "btnSwitchMode";
            this.btnSwitchMode.Size = new System.Drawing.Size(59, 48);
            this.btnSwitchMode.TabIndex = 28;
            this.btnSwitchMode.Text = "Light";
            this.btnSwitchMode.UseVisualStyleBackColor = true;
            this.btnSwitchMode.Click += new System.EventHandler(this.btnSwitchMode_Click);
            // 
            // FrmClientChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(931, 801);
            this.Controls.Add(this.btnSwitchMode);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblRecherche);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtListeMessage);
            this.Controls.Add(this.btnEnvoyer);
            this.Controls.Add(this.txbEcrireMessage);
            this.Controls.Add(this.lstListeProjet);
            this.Controls.Add(this.lblChat);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClientChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recherche";
            this.Load += new System.EventHandler(this.FrmClientChat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblChat;
        private System.Windows.Forms.ListBox lstListeProjet;
        private System.Windows.Forms.Button btnEnvoyer;
        private System.Windows.Forms.TextBox txbEcrireMessage;
        private System.Windows.Forms.TextBox txtListeMessage;
        private System.Windows.Forms.Label lblRecherche;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnSwitchMode;
    }
}