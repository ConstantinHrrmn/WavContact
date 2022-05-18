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
            this.lbDay1 = new System.Windows.Forms.ListBox();
            this.lblDay1 = new System.Windows.Forms.Label();
            this.lblDay2 = new System.Windows.Forms.Label();
            this.lbDay2 = new System.Windows.Forms.ListBox();
            this.lbDay4 = new System.Windows.Forms.ListBox();
            this.lblDay4 = new System.Windows.Forms.Label();
            this.lbDay3 = new System.Windows.Forms.ListBox();
            this.lblDay3 = new System.Windows.Forms.Label();
            this.lbDay6 = new System.Windows.Forms.ListBox();
            this.lblDay6 = new System.Windows.Forms.Label();
            this.lbDay7 = new System.Windows.Forms.ListBox();
            this.lblDay7 = new System.Windows.Forms.Label();
            this.lbDay5 = new System.Windows.Forms.ListBox();
            this.lblDay5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.lbActivity.Location = new System.Drawing.Point(901, 1092);
            this.lbActivity.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lbActivity.Name = "lbActivity";
            this.lbActivity.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbActivity.Size = new System.Drawing.Size(1142, 454);
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
            // lbDay1
            // 
            this.lbDay1.BackColor = System.Drawing.Color.Black;
            this.lbDay1.ForeColor = System.Drawing.Color.White;
            this.lbDay1.FormattingEnabled = true;
            this.lbDay1.ItemHeight = 30;
            this.lbDay1.Location = new System.Drawing.Point(901, 206);
            this.lbDay1.Name = "lbDay1";
            this.lbDay1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbDay1.Size = new System.Drawing.Size(1140, 214);
            this.lbDay1.TabIndex = 0;
            // 
            // lblDay1
            // 
            this.lblDay1.AutoSize = true;
            this.lblDay1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDay1.ForeColor = System.Drawing.Color.White;
            this.lblDay1.Location = new System.Drawing.Point(901, 152);
            this.lblDay1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDay1.Name = "lblDay1";
            this.lblDay1.Size = new System.Drawing.Size(152, 51);
            this.lblDay1.TabIndex = 23;
            this.lblDay1.Text = "Demain";
            // 
            // lblDay2
            // 
            this.lblDay2.AutoSize = true;
            this.lblDay2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDay2.ForeColor = System.Drawing.Color.White;
            this.lblDay2.Location = new System.Drawing.Point(918, 449);
            this.lblDay2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDay2.Name = "lblDay2";
            this.lblDay2.Size = new System.Drawing.Size(100, 51);
            this.lblDay2.TabIndex = 24;
            this.lblDay2.Text = "xx.yy";
            // 
            // lbDay2
            // 
            this.lbDay2.BackColor = System.Drawing.Color.Black;
            this.lbDay2.ForeColor = System.Drawing.Color.White;
            this.lbDay2.FormattingEnabled = true;
            this.lbDay2.ItemHeight = 30;
            this.lbDay2.Location = new System.Drawing.Point(901, 503);
            this.lbDay2.Name = "lbDay2";
            this.lbDay2.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbDay2.Size = new System.Drawing.Size(352, 214);
            this.lbDay2.TabIndex = 25;
            // 
            // lbDay4
            // 
            this.lbDay4.BackColor = System.Drawing.Color.Black;
            this.lbDay4.ForeColor = System.Drawing.Color.White;
            this.lbDay4.FormattingEnabled = true;
            this.lbDay4.ItemHeight = 30;
            this.lbDay4.Location = new System.Drawing.Point(1689, 503);
            this.lbDay4.Name = "lbDay4";
            this.lbDay4.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbDay4.Size = new System.Drawing.Size(352, 214);
            this.lbDay4.TabIndex = 27;
            // 
            // lblDay4
            // 
            this.lblDay4.AutoSize = true;
            this.lblDay4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDay4.ForeColor = System.Drawing.Color.White;
            this.lblDay4.Location = new System.Drawing.Point(1706, 449);
            this.lblDay4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDay4.Name = "lblDay4";
            this.lblDay4.Size = new System.Drawing.Size(100, 51);
            this.lblDay4.TabIndex = 26;
            this.lblDay4.Text = "xx.yy";
            // 
            // lbDay3
            // 
            this.lbDay3.BackColor = System.Drawing.Color.Black;
            this.lbDay3.ForeColor = System.Drawing.Color.White;
            this.lbDay3.FormattingEnabled = true;
            this.lbDay3.ItemHeight = 30;
            this.lbDay3.Location = new System.Drawing.Point(1294, 503);
            this.lbDay3.Name = "lbDay3";
            this.lbDay3.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbDay3.Size = new System.Drawing.Size(352, 214);
            this.lbDay3.TabIndex = 29;
            // 
            // lblDay3
            // 
            this.lblDay3.AutoSize = true;
            this.lblDay3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDay3.ForeColor = System.Drawing.Color.White;
            this.lblDay3.Location = new System.Drawing.Point(1311, 449);
            this.lblDay3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDay3.Name = "lblDay3";
            this.lblDay3.Size = new System.Drawing.Size(100, 51);
            this.lblDay3.TabIndex = 28;
            this.lblDay3.Text = "xx.yy";
            // 
            // lbDay6
            // 
            this.lbDay6.BackColor = System.Drawing.Color.Black;
            this.lbDay6.ForeColor = System.Drawing.Color.White;
            this.lbDay6.FormattingEnabled = true;
            this.lbDay6.ItemHeight = 30;
            this.lbDay6.Location = new System.Drawing.Point(1294, 780);
            this.lbDay6.Name = "lbDay6";
            this.lbDay6.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbDay6.Size = new System.Drawing.Size(352, 214);
            this.lbDay6.TabIndex = 35;
            // 
            // lblDay6
            // 
            this.lblDay6.AutoSize = true;
            this.lblDay6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDay6.ForeColor = System.Drawing.Color.White;
            this.lblDay6.Location = new System.Drawing.Point(1311, 726);
            this.lblDay6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDay6.Name = "lblDay6";
            this.lblDay6.Size = new System.Drawing.Size(100, 51);
            this.lblDay6.TabIndex = 34;
            this.lblDay6.Text = "xx.yy";
            // 
            // lbDay7
            // 
            this.lbDay7.BackColor = System.Drawing.Color.Black;
            this.lbDay7.ForeColor = System.Drawing.Color.White;
            this.lbDay7.FormattingEnabled = true;
            this.lbDay7.ItemHeight = 30;
            this.lbDay7.Location = new System.Drawing.Point(1689, 780);
            this.lbDay7.Name = "lbDay7";
            this.lbDay7.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbDay7.Size = new System.Drawing.Size(352, 214);
            this.lbDay7.TabIndex = 33;
            // 
            // lblDay7
            // 
            this.lblDay7.AutoSize = true;
            this.lblDay7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDay7.ForeColor = System.Drawing.Color.White;
            this.lblDay7.Location = new System.Drawing.Point(1706, 726);
            this.lblDay7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDay7.Name = "lblDay7";
            this.lblDay7.Size = new System.Drawing.Size(100, 51);
            this.lblDay7.TabIndex = 32;
            this.lblDay7.Text = "xx.yy";
            // 
            // lbDay5
            // 
            this.lbDay5.BackColor = System.Drawing.Color.Black;
            this.lbDay5.ForeColor = System.Drawing.Color.White;
            this.lbDay5.FormattingEnabled = true;
            this.lbDay5.ItemHeight = 30;
            this.lbDay5.Location = new System.Drawing.Point(901, 780);
            this.lbDay5.Name = "lbDay5";
            this.lbDay5.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbDay5.Size = new System.Drawing.Size(352, 214);
            this.lbDay5.TabIndex = 31;
            // 
            // lblDay5
            // 
            this.lblDay5.AutoSize = true;
            this.lblDay5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDay5.ForeColor = System.Drawing.Color.White;
            this.lblDay5.Location = new System.Drawing.Point(918, 726);
            this.lblDay5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDay5.Name = "lblDay5";
            this.lblDay5.Size = new System.Drawing.Size(100, 51);
            this.lblDay5.TabIndex = 30;
            this.lblDay5.Text = "xx.yy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(901, 1035);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 51);
            this.label1.TabIndex = 36;
            this.label1.Text = "Activité";
            // 
            // FrmWaviewPagePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(2057, 1566);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDay6);
            this.Controls.Add(this.lblDay6);
            this.Controls.Add(this.lbDay7);
            this.Controls.Add(this.lblDay7);
            this.Controls.Add(this.lbDay5);
            this.Controls.Add(this.lblDay5);
            this.Controls.Add(this.lbDay3);
            this.Controls.Add(this.lblDay3);
            this.Controls.Add(this.lbDay4);
            this.Controls.Add(this.lblDay4);
            this.Controls.Add(this.lbDay2);
            this.Controls.Add(this.lblDay2);
            this.Controls.Add(this.lblDay1);
            this.Controls.Add(this.lbDay1);
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
        private System.Windows.Forms.ListBox lbDay1;
        private System.Windows.Forms.Label lblDay1;
        private System.Windows.Forms.Label lblDay2;
        private System.Windows.Forms.ListBox lbDay2;
        private System.Windows.Forms.ListBox lbDay4;
        private System.Windows.Forms.Label lblDay4;
        private System.Windows.Forms.ListBox lbDay3;
        private System.Windows.Forms.Label lblDay3;
        private System.Windows.Forms.ListBox lbDay6;
        private System.Windows.Forms.Label lblDay6;
        private System.Windows.Forms.ListBox lbDay7;
        private System.Windows.Forms.Label lblDay7;
        private System.Windows.Forms.ListBox lbDay5;
        private System.Windows.Forms.Label lblDay5;
        private System.Windows.Forms.Label label1;
    }
}