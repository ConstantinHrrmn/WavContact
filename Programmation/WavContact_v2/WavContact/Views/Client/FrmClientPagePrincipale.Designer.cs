
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
            this.btnSwitchMode.Location = new System.Drawing.Point(622, 7);
            this.btnSwitchMode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSwitchMode.Name = "btnSwitchMode";
            this.btnSwitchMode.Size = new System.Drawing.Size(45, 29);
            this.btnSwitchMode.TabIndex = 30;
            this.btnSwitchMode.Text = "Light";
            this.btnSwitchMode.UseVisualStyleBackColor = true;
            this.btnSwitchMode.Click += new System.EventHandler(this.btnSwitchMode_Click);
            // 
            // lblMenuPrincipal
            // 
            this.lblMenuPrincipal.AutoSize = true;
            this.lblMenuPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.lblMenuPrincipal.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMenuPrincipal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMenuPrincipal.Location = new System.Drawing.Point(9, 77);
            this.lblMenuPrincipal.Name = "lblMenuPrincipal";
            this.lblMenuPrincipal.Size = new System.Drawing.Size(148, 37);
            this.lblMenuPrincipal.TabIndex = 31;
            this.lblMenuPrincipal.Text = "Bonjour X !";
            // 
            // lstProjet
            // 
            this.lstProjet.BackColor = System.Drawing.Color.Black;
            this.lstProjet.ForeColor = System.Drawing.Color.White;
            this.lstProjet.FormattingEnabled = true;
            this.lstProjet.ItemHeight = 15;
            this.lstProjet.Location = new System.Drawing.Point(9, 167);
            this.lstProjet.Name = "lstProjet";
            this.lstProjet.Size = new System.Drawing.Size(218, 409);
            this.lstProjet.TabIndex = 32;
            // 
            // lblRecapProjet
            // 
            this.lblRecapProjet.AutoSize = true;
            this.lblRecapProjet.Location = new System.Drawing.Point(9, 149);
            this.lblRecapProjet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecapProjet.Name = "lblRecapProjet";
            this.lblRecapProjet.Size = new System.Drawing.Size(133, 15);
            this.lblRecapProjet.TabIndex = 33;
            this.lblRecapProjet.Text = "Récapitulatif des projets";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.Black;
            this.monthCalendar1.ForeColor = System.Drawing.Color.White;
            this.monthCalendar1.Location = new System.Drawing.Point(562, 167);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 35;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(672, 7);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(118, 29);
            this.btnLogout.TabIndex = 37;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnChat
            // 
            this.btnChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChat.ForeColor = System.Drawing.Color.White;
            this.btnChat.Location = new System.Drawing.Point(8, 7);
            this.btnChat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(118, 29);
            this.btnChat.TabIndex = 40;
            this.btnChat.Text = "Chat";
            this.btnChat.UseVisualStyleBackColor = true;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // btnProjet
            // 
            this.btnProjet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjet.ForeColor = System.Drawing.Color.White;
            this.btnProjet.Location = new System.Drawing.Point(131, 7);
            this.btnProjet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProjet.Name = "btnProjet";
            this.btnProjet.Size = new System.Drawing.Size(118, 29);
            this.btnProjet.TabIndex = 41;
            this.btnProjet.Text = "Projet";
            this.btnProjet.UseVisualStyleBackColor = true;
            this.btnProjet.Click += new System.EventHandler(this.btnProjet_Click);
            // 
            // btnParametre
            // 
            this.btnParametre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParametre.ForeColor = System.Drawing.Color.White;
            this.btnParametre.Location = new System.Drawing.Point(253, 7);
            this.btnParametre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnParametre.Name = "btnParametre";
            this.btnParametre.Size = new System.Drawing.Size(118, 29);
            this.btnParametre.TabIndex = 42;
            this.btnParametre.Text = "Paramètre";
            this.btnParametre.UseVisualStyleBackColor = true;
            this.btnParametre.Click += new System.EventHandler(this.btnParametre_Click);
            // 
            // lblRdvClient
            // 
            this.lblRdvClient.AutoSize = true;
            this.lblRdvClient.Location = new System.Drawing.Point(562, 149);
            this.lblRdvClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRdvClient.Name = "lblRdvClient";
            this.lblRdvClient.Size = new System.Drawing.Size(148, 15);
            this.lblRdvClient.TabIndex = 43;
            this.lblRdvClient.Text = "Vos prochains rendez-vous";
            // 
            // FrmClientPagePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 593);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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