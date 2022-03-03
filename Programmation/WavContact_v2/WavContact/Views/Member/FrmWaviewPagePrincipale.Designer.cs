﻿
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnSwitchMode = new System.Windows.Forms.Button();
            this.lstListeClients = new System.Windows.Forms.ListBox();
            this.lblClients = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblProjets = new System.Windows.Forms.Label();
            this.lstListeProjets = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnNewClient = new System.Windows.Forms.Button();
            this.btnNewProject = new System.Windows.Forms.Button();
            this.btnInfosClients = new System.Windows.Forms.Button();
            this.btnGestionMateriel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(1070, 9);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(118, 29);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(12, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(121, 30);
            this.lblWelcome.TabIndex = 6;
            this.lblWelcome.Text = "Hello XXX !";
            // 
            // btnSwitchMode
            // 
            this.btnSwitchMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSwitchMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitchMode.ForeColor = System.Drawing.Color.White;
            this.btnSwitchMode.Location = new System.Drawing.Point(1005, 9);
            this.btnSwitchMode.Name = "btnSwitchMode";
            this.btnSwitchMode.Size = new System.Drawing.Size(59, 29);
            this.btnSwitchMode.TabIndex = 7;
            this.btnSwitchMode.Text = "Light";
            this.btnSwitchMode.UseVisualStyleBackColor = true;
            this.btnSwitchMode.Click += new System.EventHandler(this.btnSwitchMode_Click);
            // 
            // lstListeClients
            // 
            this.lstListeClients.BackColor = System.Drawing.Color.Black;
            this.lstListeClients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstListeClients.ForeColor = System.Drawing.Color.White;
            this.lstListeClients.FormattingEnabled = true;
            this.lstListeClients.ItemHeight = 15;
            this.lstListeClients.Items.AddRange(new object[] {
            "Client 1",
            "Client 2",
            "Client 3"});
            this.lstListeClients.Location = new System.Drawing.Point(9, 76);
            this.lstListeClients.Name = "lstListeClients";
            this.lstListeClients.Size = new System.Drawing.Size(247, 662);
            this.lstListeClients.TabIndex = 8;
            this.lstListeClients.SelectedIndexChanged += new System.EventHandler(this.lbClients_SelectedIndexChanged);
            // 
            // lblClients
            // 
            this.lblClients.AutoSize = true;
            this.lblClients.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClients.ForeColor = System.Drawing.Color.White;
            this.lblClients.Location = new System.Drawing.Point(12, 53);
            this.lblClients.Name = "lblClients";
            this.lblClients.Size = new System.Drawing.Size(74, 22);
            this.lblClients.TabIndex = 9;
            this.lblClients.Text = "Clients";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.BackColor = System.Drawing.Color.Black;
            this.monthCalendar1.ForeColor = System.Drawing.Color.White;
            this.monthCalendar1.Location = new System.Drawing.Point(961, 606);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 10;
            // 
            // lblProjets
            // 
            this.lblProjets.AutoSize = true;
            this.lblProjets.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProjets.ForeColor = System.Drawing.Color.White;
            this.lblProjets.Location = new System.Drawing.Point(265, 53);
            this.lblProjets.Name = "lblProjets";
            this.lblProjets.Size = new System.Drawing.Size(76, 22);
            this.lblProjets.TabIndex = 12;
            this.lblProjets.Text = "Projets";
            // 
            // lstListeProjets
            // 
            this.lstListeProjets.BackColor = System.Drawing.Color.Black;
            this.lstListeProjets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstListeProjets.ForeColor = System.Drawing.Color.White;
            this.lstListeProjets.FormattingEnabled = true;
            this.lstListeProjets.ItemHeight = 15;
            this.lstListeProjets.Location = new System.Drawing.Point(265, 76);
            this.lstListeProjets.Name = "lstListeProjets";
            this.lstListeProjets.Size = new System.Drawing.Size(247, 662);
            this.lstListeProjets.TabIndex = 13;
            this.lstListeProjets.SelectedIndexChanged += new System.EventHandler(this.lbProjets_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(881, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "Chats";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNewClient
            // 
            this.btnNewClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewClient.ForeColor = System.Drawing.Color.White;
            this.btnNewClient.Location = new System.Drawing.Point(172, 744);
            this.btnNewClient.Name = "btnNewClient";
            this.btnNewClient.Size = new System.Drawing.Size(84, 29);
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
            this.btnNewProject.Location = new System.Drawing.Point(428, 744);
            this.btnNewProject.Name = "btnNewProject";
            this.btnNewProject.Size = new System.Drawing.Size(84, 29);
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
            this.btnInfosClients.Location = new System.Drawing.Point(9, 744);
            this.btnInfosClients.Name = "btnInfosClients";
            this.btnInfosClients.Size = new System.Drawing.Size(157, 29);
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
            this.btnGestionMateriel.Location = new System.Drawing.Point(692, 9);
            this.btnGestionMateriel.Name = "btnGestionMateriel";
            this.btnGestionMateriel.Size = new System.Drawing.Size(183, 29);
            this.btnGestionMateriel.TabIndex = 20;
            this.btnGestionMateriel.Text = "Gestion du matériel";
            this.btnGestionMateriel.UseVisualStyleBackColor = true;
            this.btnGestionMateriel.Click += new System.EventHandler(this.btnGestionMateriel_Click);
            // 
            // FrmWaviewPagePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1200, 784);
            this.Controls.Add(this.btnGestionMateriel);
            this.Controls.Add(this.btnInfosClients);
            this.Controls.Add(this.btnNewProject);
            this.Controls.Add(this.btnNewClient);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstListeProjets);
            this.Controls.Add(this.lblProjets);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lblClients);
            this.Controls.Add(this.lstListeClients);
            this.Controls.Add(this.btnSwitchMode);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnLogout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblProjets;
        private System.Windows.Forms.ListBox lstListeProjets;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnNewClient;
        private System.Windows.Forms.Button btnNewProject;
        private System.Windows.Forms.Button btnInfosClients;
        private System.Windows.Forms.Button btnGestionMateriel;
    }
}