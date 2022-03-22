
namespace WavContact.Views.Client
{
    partial class FrmClientPagePrincipale
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
            this.btnSwitchMode = new System.Windows.Forms.Button();
            this.lblMenuPrincipal = new System.Windows.Forms.Label();
            this.lstProjet = new System.Windows.Forms.ListBox();
            this.lblRecapProjet = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnChat = new System.Windows.Forms.Button();
            this.btnProjet = new System.Windows.Forms.Button();
            this.btnParametre = new System.Windows.Forms.Button();
            this.lblRdvClient = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSwitchMode
            // 
            this.btnSwitchMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitchMode.ForeColor = System.Drawing.Color.White;
            this.btnSwitchMode.Location = new System.Drawing.Point(766, 12);
            this.btnSwitchMode.Name = "btnSwitchMode";
            this.btnSwitchMode.Size = new System.Drawing.Size(178, 48);
            this.btnSwitchMode.TabIndex = 30;
            this.btnSwitchMode.Text = "Clair";
            this.btnSwitchMode.UseVisualStyleBackColor = true;
            this.btnSwitchMode.Click += new System.EventHandler(this.btnSwitchMode_Click);
            // 
            // lblMenuPrincipal
            // 
            this.lblMenuPrincipal.AutoSize = true;
            this.lblMenuPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.lblMenuPrincipal.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMenuPrincipal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMenuPrincipal.Location = new System.Drawing.Point(13, 128);
            this.lblMenuPrincipal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenuPrincipal.Name = "lblMenuPrincipal";
            this.lblMenuPrincipal.Size = new System.Drawing.Size(224, 55);
            this.lblMenuPrincipal.TabIndex = 31;
            this.lblMenuPrincipal.Text = "Bonjour X !";
            // 
            // lstProjet
            // 
            this.lstProjet.BackColor = System.Drawing.Color.Black;
            this.lstProjet.ForeColor = System.Drawing.Color.White;
            this.lstProjet.FormattingEnabled = true;
            this.lstProjet.ItemHeight = 25;
            this.lstProjet.Location = new System.Drawing.Point(13, 278);
            this.lstProjet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstProjet.Name = "lstProjet";
            this.lstProjet.Size = new System.Drawing.Size(310, 679);
            this.lstProjet.TabIndex = 32;
            // 
            // lblRecapProjet
            // 
            this.lblRecapProjet.AutoSize = true;
            this.lblRecapProjet.Location = new System.Drawing.Point(13, 248);
            this.lblRecapProjet.Name = "lblRecapProjet";
            this.lblRecapProjet.Size = new System.Drawing.Size(201, 25);
            this.lblRecapProjet.TabIndex = 33;
            this.lblRecapProjet.Text = "Récapitulatif des projets";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.Black;
            this.monthCalendar1.ForeColor = System.Drawing.Color.White;
            this.monthCalendar1.Location = new System.Drawing.Point(803, 278);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(13, 15, 13, 15);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 35;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(951, 12);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(178, 48);
            this.btnLogout.TabIndex = 37;
            this.btnLogout.Text = "Déconnexion";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnChat
            // 
            this.btnChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChat.ForeColor = System.Drawing.Color.White;
            this.btnChat.Location = new System.Drawing.Point(11, 12);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(178, 48);
            this.btnChat.TabIndex = 40;
            this.btnChat.Text = "Chat";
            this.btnChat.UseVisualStyleBackColor = true;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // btnProjet
            // 
            this.btnProjet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjet.ForeColor = System.Drawing.Color.White;
            this.btnProjet.Location = new System.Drawing.Point(195, 12);
            this.btnProjet.Name = "btnProjet";
            this.btnProjet.Size = new System.Drawing.Size(179, 48);
            this.btnProjet.TabIndex = 41;
            this.btnProjet.Text = "Projet";
            this.btnProjet.UseVisualStyleBackColor = true;
            this.btnProjet.Click += new System.EventHandler(this.btnProjet_Click);
            // 
            // btnParametre
            // 
            this.btnParametre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParametre.ForeColor = System.Drawing.Color.White;
            this.btnParametre.Location = new System.Drawing.Point(380, 12);
            this.btnParametre.Name = "btnParametre";
            this.btnParametre.Size = new System.Drawing.Size(178, 48);
            this.btnParametre.TabIndex = 42;
            this.btnParametre.Text = "Paramètre";
            this.btnParametre.UseVisualStyleBackColor = true;
            this.btnParametre.Click += new System.EventHandler(this.btnParametre_Click);
            // 
            // lblRdvClient
            // 
            this.lblRdvClient.AutoSize = true;
            this.lblRdvClient.Location = new System.Drawing.Point(803, 248);
            this.lblRdvClient.Name = "lblRdvClient";
            this.lblRdvClient.Size = new System.Drawing.Size(226, 25);
            this.lblRdvClient.TabIndex = 43;
            this.lblRdvClient.Text = "Vos prochains rendez-vous";
            // 
            // FrmClientPagePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1143, 988);
            this.Controls.Add(this.lblRdvClient);
            this.Controls.Add(this.btnParametre);
            this.Controls.Add(this.btnProjet);
            this.Controls.Add(this.btnChat);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lblRecapProjet);
            this.Controls.Add(this.lstProjet);
            this.Controls.Add(this.lblMenuPrincipal);
            this.Controls.Add(this.btnSwitchMode);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmClientPagePrincipale";
            this.Text = "Waview Client";
            this.Load += new System.EventHandler(this.FrmClientPagePrincipale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSwitchMode;
        private System.Windows.Forms.Label lblMenuPrincipal;
        private System.Windows.Forms.ListBox lstProjet;
        private System.Windows.Forms.Label lblRecapProjet;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnChat;
        private System.Windows.Forms.Button btnProjet;
        private System.Windows.Forms.Button btnParametre;
        private System.Windows.Forms.Label lblRdvClient;
    }
}