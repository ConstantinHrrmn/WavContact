
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
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSwitchMode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxEmail
            // 
            this.tbxEmail.BackColor = System.Drawing.Color.Black;
            this.tbxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxEmail.ForeColor = System.Drawing.Color.White;
            this.tbxEmail.Location = new System.Drawing.Point(79, 184);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.PlaceholderText = "Email";
            this.tbxEmail.Size = new System.Drawing.Size(308, 22);
            this.tbxEmail.TabIndex = 1;
            this.tbxEmail.Text = "constantin@waview.ch";
            this.tbxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxEmail.TextChanged += new System.EventHandler(this.textBoxes_TextChanged);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::WavContact.Properties.Resources.blanc_vide_full;
            this.pbLogo.Location = new System.Drawing.Point(79, 52);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(309, 92);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // tbxPassword
            // 
            this.tbxPassword.BackColor = System.Drawing.Color.Black;
            this.tbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxPassword.ForeColor = System.Drawing.Color.White;
            this.tbxPassword.Location = new System.Drawing.Point(80, 227);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PlaceholderText = "Password";
            this.tbxPassword.Size = new System.Drawing.Size(308, 22);
            this.tbxPassword.TabIndex = 2;
            this.tbxPassword.Text = "motdepasse";
            this.tbxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(160, 305);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(146, 34);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(429, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 29);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSwitchMode
            // 
            this.btnSwitchMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitchMode.ForeColor = System.Drawing.Color.White;
            this.btnSwitchMode.Location = new System.Drawing.Point(364, 12);
            this.btnSwitchMode.Name = "btnSwitchMode";
            this.btnSwitchMode.Size = new System.Drawing.Size(59, 29);
            this.btnSwitchMode.TabIndex = 8;
            this.btnSwitchMode.Text = "Light";
            this.btnSwitchMode.UseVisualStyleBackColor = true;
            this.btnSwitchMode.Click += new System.EventHandler(this.btnSwitchMode_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(476, 362);
            this.Controls.Add(this.btnSwitchMode);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.tbxEmail);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login WavContact";
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
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSwitchMode;
    }
}

