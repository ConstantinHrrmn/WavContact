
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxQuantite = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxPrix = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.cmbCategorie = new System.Windows.Forms.ComboBox();
            this.cmbFiltre = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGestionStock
            // 
            this.lblGestionStock.AutoSize = true;
            this.lblGestionStock.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGestionStock.Location = new System.Drawing.Point(11, 17);
            this.lblGestionStock.Name = "lblGestionStock";
            this.lblGestionStock.Size = new System.Drawing.Size(286, 45);
            this.lblGestionStock.TabIndex = 7;
            this.lblGestionStock.Text = "Gestion des stocks";
            // 
            // lbMateriel
            // 
            this.lbMateriel.BackColor = System.Drawing.Color.Black;
            this.lbMateriel.ForeColor = System.Drawing.Color.White;
            this.lbMateriel.FormattingEnabled = true;
            this.lbMateriel.ItemHeight = 25;
            this.lbMateriel.Location = new System.Drawing.Point(11, 122);
            this.lbMateriel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbMateriel.Name = "lbMateriel";
            this.lbMateriel.Size = new System.Drawing.Size(411, 704);
            this.lbMateriel.TabIndex = 11;
            this.lbMateriel.SelectedIndexChanged += new System.EventHandler(this.lbMateriel_SelectedIndexChanged);
            this.lbMateriel.SelectedValueChanged += new System.EventHandler(this.lbMateriel_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(484, 237);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nom d\'affichage";
            // 
            // tbxName
            // 
            this.tbxName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbxName.BackColor = System.Drawing.Color.Black;
            this.tbxName.ForeColor = System.Drawing.Color.White;
            this.tbxName.Location = new System.Drawing.Point(639, 232);
            this.tbxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxName.Name = "tbxName";
            this.tbxName.ReadOnly = true;
            this.tbxName.Size = new System.Drawing.Size(405, 31);
            this.tbxName.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(526, 312);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Description";
            // 
            // tbxDescription
            // 
            this.tbxDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbxDescription.BackColor = System.Drawing.Color.Black;
            this.tbxDescription.ForeColor = System.Drawing.Color.White;
            this.tbxDescription.Location = new System.Drawing.Point(639, 307);
            this.tbxDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.ReadOnly = true;
            this.tbxDescription.Size = new System.Drawing.Size(405, 31);
            this.tbxDescription.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(546, 423);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Quantité";
            // 
            // tbxQuantite
            // 
            this.tbxQuantite.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbxQuantite.BackColor = System.Drawing.Color.Black;
            this.tbxQuantite.ForeColor = System.Drawing.Color.White;
            this.tbxQuantite.Location = new System.Drawing.Point(639, 418);
            this.tbxQuantite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxQuantite.Name = "tbxQuantite";
            this.tbxQuantite.ReadOnly = true;
            this.tbxQuantite.Size = new System.Drawing.Size(405, 31);
            this.tbxQuantite.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(583, 497);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Prix";
            // 
            // tbxPrix
            // 
            this.tbxPrix.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbxPrix.BackColor = System.Drawing.Color.Black;
            this.tbxPrix.ForeColor = System.Drawing.Color.White;
            this.tbxPrix.Location = new System.Drawing.Point(639, 492);
            this.tbxPrix.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxPrix.Name = "tbxPrix";
            this.tbxPrix.ReadOnly = true;
            this.tbxPrix.Size = new System.Drawing.Size(405, 31);
            this.tbxPrix.TabIndex = 32;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouter.BackColor = System.Drawing.Color.Black;
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(279, 838);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(146, 48);
            this.btnAjouter.TabIndex = 34;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimer.BackColor = System.Drawing.Color.Black;
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(124, 838);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(146, 48);
            this.btnSupprimer.TabIndex = 35;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            // 
            // cmbCategorie
            // 
            this.cmbCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategorie.Location = new System.Drawing.Point(639, 568);
            this.cmbCategorie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCategorie.Name = "cmbCategorie";
            this.cmbCategorie.Size = new System.Drawing.Size(405, 33);
            this.cmbCategorie.TabIndex = 36;
            // 
            // cmbFiltre
            // 
            this.cmbFiltre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltre.Location = new System.Drawing.Point(71, 77);
            this.cmbFiltre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFiltre.Name = "cmbFiltre";
            this.cmbFiltre.Size = new System.Drawing.Size(354, 33);
            this.cmbFiltre.TabIndex = 37;
            this.cmbFiltre.SelectedIndexChanged += new System.EventHandler(this.cmbFiltre_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 25);
            this.label5.TabIndex = 38;
            this.label5.Text = "Filtre";
            // 
            // FrmWaviewGestionStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1120, 935);
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
            this.MaximizeBox = false;
            this.Name = "FrmWaviewGestionStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion du stock matériel";
            this.Load += new System.EventHandler(this.FrmWaviewGestionStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGestionStock;
        private System.Windows.Forms.ListBox lbMateriel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxQuantite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxPrix;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.ComboBox cmbCategorie;
        private System.Windows.Forms.ComboBox cmbFiltre;
        private System.Windows.Forms.Label label5;
    }
}