
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.picParametre = new System.Windows.Forms.PictureBox();
            this.lblActivite = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picParametre)).BeginInit();
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
            this.btnLogout.Location = new System.Drawing.Point(776, 20);
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
            this.lblWelcome.Location = new System.Drawing.Point(17, 15);
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
            this.btnSwitchMode.Location = new System.Drawing.Point(684, 20);
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
            this.lstListeClients.Location = new System.Drawing.Point(13, 127);
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
            this.lblClients.Location = new System.Drawing.Point(17, 88);
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
            this.mtcDate.Location = new System.Drawing.Point(745, 222);
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
            this.lblProjets.Location = new System.Drawing.Point(379, 88);
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
            this.lstListeProjets.Location = new System.Drawing.Point(379, 127);
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
            this.btnChats.Location = new System.Drawing.Point(745, 127);
            this.btnChats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChats.Name = "btnChats";
            this.btnChats.Size = new System.Drawing.Size(312, 86);
            this.btnChats.TabIndex = 14;
            this.btnChats.Text = "Chats";
            this.btnChats.UseVisualStyleBackColor = true;
            this.btnChats.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvModification
            // 
            this.dgvModification.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvModification.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvModification.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvModification.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvModification.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvModification.BackgroundColor = System.Drawing.Color.Black;
            this.dgvModification.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvModification.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvModification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModification.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Client,
            this.Projet,
            this.Modification,
            this.Qui,
            this.Date,
            this.Heure});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvModification.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvModification.GridColor = System.Drawing.Color.White;
            this.dgvModification.Location = new System.Drawing.Point(13, 558);
            this.dgvModification.Name = "dgvModification";
            this.dgvModification.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvModification.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvModification.RowHeadersWidth = 70;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvModification.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvModification.RowTemplate.Height = 33;
            this.dgvModification.Size = new System.Drawing.Size(1044, 145);
            this.dgvModification.TabIndex = 15;
            // 
            // Client
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Client.DefaultCellStyle = dataGridViewCellStyle3;
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
            // picParametre
            // 
            this.picParametre.Image = ((System.Drawing.Image)(resources.GetObject("picParametre.Image")));
            this.picParametre.Location = new System.Drawing.Point(952, 20);
            this.picParametre.Name = "picParametre";
            this.picParametre.Size = new System.Drawing.Size(48, 48);
            this.picParametre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picParametre.TabIndex = 16;
            this.picParametre.TabStop = false;
            this.picParametre.Click += new System.EventHandler(this.picParametre_Click);
            // 
            // lblActivite
            // 
            this.lblActivite.AutoSize = true;
            this.lblActivite.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActivite.ForeColor = System.Drawing.Color.White;
            this.lblActivite.Location = new System.Drawing.Point(13, 521);
            this.lblActivite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActivite.Name = "lblActivite";
            this.lblActivite.Size = new System.Drawing.Size(135, 34);
            this.lblActivite.TabIndex = 17;
            this.lblActivite.Text = "Activités";
            // 
            // FrmWaviewPagePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1075, 715);
            this.Controls.Add(this.lblActivite);
            this.Controls.Add(this.picParametre);
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
            ((System.ComponentModel.ISupportInitialize)(this.picParametre)).EndInit();
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
        private System.Windows.Forms.PictureBox picParametre;
        private System.Windows.Forms.Label lblActivite;
    }
}