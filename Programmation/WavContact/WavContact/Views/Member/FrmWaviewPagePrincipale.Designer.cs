
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWaviewPagePrincipale));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnSwitchMode = new System.Windows.Forms.Button();
            this.lstListeClients = new System.Windows.Forms.ListBox();
            this.lblClients = new System.Windows.Forms.Label();
            this.mtcDate = new System.Windows.Forms.MonthCalendar();
            this.lblProjets = new System.Windows.Forms.Label();
            this.lstListeProjets = new System.Windows.Forms.ListBox();
            this.btnChats = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvModification = new System.Windows.Forms.DataGridView();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Projet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Heure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblActivite = new System.Windows.Forms.Label();
            this.btnParametre = new System.Windows.Forms.Button();
            this.btnProjet = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModification)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(1007, 20);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 48);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(774, 20);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(169, 48);
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
            this.lblWelcome.Location = new System.Drawing.Point(3, 16);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(179, 45);
            this.lblWelcome.TabIndex = 6;
            this.lblWelcome.Text = "Hello XXX !";
            // 
            // btnSwitchMode
            // 
            this.btnSwitchMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSwitchMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitchMode.ForeColor = System.Drawing.Color.White;
            this.btnSwitchMode.Location = new System.Drawing.Point(682, 20);
            this.btnSwitchMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSwitchMode.Name = "btnSwitchMode";
            this.btnSwitchMode.Size = new System.Drawing.Size(84, 48);
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
            this.lstListeClients.ItemHeight = 25;
            this.lstListeClients.Items.AddRange(new object[] {
            "Client 1",
            "Client 2",
            "Client 3"});
            this.lstListeClients.Location = new System.Drawing.Point(13, 135);
            this.lstListeClients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstListeClients.Name = "lstListeClients";
            this.lstListeClients.Size = new System.Drawing.Size(352, 352);
            this.lstListeClients.TabIndex = 8;
            this.lstListeClients.SelectedIndexChanged += new System.EventHandler(this.lbClients_SelectedIndexChanged);
            // 
            // lblClients
            // 
            this.lblClients.AutoSize = true;
            this.lblClients.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClients.ForeColor = System.Drawing.Color.White;
            this.lblClients.Location = new System.Drawing.Point(3, 91);
            this.lblClients.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClients.Name = "lblClients";
            this.lblClients.Size = new System.Drawing.Size(112, 34);
            this.lblClients.TabIndex = 9;
            this.lblClients.Text = "Clients";
            // 
            // mtcDate
            // 
            this.mtcDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtcDate.BackColor = System.Drawing.Color.Black;
            this.mtcDate.ForeColor = System.Drawing.Color.White;
            this.mtcDate.Location = new System.Drawing.Point(745, 230);
            this.mtcDate.Margin = new System.Windows.Forms.Padding(13, 15, 13, 15);
            this.mtcDate.MaxSelectionCount = 1;
            this.mtcDate.Name = "mtcDate";
            this.mtcDate.TabIndex = 10;
            this.mtcDate.TitleBackColor = System.Drawing.Color.Black;
            this.mtcDate.TitleForeColor = System.Drawing.Color.White;
            this.mtcDate.TrailingForeColor = System.Drawing.Color.White;
            // 
            // lblProjets
            // 
            this.lblProjets.AutoSize = true;
            this.lblProjets.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProjets.ForeColor = System.Drawing.Color.White;
            this.lblProjets.Location = new System.Drawing.Point(373, 91);
            this.lblProjets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProjets.Name = "lblProjets";
            this.lblProjets.Size = new System.Drawing.Size(113, 34);
            this.lblProjets.TabIndex = 12;
            this.lblProjets.Text = "Projets";
            // 
            // lstListeProjets
            // 
            this.lstListeProjets.BackColor = System.Drawing.Color.Black;
            this.lstListeProjets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstListeProjets.ForeColor = System.Drawing.Color.White;
            this.lstListeProjets.FormattingEnabled = true;
            this.lstListeProjets.ItemHeight = 25;
            this.lstListeProjets.Location = new System.Drawing.Point(379, 135);
            this.lstListeProjets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstListeProjets.Name = "lstListeProjets";
            this.lstListeProjets.Size = new System.Drawing.Size(352, 352);
            this.lstListeProjets.TabIndex = 13;
            this.lstListeProjets.SelectedIndexChanged += new System.EventHandler(this.lbProjets_SelectedIndexChanged);
            // 
            // btnChats
            // 
            this.btnChats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChats.ForeColor = System.Drawing.Color.White;
            this.btnChats.Location = new System.Drawing.Point(907, 135);
            this.btnChats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChats.Name = "btnChats";
            this.btnChats.Size = new System.Drawing.Size(150, 86);
            this.btnChats.TabIndex = 14;
            this.btnChats.Text = "Chats";
            this.btnChats.UseVisualStyleBackColor = true;
            this.btnChats.Click += new System.EventHandler(this.btnChats_Click);
            // 
            // dgvModification
            // 
            this.dgvModification.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvModification.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvModification.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvModification.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvModification.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvModification.BackgroundColor = System.Drawing.Color.Black;
            this.dgvModification.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvModification.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvModification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModification.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Client,
            this.Projet,
            this.Modification,
            this.Qui,
            this.Date,
            this.Heure});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvModification.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvModification.GridColor = System.Drawing.Color.White;
            this.dgvModification.Location = new System.Drawing.Point(13, 566);
            this.dgvModification.Name = "dgvModification";
            this.dgvModification.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvModification.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvModification.RowHeadersWidth = 70;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvModification.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvModification.RowTemplate.Height = 33;
            this.dgvModification.Size = new System.Drawing.Size(1044, 222);
            this.dgvModification.TabIndex = 15;
            // 
            // Client
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.Client.DefaultCellStyle = dataGridViewCellStyle9;
            this.Client.HeaderText = "Client";
            this.Client.MinimumWidth = 8;
            this.Client.Name = "Client";
            this.Client.ReadOnly = true;
            // 
            // Projet
            // 
            this.Projet.HeaderText = "Projet";
            this.Projet.MinimumWidth = 8;
            this.Projet.Name = "Projet";
            this.Projet.ReadOnly = true;
            // 
            // Modification
            // 
            this.Modification.HeaderText = "Modification";
            this.Modification.MinimumWidth = 8;
            this.Modification.Name = "Modification";
            this.Modification.ReadOnly = true;
            // 
            // Qui
            // 
            this.Qui.HeaderText = "Qui";
            this.Qui.MinimumWidth = 8;
            this.Qui.Name = "Qui";
            this.Qui.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 8;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Heure
            // 
            this.Heure.HeaderText = "Heure";
            this.Heure.MinimumWidth = 8;
            this.Heure.Name = "Heure";
            this.Heure.ReadOnly = true;
            // 
            // lblActivite
            // 
            this.lblActivite.AutoSize = true;
            this.lblActivite.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActivite.ForeColor = System.Drawing.Color.White;
            this.lblActivite.Location = new System.Drawing.Point(13, 529);
            this.lblActivite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActivite.Name = "lblActivite";
            this.lblActivite.Size = new System.Drawing.Size(135, 34);
            this.lblActivite.TabIndex = 17;
            this.lblActivite.Text = "Activités";
            // 
            // btnParametre
            // 
            this.btnParametre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnParametre.BackColor = System.Drawing.Color.Transparent;
            this.btnParametre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParametre.ForeColor = System.Drawing.Color.Transparent;
            this.btnParametre.Image = ((System.Drawing.Image)(resources.GetObject("btnParametre.Image")));
            this.btnParametre.Location = new System.Drawing.Point(951, 20);
            this.btnParametre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnParametre.Name = "btnParametre";
            this.btnParametre.Size = new System.Drawing.Size(48, 48);
            this.btnParametre.TabIndex = 18;
            this.btnParametre.UseVisualStyleBackColor = false;
            this.btnParametre.Click += new System.EventHandler(this.btnParametre_Click);
            // 
            // btnProjet
            // 
            this.btnProjet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProjet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjet.ForeColor = System.Drawing.Color.White;
            this.btnProjet.Location = new System.Drawing.Point(550, 91);
            this.btnProjet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProjet.Name = "btnProjet";
            this.btnProjet.Size = new System.Drawing.Size(181, 34);
            this.btnProjet.TabIndex = 19;
            this.btnProjet.Text = "Ouvrir le projet";
            this.btnProjet.UseVisualStyleBackColor = true;
            this.btnProjet.Click += new System.EventHandler(this.btnProjet_Click);
            // 
            // btnClient
            // 
            this.btnClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.ForeColor = System.Drawing.Color.White;
            this.btnClient.Location = new System.Drawing.Point(184, 91);
            this.btnClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(181, 34);
            this.btnClient.TabIndex = 20;
            this.btnClient.Text = "Ouvrir la fiche client";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnStock
            // 
            this.btnStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.Location = new System.Drawing.Point(745, 135);
            this.btnStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(150, 86);
            this.btnStock.TabIndex = 21;
            this.btnStock.Text = "Gérer les stocks";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // FrmWaviewPagePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1075, 810);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnProjet);
            this.Controls.Add(this.btnParametre);
            this.Controls.Add(this.lblActivite);
            this.Controls.Add(this.dgvModification);
            this.Controls.Add(this.btnChats);
            this.Controls.Add(this.lstListeProjets);
            this.Controls.Add(this.lblProjets);
            this.Controls.Add(this.mtcDate);
            this.Controls.Add(this.lblClients);
            this.Controls.Add(this.lstListeClients);
            this.Controls.Add(this.btnSwitchMode);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmWaviewPagePrincipale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "c";
            this.Load += new System.EventHandler(this.FrmWaviewMember_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModification)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnSwitchMode;
        private System.Windows.Forms.ListBox lstListeClients;
        private System.Windows.Forms.Label lblClients;
        private System.Windows.Forms.MonthCalendar mtcDate;
        private System.Windows.Forms.Label lblProjets;
        private System.Windows.Forms.ListBox lstListeProjets;
        private System.Windows.Forms.Button btnChats;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvModification;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Projet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modification;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qui;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Heure;
        private System.Windows.Forms.Label lblActivite;
        private System.Windows.Forms.Button btnParametre;
        private System.Windows.Forms.Button btnProjet;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnStock;
    }
}