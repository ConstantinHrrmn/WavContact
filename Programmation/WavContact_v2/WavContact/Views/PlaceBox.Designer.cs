namespace WavContact.Views
{
    partial class PlaceBox
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.lblLon = new System.Windows.Forms.Label();
            this.lblLat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(498, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(290, 49);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Supprimer lieu de tournage";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(12, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 37);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "URL GoogleMaps copié !";
            // 
            // pbPhoto
            // 
            this.pbPhoto.Location = new System.Drawing.Point(498, 67);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(290, 316);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPhoto.TabIndex = 13;
            this.pbPhoto.TabStop = false;
            // 
            // tbxDescription
            // 
            this.tbxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxDescription.Location = new System.Drawing.Point(12, 94);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.ReadOnly = true;
            this.tbxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbxDescription.Size = new System.Drawing.Size(480, 146);
            this.tbxDescription.TabIndex = 14;
            // 
            // lblLon
            // 
            this.lblLon.AutoSize = true;
            this.lblLon.ForeColor = System.Drawing.Color.White;
            this.lblLon.Location = new System.Drawing.Point(12, 258);
            this.lblLon.Name = "lblLon";
            this.lblLon.Size = new System.Drawing.Size(164, 30);
            this.lblLon.TabIndex = 15;
            this.lblLon.Text = "Longitude : X.XX";
            // 
            // lblLat
            // 
            this.lblLat.AutoSize = true;
            this.lblLat.ForeColor = System.Drawing.Color.White;
            this.lblLat.Location = new System.Drawing.Point(12, 304);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(146, 30);
            this.lblLat.TabIndex = 16;
            this.lblLat.Text = "Latitude : Y.YY";
            // 
            // PlaceBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLat);
            this.Controls.Add(this.lblLon);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.pbPhoto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlaceBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information lieu";
            this.Load += new System.EventHandler(this.PlaceBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.Label lblLon;
        private System.Windows.Forms.Label lblLat;
    }
}