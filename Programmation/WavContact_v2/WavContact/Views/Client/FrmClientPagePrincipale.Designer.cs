
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
            this.components = new System.ComponentModel.Container();
            this.btnSwitchMode = new System.Windows.Forms.Button();
            this.lblMenuPrincipal = new System.Windows.Forms.Label();
            this.lstProjet = new System.Windows.Forms.ListBox();
            this.lblRecapProjet = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnChat = new System.Windows.Forms.Button();
            this.TimerCheckNewMessages = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnSwitchMode
            // 
            this.btnSwitchMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitchMode.ForeColor = System.Drawing.Color.White;
            this.btnSwitchMode.Location = new System.Drawing.Point(437, 14);
            this.btnSwitchMode.Margin = new System.Windows.Forms.Padding(4);
            this.btnSwitchMode.Name = "btnSwitchMode";
            this.btnSwitchMode.Size = new System.Drawing.Size(214, 58);
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
            this.lblMenuPrincipal.Location = new System.Drawing.Point(16, 154);
            this.lblMenuPrincipal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMenuPrincipal.Name = "lblMenuPrincipal";
            this.lblMenuPrincipal.Size = new System.Drawing.Size(263, 65);
            this.lblMenuPrincipal.TabIndex = 31;
            this.lblMenuPrincipal.Text = "Bonjour X !";
            // 
            // lstProjet
            // 
            this.lstProjet.BackColor = System.Drawing.Color.Black;
            this.lstProjet.ForeColor = System.Drawing.Color.White;
            this.lstProjet.FormattingEnabled = true;
            this.lstProjet.ItemHeight = 30;
            this.lstProjet.Location = new System.Drawing.Point(16, 334);
            this.lstProjet.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lstProjet.Name = "lstProjet";
            this.lstProjet.Size = new System.Drawing.Size(371, 814);
            this.lstProjet.TabIndex = 32;
            this.lstProjet.SelectedIndexChanged += new System.EventHandler(this.lstProjet_SelectedIndexChanged);
            // 
            // lblRecapProjet
            // 
            this.lblRecapProjet.AutoSize = true;
            this.lblRecapProjet.Location = new System.Drawing.Point(16, 298);
            this.lblRecapProjet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecapProjet.Name = "lblRecapProjet";
            this.lblRecapProjet.Size = new System.Drawing.Size(235, 30);
            this.lblRecapProjet.TabIndex = 33;
            this.lblRecapProjet.Text = "Récapitulatif des projets";
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(660, 14);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(214, 58);
            this.btnLogout.TabIndex = 37;
            this.btnLogout.Text = "Déconnexion";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnChat
            // 
            this.btnChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChat.ForeColor = System.Drawing.Color.White;
            this.btnChat.Location = new System.Drawing.Point(13, 14);
            this.btnChat.Margin = new System.Windows.Forms.Padding(4);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(374, 58);
            this.btnChat.TabIndex = 40;
            this.btnChat.Text = "Chat";
            this.btnChat.UseVisualStyleBackColor = true;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // TimerCheckNewMessages
            // 
            this.TimerCheckNewMessages.Enabled = true;
            this.TimerCheckNewMessages.Interval = 2500;
            this.TimerCheckNewMessages.Tick += new System.EventHandler(this.TimerCheckNewMessages_Tick);
            // 
            // FrmClientPagePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(889, 1186);
            this.Controls.Add(this.btnChat);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblRecapProjet);
            this.Controls.Add(this.lstProjet);
            this.Controls.Add(this.lblMenuPrincipal);
            this.Controls.Add(this.btnSwitchMode);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnChat;
        private System.Windows.Forms.Timer TimerCheckNewMessages;
    }
}