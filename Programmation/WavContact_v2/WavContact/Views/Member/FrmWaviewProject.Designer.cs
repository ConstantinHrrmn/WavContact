
namespace WavContact.Views.Member
{
    partial class FrmWaviewProject
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
            this.lbActivity = new System.Windows.Forms.ListBox();
            this.lbDocuments = new System.Windows.Forms.ListBox();
            this.btnOpenChatWaview = new System.Windows.Forms.Button();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gpbProjet = new System.Windows.Forms.GroupBox();
            this.lstDateTournages = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lstLieux = new System.Windows.Forms.ListBox();
            this.lblLieu = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnAjouterDocument = new System.Windows.Forms.Button();
            this.btnSupprimerDocument = new System.Windows.Forms.Button();
            this.gpbProjet.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbActivity
            // 
            this.lbActivity.BackColor = System.Drawing.Color.Black;
            this.lbActivity.ForeColor = System.Drawing.Color.White;
            this.lbActivity.FormattingEnabled = true;
            this.lbActivity.ItemHeight = 15;
            this.lbActivity.Location = new System.Drawing.Point(381, 367);
            this.lbActivity.Name = "lbActivity";
            this.lbActivity.Size = new System.Drawing.Size(391, 154);
            this.lbActivity.TabIndex = 14;
            // 
            // lbDocuments
            // 
            this.lbDocuments.BackColor = System.Drawing.Color.Black;
            this.lbDocuments.ForeColor = System.Drawing.Color.White;
            this.lbDocuments.FormattingEnabled = true;
            this.lbDocuments.ItemHeight = 15;
            this.lbDocuments.Location = new System.Drawing.Point(11, 367);
            this.lbDocuments.Name = "lbDocuments";
            this.lbDocuments.Size = new System.Drawing.Size(364, 154);
            this.lbDocuments.TabIndex = 13;
            // 
            // btnOpenChatWaview
            // 
            this.btnOpenChatWaview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenChatWaview.ForeColor = System.Drawing.Color.White;
            this.btnOpenChatWaview.Location = new System.Drawing.Point(381, 11);
            this.btnOpenChatWaview.Name = "btnOpenChatWaview";
            this.btnOpenChatWaview.Size = new System.Drawing.Size(391, 60);
            this.btnOpenChatWaview.TabIndex = 12;
            this.btnOpenChatWaview.Text = "Ouvrir chat";
            this.btnOpenChatWaview.UseVisualStyleBackColor = true;
            this.btnOpenChatWaview.Click += new System.EventHandler(this.btnOpenChatWaview_Click);
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProjectName.ForeColor = System.Drawing.Color.White;
            this.lblProjectName.Location = new System.Drawing.Point(11, 11);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(104, 29);
            this.lblProjectName.TabIndex = 11;
            this.lblProjectName.Text = "Projet X";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(293, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 60);
            this.button1.TabIndex = 15;
            this.button1.Text = "Matériel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gpbProjet
            // 
            this.gpbProjet.BackColor = System.Drawing.Color.Black;
            this.gpbProjet.Controls.Add(this.lstDateTournages);
            this.gpbProjet.Controls.Add(this.textBox1);
            this.gpbProjet.Controls.Add(this.lblDescription);
            this.gpbProjet.Controls.Add(this.lstLieux);
            this.gpbProjet.Controls.Add(this.lblLieu);
            this.gpbProjet.Controls.Add(this.lblDate);
            this.gpbProjet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpbProjet.ForeColor = System.Drawing.Color.White;
            this.gpbProjet.Location = new System.Drawing.Point(11, 85);
            this.gpbProjet.Margin = new System.Windows.Forms.Padding(2);
            this.gpbProjet.Name = "gpbProjet";
            this.gpbProjet.Padding = new System.Windows.Forms.Padding(2);
            this.gpbProjet.Size = new System.Drawing.Size(499, 277);
            this.gpbProjet.TabIndex = 19;
            this.gpbProjet.TabStop = false;
            this.gpbProjet.Text = "Informations";
            this.gpbProjet.Enter += new System.EventHandler(this.gpbProjet_Enter);
            // 
            // lstDateTournages
            // 
            this.lstDateTournages.BackColor = System.Drawing.Color.Black;
            this.lstDateTournages.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstDateTournages.ForeColor = System.Drawing.Color.White;
            this.lstDateTournages.FormattingEnabled = true;
            this.lstDateTournages.ItemHeight = 15;
            this.lstDateTournages.Location = new System.Drawing.Point(84, 181);
            this.lstDateTournages.Margin = new System.Windows.Forms.Padding(2);
            this.lstDateTournages.Name = "lstDateTournages";
            this.lstDateTournages.Size = new System.Drawing.Size(360, 64);
            this.lstDateTournages.TabIndex = 40;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(84, 23);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(360, 48);
            this.textBox1.TabIndex = 13;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.Location = new System.Drawing.Point(7, 37);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(67, 15);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Description";
            // 
            // lstLieux
            // 
            this.lstLieux.BackColor = System.Drawing.Color.Black;
            this.lstLieux.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstLieux.ForeColor = System.Drawing.Color.White;
            this.lstLieux.FormattingEnabled = true;
            this.lstLieux.ItemHeight = 15;
            this.lstLieux.Location = new System.Drawing.Point(85, 97);
            this.lstLieux.Margin = new System.Windows.Forms.Padding(2);
            this.lstLieux.Name = "lstLieux";
            this.lstLieux.Size = new System.Drawing.Size(359, 64);
            this.lstLieux.TabIndex = 8;
            // 
            // lblLieu
            // 
            this.lblLieu.AutoSize = true;
            this.lblLieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLieu.Location = new System.Drawing.Point(10, 96);
            this.lblLieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLieu.Name = "lblLieu";
            this.lblLieu.Size = new System.Drawing.Size(38, 15);
            this.lblLieu.TabIndex = 4;
            this.lblLieu.Text = "Lieu.x";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(10, 180);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(31, 15);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // btnAjouterDocument
            // 
            this.btnAjouterDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterDocument.ForeColor = System.Drawing.Color.White;
            this.btnAjouterDocument.Location = new System.Drawing.Point(293, 527);
            this.btnAjouterDocument.Name = "btnAjouterDocument";
            this.btnAjouterDocument.Size = new System.Drawing.Size(82, 30);
            this.btnAjouterDocument.TabIndex = 20;
            this.btnAjouterDocument.Text = "Ajouter";
            this.btnAjouterDocument.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerDocument
            // 
            this.btnSupprimerDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerDocument.ForeColor = System.Drawing.Color.White;
            this.btnSupprimerDocument.Location = new System.Drawing.Point(205, 527);
            this.btnSupprimerDocument.Name = "btnSupprimerDocument";
            this.btnSupprimerDocument.Size = new System.Drawing.Size(82, 30);
            this.btnSupprimerDocument.TabIndex = 21;
            this.btnSupprimerDocument.Text = "Supprimer";
            this.btnSupprimerDocument.UseVisualStyleBackColor = true;
            // 
            // FrmWaviewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnSupprimerDocument);
            this.Controls.Add(this.btnAjouterDocument);
            this.Controls.Add(this.gpbProjet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbActivity);
            this.Controls.Add(this.lbDocuments);
            this.Controls.Add(this.btnOpenChatWaview);
            this.Controls.Add(this.lblProjectName);
            this.MaximizeBox = false;
            this.Name = "FrmWaviewProject";
            this.Text = "FrmWaviewProject";
            this.Load += new System.EventHandler(this.FrmWaviewProject_Load);
            this.gpbProjet.ResumeLayout(false);
            this.gpbProjet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbActivity;
        private System.Windows.Forms.ListBox lbDocuments;
        private System.Windows.Forms.Button btnOpenChatWaview;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gpbProjet;
        private System.Windows.Forms.ListBox lstDateTournages;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ListBox lstLieux;
        private System.Windows.Forms.Label lblLieu;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnAjouterDocument;
        private System.Windows.Forms.Button btnSupprimerDocument;
    }
}