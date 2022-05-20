namespace WavContact.Views.Member
{
    partial class FrmMaterielTournage
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
            this.gbSelectionMateriel = new System.Windows.Forms.GroupBox();
            this.gbQuantite = new System.Windows.Forms.GroupBox();
            this.btnAction = new System.Windows.Forms.Button();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFiltreSelect = new System.Windows.Forms.ComboBox();
            this.lbSelect = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFiltreDisponible = new System.Windows.Forms.ComboBox();
            this.lbDisponible = new System.Windows.Forms.ListBox();
            this.cmbDate = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gbSelectionMateriel.SuspendLayout();
            this.gbQuantite.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSelectionMateriel
            // 
            this.gbSelectionMateriel.Controls.Add(this.gbQuantite);
            this.gbSelectionMateriel.Controls.Add(this.label1);
            this.gbSelectionMateriel.Controls.Add(this.cmbFiltreSelect);
            this.gbSelectionMateriel.Controls.Add(this.lbSelect);
            this.gbSelectionMateriel.Controls.Add(this.label5);
            this.gbSelectionMateriel.Controls.Add(this.cmbFiltreDisponible);
            this.gbSelectionMateriel.Controls.Add(this.lbDisponible);
            this.gbSelectionMateriel.Enabled = false;
            this.gbSelectionMateriel.ForeColor = System.Drawing.Color.White;
            this.gbSelectionMateriel.Location = new System.Drawing.Point(12, 133);
            this.gbSelectionMateriel.Name = "gbSelectionMateriel";
            this.gbSelectionMateriel.Size = new System.Drawing.Size(1552, 732);
            this.gbSelectionMateriel.TabIndex = 46;
            this.gbSelectionMateriel.TabStop = false;
            this.gbSelectionMateriel.Text = "Materiel";
            // 
            // gbQuantite
            // 
            this.gbQuantite.Controls.Add(this.btnAction);
            this.gbQuantite.Controls.Add(this.tbxName);
            this.gbQuantite.Controls.Add(this.label3);
            this.gbQuantite.Location = new System.Drawing.Point(521, 109);
            this.gbQuantite.Name = "gbQuantite";
            this.gbQuantite.Size = new System.Drawing.Size(510, 215);
            this.gbQuantite.TabIndex = 55;
            this.gbQuantite.TabStop = false;
            this.gbQuantite.Text = "Quantité";
            // 
            // btnAction
            // 
            this.btnAction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAction.BackColor = System.Drawing.Color.Black;
            this.btnAction.ForeColor = System.Drawing.Color.White;
            this.btnAction.Location = new System.Drawing.Point(47, 129);
            this.btnAction.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(368, 58);
            this.btnAction.TabIndex = 56;
            this.btnAction.Text = "Ajouter";
            this.btnAction.UseVisualStyleBackColor = false;
            // 
            // tbxName
            // 
            this.tbxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxName.BackColor = System.Drawing.Color.Black;
            this.tbxName.ForeColor = System.Drawing.Color.White;
            this.tbxName.Location = new System.Drawing.Point(47, 56);
            this.tbxName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbxName.Name = "tbxName";
            this.tbxName.ReadOnly = true;
            this.tbxName.Size = new System.Drawing.Size(368, 35);
            this.tbxName.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(433, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 30);
            this.label3.TabIndex = 54;
            this.label3.Text = "/ 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1039, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 30);
            this.label1.TabIndex = 51;
            this.label1.Text = "Filtre";
            // 
            // cmbFiltreSelect
            // 
            this.cmbFiltreSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltreSelect.Location = new System.Drawing.Point(1107, 59);
            this.cmbFiltreSelect.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbFiltreSelect.Name = "cmbFiltreSelect";
            this.cmbFiltreSelect.Size = new System.Drawing.Size(424, 38);
            this.cmbFiltreSelect.TabIndex = 50;
            // 
            // lbSelect
            // 
            this.lbSelect.BackColor = System.Drawing.Color.Black;
            this.lbSelect.ForeColor = System.Drawing.Color.White;
            this.lbSelect.FormattingEnabled = true;
            this.lbSelect.ItemHeight = 30;
            this.lbSelect.Location = new System.Drawing.Point(1039, 109);
            this.lbSelect.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lbSelect.Name = "lbSelect";
            this.lbSelect.Size = new System.Drawing.Size(492, 604);
            this.lbSelect.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 30);
            this.label5.TabIndex = 48;
            this.label5.Text = "Filtre";
            // 
            // cmbFiltreDisponible
            // 
            this.cmbFiltreDisponible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltreDisponible.Location = new System.Drawing.Point(89, 59);
            this.cmbFiltreDisponible.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbFiltreDisponible.Name = "cmbFiltreDisponible";
            this.cmbFiltreDisponible.Size = new System.Drawing.Size(424, 38);
            this.cmbFiltreDisponible.TabIndex = 47;
            // 
            // lbDisponible
            // 
            this.lbDisponible.BackColor = System.Drawing.Color.Black;
            this.lbDisponible.ForeColor = System.Drawing.Color.White;
            this.lbDisponible.FormattingEnabled = true;
            this.lbDisponible.ItemHeight = 30;
            this.lbDisponible.Location = new System.Drawing.Point(21, 109);
            this.lbDisponible.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lbDisponible.Name = "lbDisponible";
            this.lbDisponible.Size = new System.Drawing.Size(492, 604);
            this.lbDisponible.TabIndex = 46;
            // 
            // cmbDate
            // 
            this.cmbDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDate.Location = new System.Drawing.Point(238, 55);
            this.cmbDate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbDate.Name = "cmbDate";
            this.cmbDate.Size = new System.Drawing.Size(710, 38);
            this.cmbDate.TabIndex = 53;
            this.cmbDate.SelectedIndexChanged += new System.EventHandler(this.cmbDate_SelectedIndexChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrint.BackColor = System.Drawing.Color.Black;
            this.btnPrint.Enabled = false;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(1051, 44);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(513, 58);
            this.btnPrint.TabIndex = 57;
            this.btnPrint.Text = "Imprimer liste";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 30);
            this.label2.TabIndex = 56;
            this.label2.Text = "Sélection de la date";
            // 
            // FrmMaterielTournage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1576, 886);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.cmbDate);
            this.Controls.Add(this.gbSelectionMateriel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMaterielTournage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion materiel tournage";
            this.Load += new System.EventHandler(this.FrmMaterielTournage_Load);
            this.gbSelectionMateriel.ResumeLayout(false);
            this.gbSelectionMateriel.PerformLayout();
            this.gbQuantite.ResumeLayout(false);
            this.gbQuantite.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSelectionMateriel;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFiltreSelect;
        private System.Windows.Forms.ListBox lbSelect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbFiltreDisponible;
        private System.Windows.Forms.ListBox lbDisponible;
        private System.Windows.Forms.ComboBox cmbDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbQuantite;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label2;
    }
}