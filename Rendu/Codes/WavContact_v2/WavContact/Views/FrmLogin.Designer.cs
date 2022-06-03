﻿
namespace WavContact
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSwitchMode = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxEmail
            // 
            this.tbxEmail.BackColor = System.Drawing.Color.Black;
            this.tbxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxEmail.ForeColor = System.Drawing.Color.White;
            this.tbxEmail.Location = new System.Drawing.Point(292, 165);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.PlaceholderText = "Adresse email";
            this.tbxEmail.Size = new System.Drawing.Size(416, 45);
            this.tbxEmail.TabIndex = 1;
            this.tbxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxEmail.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
            // 
            // tbxPassword
            // 
            this.tbxPassword.BackColor = System.Drawing.Color.Black;
            this.tbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxPassword.ForeColor = System.Drawing.Color.White;
            this.tbxPassword.Location = new System.Drawing.Point(292, 216);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PlaceholderText = "Mot de passe";
            this.tbxPassword.Size = new System.Drawing.Size(416, 45);
            this.tbxPassword.TabIndex = 2;
            this.tbxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxPassword.UseSystemPasswordChar = true;
            this.tbxPassword.TextChanged += new System.EventHandler(this.tbxPassword_TextChanged);
            this.tbxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPassword_KeyPress);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(530, 287);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(178, 44);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Connexion";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSwitchMode
            // 
            this.btnSwitchMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitchMode.ForeColor = System.Drawing.Color.White;
            this.btnSwitchMode.Location = new System.Drawing.Point(594, 12);
            this.btnSwitchMode.Name = "btnSwitchMode";
            this.btnSwitchMode.Size = new System.Drawing.Size(110, 39);
            this.btnSwitchMode.TabIndex = 8;
            this.btnSwitchMode.Text = "Clair";
            this.btnSwitchMode.UseVisualStyleBackColor = true;
            this.btnSwitchMode.Click += new System.EventHandler(this.btnSwitchMode_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.LinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.Location = new System.Drawing.Point(292, 297);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(146, 27);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Mot de passe oublié ?";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::WavContact.Properties.Resources.Illustration_sans_titre_2;
            this.pbLogo.Location = new System.Drawing.Point(-7, 1);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(724, 451);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 10;
            this.pbLogo.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(720, 447);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnSwitchMode);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.pbLogo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion WavContact";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSwitchMode;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}
