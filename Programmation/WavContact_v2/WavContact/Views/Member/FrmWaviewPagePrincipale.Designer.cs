
namespace WavContact.Views
{
    partial class FrmWaviewPagePrincipale
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnSwitchMode = new System.Windows.Forms.Button();
            this.lstListeClients = new System.Windows.Forms.ListBox();
            this.lblClients = new System.Windows.Forms.Label();
            this.lblProjets = new System.Windows.Forms.Label();
            this.lstListeProjets = new System.Windows.Forms.ListBox();
            this.btnChats = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnNewClient = new System.Windows.Forms.Button();
            this.btnNewProject = new System.Windows.Forms.Button();
            this.btnInfosClients = new System.Windows.Forms.Button();
            this.btnGestionMateriel = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.lbActivity = new System.Windows.Forms.ListBox();
            this.ActivityTimer = new System.Windows.Forms.Timer(this.components);
            this.MessageTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(1827, 18);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(214, 58);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Déconnexion";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(21, 18);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(206, 51);
            this.lblWelcome.TabIndex = 6;
            this.lblWelcome.Text = "Hello XXX !";
            // 
            // btnSwitchMode
            // 
            this.btnSwitchMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSwitchMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitchMode.ForeColor = System.Drawing.Color.White;
            this.btnSwitchMode.Location = new System.Drawing.Point(1615, 18);
            this.btnSwitchMode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSwitchMode.Name = "btnSwitchMode";
            this.btnSwitchMode.Size = new System.Drawing.Size(202, 58);
            this.btnSwitchMode.TabIndex = 7;
            this.btnSwitchMode.Text = "Clair";
            this.btnSwitchMode.UseVisualStyleBackColor = true;
            this.btnSwitchMode.Click += new System.EventHandler(this.btnSwitchMode_Click);
            // 
            // lstListeClients
            // 
            this.lstListeClients.BackColor = System.Drawing.Color.Black;
            this.lstListeClients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstListeClients.ForeColor = System.Drawing.Color.White;
            this.lstListeClients.FormattingEnabled = true;
            this.lstListeClients.ItemHeight = 30;
            this.lstListeClients.Items.AddRange(new object[] {
            "Client 1",
            "Client 2",
            "Client 3"});
            this.lstListeClients.Location = new System.Drawing.Point(15, 152);
            this.lstListeClients.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lstListeClients.Name = "lstListeClients";
            this.lstListeClients.Size = new System.Drawing.Size(422, 1322);
            this.lstListeClients.TabIndex = 8;
            this.lstListeClients.SelectedIndexChanged += new System.EventHandler(this.lbClients_SelectedIndexChanged);
            // 
            // lblClients
            // 
            this.lblClients.AutoSize = true;
            this.lblClients.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClients.ForeColor = System.Drawing.Color.White;
            this.lblClients.Location = new System.Drawing.Point(21, 106);
            this.lblClients.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblClients.Name = "lblClients";
            this.lblClients.Size = new System.Drawing.Size(129, 40);
            this.lblClients.TabIndex = 9;
            this.lblClients.Text = "Clients";
            // 
            // lblProjets
            // 
            this.lblProjets.AutoSize = true;
            this.lblProjets.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProjets.ForeColor = System.Drawing.Color.White;
            this.lblProjets.Location = new System.Drawing.Point(454, 106);
            this.lblProjets.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblProjets.Name = "lblProjets";
            this.lblProjets.Size = new System.Drawing.Size(134, 40);
            this.lblProjets.TabIndex = 12;
            this.lblProjets.Text = "Projets";
            // 
            // lstListeProjets
            // 
            this.lstListeProjets.BackColor = System.Drawing.Color.Black;
            this.lstListeProjets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstListeProjets.ForeColor = System.Drawing.Color.White;
            this.lstListeProjets.FormattingEnabled = true;
            this.lstListeProjets.ItemHeight = 30;
            this.lstListeProjets.Location = new System.Drawing.Point(454, 152);
            this.lstListeProjets.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lstListeProjets.Name = "lstListeProjets";
            this.lstListeProjets.Size = new System.Drawing.Size(422, 1322);
            this.lstListeProjets.TabIndex = 13;
            this.lstListeProjets.SelectedIndexChanged += new System.EventHandler(this.lbProjets_SelectedIndexChanged);
            // 
            // btnChats
            // 
            this.btnChats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChats.ForeColor = System.Drawing.Color.White;
            this.btnChats.Location = new System.Drawing.Point(1402, 16);
            this.btnChats.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnChats.Name = "btnChats";
            this.btnChats.Size = new System.Drawing.Size(202, 58);
            this.btnChats.TabIndex = 14;
            this.btnChats.Text = "Chats";
            this.btnChats.UseVisualStyleBackColor = true;
            this.btnChats.Click += new System.EventHandler(this.btnChats_Click);
            // 
            // btnNewClient
            // 
            this.btnNewClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewClient.ForeColor = System.Drawing.Color.White;
            this.btnNewClient.Location = new System.Drawing.Point(295, 1488);
            this.btnNewClient.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnNewClient.Name = "btnNewClient";
            this.btnNewClient.Size = new System.Drawing.Size(144, 58);
            this.btnNewClient.TabIndex = 17;
            this.btnNewClient.Text = "Nouveau";
            this.btnNewClient.UseVisualStyleBackColor = true;
            this.btnNewClient.Click += new System.EventHandler(this.btnNewClient_Click);
            // 
            // btnNewProject
            // 
            this.btnNewProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewProject.Enabled = false;
            this.btnNewProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewProject.ForeColor = System.Drawing.Color.White;
            this.btnNewProject.Location = new System.Drawing.Point(734, 1488);
            this.btnNewProject.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnNewProject.Name = "btnNewProject";
            this.btnNewProject.Size = new System.Drawing.Size(144, 58);
            this.btnNewProject.TabIndex = 18;
            this.btnNewProject.Text = "Nouveau";
            this.btnNewProject.UseVisualStyleBackColor = true;
            this.btnNewProject.Click += new System.EventHandler(this.btnNewProject_Click);
            // 
            // btnInfosClients
            // 
            this.btnInfosClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfosClients.Enabled = false;
            this.btnInfosClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfosClients.ForeColor = System.Drawing.Color.White;
            this.btnInfosClients.Location = new System.Drawing.Point(15, 1488);
            this.btnInfosClients.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnInfosClients.Name = "btnInfosClients";
            this.btnInfosClients.Size = new System.Drawing.Size(269, 58);
            this.btnInfosClients.TabIndex = 19;
            this.btnInfosClients.Text = "Informations";
            this.btnInfosClients.UseVisualStyleBackColor = true;
            this.btnInfosClients.Click += new System.EventHandler(this.btnInfosClients_Click);
            // 
            // btnGestionMateriel
            // 
            this.btnGestionMateriel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGestionMateriel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionMateriel.ForeColor = System.Drawing.Color.White;
            this.btnGestionMateriel.Location = new System.Drawing.Point(1179, 16);
            this.btnGestionMateriel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnGestionMateriel.Name = "btnGestionMateriel";
            this.btnGestionMateriel.Size = new System.Drawing.Size(214, 58);
            this.btnGestionMateriel.TabIndex = 20;
            this.btnGestionMateriel.Text = "Gestion du matériel";
            this.btnGestionMateriel.UseVisualStyleBackColor = true;
            this.btnGestionMateriel.Click += new System.EventHandler(this.btnGestionMateriel_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Location = new System.Drawing.Point(957, 16);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(214, 58);
            this.btnAdmin.TabIndex = 21;
            this.btnAdmin.Text = "Administration";
            this.btnAdmin.UseVisualStyleBackColor = true;
            // 
            // lbActivity
            // 
            this.lbActivity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbActivity.BackColor = System.Drawing.Color.Black;
            this.lbActivity.ForeColor = System.Drawing.Color.White;
            this.lbActivity.FormattingEnabled = true;
            this.lbActivity.ItemHeight = 30;
            this.lbActivity.Location = new System.Drawing.Point(890, 1020);
            this.lbActivity.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lbActivity.Name = "lbActivity";
            this.lbActivity.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbActivity.Size = new System.Drawing.Size(1153, 454);
            this.lbActivity.TabIndex = 22;
            // 
            // ActivityTimer
            // 
            this.ActivityTimer.Enabled = true;
            this.ActivityTimer.Interval = 15000;
            this.ActivityTimer.Tick += new System.EventHandler(this.ActivityTimer_Tick);
            // 
            // MessageTimer
            // 
            this.MessageTimer.Enabled = true;
            this.MessageTimer.Interval = 3000;
            this.MessageTimer.Tick += new System.EventHandler(this.MessageTimer_Tick);
            // 
            // FrmWaviewPagePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(2057, 1566);
            this.Controls.Add(this.lbActivity);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnGestionMateriel);
            this.Controls.Add(this.btnInfosClients);
            this.Controls.Add(this.btnNewProject);
            this.Controls.Add(this.btnNewClient);
            this.Controls.Add(this.btnChats);
            this.Controls.Add(this.lstListeProjets);
            this.Controls.Add(this.lblProjets);
            this.Controls.Add(this.lblClients);
            this.Controls.Add(this.lstListeClients);
            this.Controls.Add(this.btnSwitchMode);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnLogout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FrmWaviewPagePrincipale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Waview Membre";
            this.Load += new System.EventHandler(this.FrmWaviewMember_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnSwitchMode;
        private System.Windows.Forms.ListBox lstListeClients;
        private System.Windows.Forms.Label lblClients;
        private System.Windows.Forms.Label lblProjets;
        private System.Windows.Forms.ListBox lstListeProjets;
        private System.Windows.Forms.Button btnChats;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnNewClient;
        private System.Windows.Forms.Button btnNewProject;
        private System.Windows.Forms.Button btnInfosClients;
        private System.Windows.Forms.Button btnGestionMateriel;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.ListBox lbActivity;
        private System.Windows.Forms.Timer ActivityTimer;
        private System.Windows.Forms.Timer MessageTimer;
    }
}