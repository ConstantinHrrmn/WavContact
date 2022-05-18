
namespace WavContact.Views
{
    partial class FrmParametre
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
            this.lblParametre = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblSelectionLangue = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtNouveauMdp = new System.Windows.Forms.TextBox();
            this.txtAncienMdp = new System.Windows.Forms.TextBox();
            this.lblNouveauMdP = new System.Windows.Forms.Label();
            this.lblAncienMDP = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbxNumTelephone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxPrenom = new System.Windows.Forms.TextBox();
            this.lblPrénom = new System.Windows.Forms.Label();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblParametre
            // 
            this.lblParametre.AutoSize = true;
            this.lblParametre.BackColor = System.Drawing.Color.Transparent;
            this.lblParametre.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblParametre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblParametre.Location = new System.Drawing.Point(16, 11);
            this.lblParametre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblParametre.Name = "lblParametre";
            this.lblParametre.Size = new System.Drawing.Size(262, 65);
            this.lblParametre.TabIndex = 30;
            this.lblParametre.Text = "Paramètres";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lblSelectionLangue);
            this.groupBox1.Enabled = false;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(16, 119);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(857, 229);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Langues";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(401, 107);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(423, 38);
            this.comboBox1.TabIndex = 2;
            // 
            // lblSelectionLangue
            // 
            this.lblSelectionLangue.AutoSize = true;
            this.lblSelectionLangue.Location = new System.Drawing.Point(25, 107);
            this.lblSelectionLangue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectionLangue.Name = "lblSelectionLangue";
            this.lblSelectionLangue.Size = new System.Drawing.Size(312, 30);
            this.lblSelectionLangue.TabIndex = 1;
            this.lblSelectionLangue.Text = "Veuillez séléctionner une langue";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEnregistrer);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.txtNouveauMdp);
            this.groupBox2.Controls.Add(this.txtAncienMdp);
            this.groupBox2.Controls.Add(this.lblNouveauMdP);
            this.groupBox2.Controls.Add(this.lblAncienMDP);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(16, 371);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(857, 311);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Changer mot de passe";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrer.Location = new System.Drawing.Point(611, 230);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(214, 58);
            this.btnEnregistrer.TabIndex = 42;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Confirmation nouveau mot de passe ";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(401, 178);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(423, 32);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Veuillez insérer votre nouveau mot de passe";
            // 
            // txtNouveauMdp
            // 
            this.txtNouveauMdp.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtNouveauMdp.Location = new System.Drawing.Point(401, 115);
            this.txtNouveauMdp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNouveauMdp.Name = "txtNouveauMdp";
            this.txtNouveauMdp.Size = new System.Drawing.Size(423, 32);
            this.txtNouveauMdp.TabIndex = 3;
            this.txtNouveauMdp.Text = "Veuillez insérer votre nouveau mot de passe";
            // 
            // txtAncienMdp
            // 
            this.txtAncienMdp.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtAncienMdp.Location = new System.Drawing.Point(401, 58);
            this.txtAncienMdp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAncienMdp.Name = "txtAncienMdp";
            this.txtAncienMdp.Size = new System.Drawing.Size(423, 32);
            this.txtAncienMdp.TabIndex = 2;
            this.txtAncienMdp.Text = "Veuillez insérer votre ancien mot de passe";
            // 
            // lblNouveauMdP
            // 
            this.lblNouveauMdP.AutoSize = true;
            this.lblNouveauMdP.Location = new System.Drawing.Point(25, 115);
            this.lblNouveauMdP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNouveauMdP.Name = "lblNouveauMdP";
            this.lblNouveauMdP.Size = new System.Drawing.Size(97, 30);
            this.lblNouveauMdP.TabIndex = 1;
            this.lblNouveauMdP.Text = "Nouveau";
            // 
            // lblAncienMDP
            // 
            this.lblAncienMDP.AutoSize = true;
            this.lblAncienMDP.Location = new System.Drawing.Point(25, 58);
            this.lblAncienMDP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAncienMDP.Name = "lblAncienMDP";
            this.lblAncienMDP.Size = new System.Drawing.Size(83, 30);
            this.lblAncienMDP.TabIndex = 0;
            this.lblAncienMDP.Text = "Ancien ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbxEmail);
            this.groupBox3.Controls.Add(this.lblEmail);
            this.groupBox3.Controls.Add(this.tbxNumTelephone);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tbxPrenom);
            this.groupBox3.Controls.Add(this.lblPrénom);
            this.groupBox3.Controls.Add(this.tbxNom);
            this.groupBox3.Controls.Add(this.lblNom);
            this.groupBox3.Enabled = false;
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(16, 708);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(857, 229);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Compte";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(575, 145);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(249, 35);
            this.tbxEmail.TabIndex = 50;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(475, 145);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 30);
            this.lblEmail.TabIndex = 49;
            this.lblEmail.Text = "Email";
            // 
            // tbxNumTelephone
            // 
            this.tbxNumTelephone.Location = new System.Drawing.Point(184, 145);
            this.tbxNumTelephone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxNumTelephone.Name = "tbxNumTelephone";
            this.tbxNumTelephone.Size = new System.Drawing.Size(244, 35);
            this.tbxNumTelephone.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 30);
            this.label1.TabIndex = 47;
            this.label1.Text = "N° téléphone";
            // 
            // tbxPrenom
            // 
            this.tbxPrenom.Location = new System.Drawing.Point(575, 77);
            this.tbxPrenom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxPrenom.Name = "tbxPrenom";
            this.tbxPrenom.Size = new System.Drawing.Size(249, 35);
            this.tbxPrenom.TabIndex = 46;
            // 
            // lblPrénom
            // 
            this.lblPrénom.AutoSize = true;
            this.lblPrénom.Location = new System.Drawing.Point(475, 77);
            this.lblPrénom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrénom.Name = "lblPrénom";
            this.lblPrénom.Size = new System.Drawing.Size(85, 30);
            this.lblPrénom.TabIndex = 45;
            this.lblPrénom.Text = "Prénom";
            // 
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(184, 77);
            this.tbxNom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(244, 35);
            this.tbxNom.TabIndex = 2;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(25, 77);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(59, 30);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 956);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(724, 30);
            this.label3.TabIndex = 51;
            this.label3.Text = "Afin de modifier vos informations, merci de contacter constantin@waview.ch";
            // 
            // FrmParametre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(888, 1021);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblParametre);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmParametre";
            this.Text = "Paramètres";
            this.Load += new System.EventHandler(this.FrmParametre_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblParametre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNouveauMdp;
        private System.Windows.Forms.TextBox txtAncienMdp;
        private System.Windows.Forms.Label lblNouveauMdP;
        private System.Windows.Forms.Label lblAncienMDP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblPrénom;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox tbxNumTelephone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxPrenom;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblSelectionLangue;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label label3;
    }
}