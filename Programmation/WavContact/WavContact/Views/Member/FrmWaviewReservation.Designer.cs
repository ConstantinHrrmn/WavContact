
namespace WavContact.Views.Member
{
    partial class FrmWaviewReservation
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRéservation = new System.Windows.Forms.Label();
            this.dtgReservation = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moins = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Plus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSauvegarder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReservation)).BeginInit();
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
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblRéservation
            // 
            this.lblRéservation.AutoSize = true;
            this.lblRéservation.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRéservation.Location = new System.Drawing.Point(2, 17);
            this.lblRéservation.Name = "lblRéservation";
            this.lblRéservation.Size = new System.Drawing.Size(354, 45);
            this.lblRéservation.TabIndex = 6;
            this.lblRéservation.Text = "Réservation de matériel";
            // 
            // dtgReservation
            // 
            this.dtgReservation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgReservation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgReservation.BackgroundColor = System.Drawing.Color.Black;
            this.dtgReservation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Disponible,
            this.Quantite,
            this.Moins,
            this.Plus});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgReservation.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgReservation.GridColor = System.Drawing.Color.White;
            this.dtgReservation.Location = new System.Drawing.Point(12, 78);
            this.dtgReservation.Name = "dtgReservation";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgReservation.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgReservation.RowHeadersWidth = 62;
            this.dtgReservation.RowTemplate.Height = 33;
            this.dtgReservation.Size = new System.Drawing.Size(775, 419);
            this.dtgReservation.TabIndex = 7;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 8;
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Disponible
            // 
            this.Disponible.HeaderText = "Disponible";
            this.Disponible.MinimumWidth = 8;
            this.Disponible.Name = "Disponible";
            this.Disponible.ReadOnly = true;
            // 
            // Quantite
            // 
            this.Quantite.HeaderText = "Quantité réservé";
            this.Quantite.MinimumWidth = 8;
            this.Quantite.Name = "Quantite";
            this.Quantite.ReadOnly = true;
            // 
            // Moins
            // 
            this.Moins.HeaderText = "-";
            this.Moins.MinimumWidth = 8;
            this.Moins.Name = "Moins";
            // 
            // Plus
            // 
            this.Plus.HeaderText = "+";
            this.Plus.MinimumWidth = 8;
            this.Plus.Name = "Plus";
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSauvegarder.BackColor = System.Drawing.Color.Black;
            this.btnSauvegarder.ForeColor = System.Drawing.Color.White;
            this.btnSauvegarder.Location = new System.Drawing.Point(641, 520);
            this.btnSauvegarder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.Size = new System.Drawing.Size(146, 48);
            this.btnSauvegarder.TabIndex = 18;
            this.btnSauvegarder.Text = "Sauvegarder";
            this.btnSauvegarder.UseVisualStyleBackColor = false;
            // 
            // FrmWaviewReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 582);
            this.Controls.Add(this.btnSauvegarder);
            this.Controls.Add(this.dtgReservation);
            this.Controls.Add(this.lblRéservation);
            this.Controls.Add(this.btnClose);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmWaviewReservation";
            this.Text = "FrmWaviewReservation";
            this.Load += new System.EventHandler(this.FrmWaviewReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgReservation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRéservation;
        private System.Windows.Forms.DataGridView dtgReservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantite;
        private System.Windows.Forms.DataGridViewButtonColumn Moins;
        private System.Windows.Forms.DataGridViewButtonColumn Plus;
        private System.Windows.Forms.Button btnSauvegarder;
    }
}