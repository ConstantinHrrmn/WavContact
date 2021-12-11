
namespace WavContact.Views.Member
{
    partial class FrmWaviewChat
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.txtListeMessage = new System.Windows.Forms.TextBox();
            this.cboListeProjet = new System.Windows.Forms.ComboBox();
            this.lstListeClient = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEnvoye = new System.Windows.Forms.Button();
            this.lblClient = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(620, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 29);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.BackColor = System.Drawing.Color.Black;
            this.btnSelectionner.ForeColor = System.Drawing.Color.White;
            this.btnSelectionner.Location = new System.Drawing.Point(568, 72);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(87, 24);
            this.btnSelectionner.TabIndex = 7;
            this.btnSelectionner.Text = "Sélectionner";
            this.btnSelectionner.UseVisualStyleBackColor = false;
            // 
            // txtListeMessage
            // 
            this.txtListeMessage.BackColor = System.Drawing.Color.Black;
            this.txtListeMessage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtListeMessage.ForeColor = System.Drawing.Color.White;
            this.txtListeMessage.Location = new System.Drawing.Point(236, 102);
            this.txtListeMessage.Multiline = true;
            this.txtListeMessage.Name = "txtListeMessage";
            this.txtListeMessage.ReadOnly = true;
            this.txtListeMessage.Size = new System.Drawing.Size(419, 357);
            this.txtListeMessage.TabIndex = 8;
            // 
            // cboListeProjet
            // 
            this.cboListeProjet.BackColor = System.Drawing.Color.Black;
            this.cboListeProjet.ForeColor = System.Drawing.Color.White;
            this.cboListeProjet.FormattingEnabled = true;
            this.cboListeProjet.Location = new System.Drawing.Point(236, 73);
            this.cboListeProjet.Name = "cboListeProjet";
            this.cboListeProjet.Size = new System.Drawing.Size(326, 23);
            this.cboListeProjet.TabIndex = 9;
            this.cboListeProjet.SelectedIndexChanged += new System.EventHandler(this.cboListeProjet_SelectedIndexChanged);
            // 
            // lstListeClient
            // 
            this.lstListeClient.BackColor = System.Drawing.Color.Black;
            this.lstListeClient.ForeColor = System.Drawing.Color.White;
            this.lstListeClient.FormattingEnabled = true;
            this.lstListeClient.ItemHeight = 15;
            this.lstListeClient.Location = new System.Drawing.Point(12, 73);
            this.lstListeClient.Name = "lstListeClient";
            this.lstListeClient.Size = new System.Drawing.Size(218, 424);
            this.lstListeClient.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(236, 465);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(326, 32);
            this.textBox1.TabIndex = 11;
            // 
            // btnEnvoye
            // 
            this.btnEnvoye.BackColor = System.Drawing.Color.Black;
            this.btnEnvoye.ForeColor = System.Drawing.Color.White;
            this.btnEnvoye.Location = new System.Drawing.Point(568, 465);
            this.btnEnvoye.Name = "btnEnvoye";
            this.btnEnvoye.Size = new System.Drawing.Size(87, 32);
            this.btnEnvoye.TabIndex = 12;
            this.btnEnvoye.Text = "Envoyer";
            this.btnEnvoye.UseVisualStyleBackColor = false;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.BackColor = System.Drawing.Color.Transparent;
            this.lblClient.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblClient.Location = new System.Drawing.Point(236, 33);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(145, 37);
            this.lblClient.TabIndex = 13;
            this.lblClient.Text = "NomClient";
            // 
            // FrmWaviewChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(667, 511);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.btnEnvoye);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lstListeClient);
            this.Controls.Add(this.cboListeProjet);
            this.Controls.Add(this.txtListeMessage);
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmWaviewChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmWaviewChat";
            this.Load += new System.EventHandler(this.FrmWaviewChat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.TextBox txtListeMessage;
        private System.Windows.Forms.ComboBox cboListeProjet;
        private System.Windows.Forms.ListBox lstListeClient;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEnvoye;
        private System.Windows.Forms.Label lblClient;
    }
}