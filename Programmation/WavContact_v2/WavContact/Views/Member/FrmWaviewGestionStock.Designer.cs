
namespace WavContact.Views.Member
{
    partial class FrmWaviewGestionStock
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
            this.lblGestionStock = new System.Windows.Forms.Label();
            this.lbMateriel = new System.Windows.Forms.ListBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.cmbFiltre = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxQuantite = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxPrix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCategorie = new System.Windows.Forms.ComboBox();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGestionStock
            // 
            this.lblGestionStock.AutoSize = true;
            this.lblGestionStock.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGestionStock.Location = new System.Drawing.Point(13, 20);
            this.lblGestionStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGestionStock.Name = "lblGestionStock";
            this.lblGestionStock.Size = new System.Drawing.Size(332, 51);
            this.lblGestionStock.TabIndex = 7;
            this.lblGestionStock.Text = "Gestion des stocks";
            // 
            // lbMateriel
            // 
            this.lbMateriel.BackColor = System.Drawing.Color.Black;
            this.lbMateriel.ForeColor = System.Drawing.Color.White;
            this.lbMateriel.FormattingEnabled = true;
            this.lbMateriel.ItemHeight = 30;
            this.lbMateriel.Location = new System.Drawing.Point(13, 146);
            this.lbMateriel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lbMateriel.Name = "lbMateriel";
            this.lbMateriel.Size = new System.Drawing.Size(492, 574);
            this.lbMateriel.TabIndex = 11;
            this.lbMateriel.SelectedIndexChanged += new System.EventHandler(this.lbMateriel_SelectedIndexChanged);
            this.lbMateriel.SelectedValueChanged += new System.EventHandler(this.lbMateriel_SelectedValueChanged);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAjouter.BackColor = System.Drawing.Color.Black;
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(288, 732);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(217, 58);
            this.btnAjouter.TabIndex = 34;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSupprimer.BackColor = System.Drawing.Color.Black;
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(13, 732);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(214, 58);
            this.btnSupprimer.TabIndex = 35;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // cmbFiltre
            // 
            this.cmbFiltre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltre.Location = new System.Drawing.Point(85, 92);
            this.cmbFiltre.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbFiltre.Name = "cmbFiltre";
            this.cmbFiltre.Size = new System.Drawing.Size(424, 38);
            this.cmbFiltre.TabIndex = 37;
            this.cmbFiltre.SelectedIndexChanged += new System.EventHandler(this.cmbFiltre_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 95);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 30);
            this.label5.TabIndex = 38;
            this.label5.Text = "Filtre";
            // 
            // tbxName
            // 
            this.tbxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxName.BackColor = System.Drawing.Color.Black;
            this.tbxName.ForeColor = System.Drawing.Color.White;
            this.tbxName.Location = new System.Drawing.Point(700, 189);
            this.tbxName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbxName.Name = "tbxName";
            this.tbxName.ReadOnly = true;
            this.tbxName.Size = new System.Drawing.Size(485, 35);
            this.tbxName.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(514, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 30);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nom d\'affichage";
            // 
            // tbxDescription
            // 
            this.tbxDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxDescription.BackColor = System.Drawing.Color.Black;
            this.tbxDescription.ForeColor = System.Drawing.Color.White;
            this.tbxDescription.Location = new System.Drawing.Point(700, 279);
            this.tbxDescription.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.ReadOnly = true;
            this.tbxDescription.Size = new System.Drawing.Size(485, 35);
            this.tbxDescription.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(564, 285);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 30);
            this.label2.TabIndex = 29;
            this.label2.Text = "Description";
            // 
            // tbxQuantite
            // 
            this.tbxQuantite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxQuantite.BackColor = System.Drawing.Color.Black;
            this.tbxQuantite.ForeColor = System.Drawing.Color.White;
            this.tbxQuantite.Location = new System.Drawing.Point(700, 413);
            this.tbxQuantite.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbxQuantite.Name = "tbxQuantite";
            this.tbxQuantite.ReadOnly = true;
            this.tbxQuantite.Size = new System.Drawing.Size(485, 35);
            this.tbxQuantite.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(588, 419);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 30);
            this.label3.TabIndex = 31;
            this.label3.Text = "Quantité";
            // 
            // tbxPrix
            // 
            this.tbxPrix.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxPrix.BackColor = System.Drawing.Color.Black;
            this.tbxPrix.ForeColor = System.Drawing.Color.White;
            this.tbxPrix.Location = new System.Drawing.Point(700, 501);
            this.tbxPrix.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbxPrix.Name = "tbxPrix";
            this.tbxPrix.ReadOnly = true;
            this.tbxPrix.Size = new System.Drawing.Size(485, 35);
            this.tbxPrix.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(633, 507);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 30);
            this.label4.TabIndex = 33;
            this.label4.Text = "Prix";
            // 
            // cmbCategorie
            // 
            this.cmbCategorie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategorie.Location = new System.Drawing.Point(700, 612);
            this.cmbCategorie.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbCategorie.Name = "cmbCategorie";
            this.cmbCategorie.Size = new System.Drawing.Size(485, 38);
            this.cmbCategorie.TabIndex = 36;
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveNew.BackColor = System.Drawing.Color.Black;
            this.btnSaveNew.ForeColor = System.Drawing.Color.White;
            this.btnSaveNew.Location = new System.Drawing.Point(968, 732);
            this.btnSaveNew.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(217, 58);
            this.btnSaveNew.TabIndex = 39;
            this.btnSaveNew.Text = "Enregistrer";
            this.btnSaveNew.UseVisualStyleBackColor = false;
            this.btnSaveNew.Visible = false;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // lblId
            // 
            this.lblId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(1017, 120);
            this.lblId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(168, 30);
            this.lblId.TabIndex = 40;
            this.lblId.Text = "-";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmWaviewGestionStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1209, 802);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbFiltre);
            this.Controls.Add(this.cmbCategorie);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxPrix);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxQuantite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lbMateriel);
            this.Controls.Add(this.lblGestionStock);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmWaviewGestionStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion du matériel";
            this.Load += new System.EventHandler(this.FrmWaviewGestionStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGestionStock;
        private System.Windows.Forms.ListBox lbMateriel;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.ComboBox cmbFiltre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxQuantite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxPrix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCategorie;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Label lblId;
    }
}