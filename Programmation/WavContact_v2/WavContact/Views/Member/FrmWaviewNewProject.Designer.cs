
namespace WavContact.Views.Member
{
    partial class FrmWaviewNewProject
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
            this.btnSauvegarder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.lblNomMandant = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSauvegarder.BackColor = System.Drawing.Color.Black;
            this.btnSauvegarder.ForeColor = System.Drawing.Color.White;
            this.btnSauvegarder.Location = new System.Drawing.Point(435, 248);
            this.btnSauvegarder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.Size = new System.Drawing.Size(146, 48);
            this.btnSauvegarder.TabIndex = 40;
            this.btnSauvegarder.Text = "Sauvegarder";
            this.btnSauvegarder.UseVisualStyleBackColor = false;
            this.btnSauvegarder.Click += new System.EventHandler(this.btnSauvegarder_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "Nom du projet";
            // 
            // tbxNom
            // 
            this.tbxNom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxNom.BackColor = System.Drawing.Color.Black;
            this.tbxNom.ForeColor = System.Drawing.Color.White;
            this.tbxNom.Location = new System.Drawing.Point(176, 30);
            this.tbxNom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(405, 31);
            this.tbxNom.TabIndex = 36;
            // 
            // tbxDescription
            // 
            this.tbxDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxDescription.BackColor = System.Drawing.Color.Black;
            this.tbxDescription.ForeColor = System.Drawing.Color.White;
            this.tbxDescription.Location = new System.Drawing.Point(176, 78);
            this.tbxDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxDescription.Size = new System.Drawing.Size(405, 139);
            this.tbxDescription.TabIndex = 37;
            // 
            // lblNomMandant
            // 
            this.lblNomMandant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomMandant.AutoSize = true;
            this.lblNomMandant.ForeColor = System.Drawing.Color.White;
            this.lblNomMandant.Location = new System.Drawing.Point(22, 83);
            this.lblNomMandant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomMandant.Name = "lblNomMandant";
            this.lblNomMandant.Size = new System.Drawing.Size(102, 25);
            this.lblNomMandant.TabIndex = 38;
            this.lblNomMandant.Text = "Description";
            // 
            // FrmWaviewNewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 333);
            this.Controls.Add(this.btnSauvegarder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxNom);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.lblNomMandant);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmWaviewNewProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Project";
            this.Load += new System.EventHandler(this.FrmWaviewNewProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSauvegarder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.Label lblNomMandant;
    }
}