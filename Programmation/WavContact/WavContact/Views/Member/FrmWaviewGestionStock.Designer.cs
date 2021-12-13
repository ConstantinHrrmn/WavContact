
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblGestionStock = new System.Windows.Forms.Label();
            this.dtgStock = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStock)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(737, 14);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 48);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblGestionStock
            // 
            this.lblGestionStock.AutoSize = true;
            this.lblGestionStock.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGestionStock.Location = new System.Drawing.Point(12, 17);
            this.lblGestionStock.Name = "lblGestionStock";
            this.lblGestionStock.Size = new System.Drawing.Size(286, 45);
            this.lblGestionStock.TabIndex = 7;
            this.lblGestionStock.Text = "Gestion des stocks";
            // 
            // dtgStock
            // 
            this.dtgStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Nombre,
            this.Moins,
            this.Plus,
            this.Supprimer});
            this.dtgStock.Location = new System.Drawing.Point(12, 70);
            this.dtgStock.Name = "dtgStock";
            this.dtgStock.RowHeadersWidth = 62;
            this.dtgStock.RowTemplate.Height = 33;
            this.dtgStock.Size = new System.Drawing.Size(775, 368);
            this.dtgStock.TabIndex = 8;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 8;
            this.Nom.Name = "Nom";
            this.Nom.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // Moins
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            this.Moins.DefaultCellStyle = dataGridViewCellStyle1;
            this.Moins.HeaderText = "";
            this.Moins.MinimumWidth = 8;
            this.Moins.Name = "Moins";
            this.Moins.Width = 150;
            // 
            // Plus
            // 
            this.Plus.HeaderText = "";
            this.Plus.MinimumWidth = 8;
            this.Plus.Name = "Plus";
            this.Plus.Width = 150;
            // 
            // Supprimer
            // 
            this.Supprimer.HeaderText = "Supprimer";
            this.Supprimer.MinimumWidth = 8;
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Width = 150;
            // 
            // FrmWaviewGestionStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgStock);
            this.Controls.Add(this.lblGestionStock);
            this.Controls.Add(this.btnClose);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmWaviewGestionStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmWaviewGestionStock";
            ((System.ComponentModel.ISupportInitialize)(this.dtgStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblGestionStock;
        private System.Windows.Forms.DataGridView dtgStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moins;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supprimer;
    }
}