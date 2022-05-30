
namespace WavContact.Views.Client
{
    partial class FrmClientChat
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientChat));
            this.tbxMEssages = new System.Windows.Forms.TextBox();
            this.btnEnvoye = new System.Windows.Forms.Button();
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.ChatTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tbxMEssages
            // 
            this.tbxMEssages.Location = new System.Drawing.Point(12, 12);
            this.tbxMEssages.Multiline = true;
            this.tbxMEssages.Name = "tbxMEssages";
            this.tbxMEssages.ReadOnly = true;
            this.tbxMEssages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxMEssages.Size = new System.Drawing.Size(1042, 633);
            this.tbxMEssages.TabIndex = 3;
            // 
            // btnEnvoye
            // 
            this.btnEnvoye.BackColor = System.Drawing.Color.Black;
            this.btnEnvoye.ForeColor = System.Drawing.Color.White;
            this.btnEnvoye.Location = new System.Drawing.Point(905, 654);
            this.btnEnvoye.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnEnvoye.Name = "btnEnvoye";
            this.btnEnvoye.Size = new System.Drawing.Size(149, 163);
            this.btnEnvoye.TabIndex = 3;
            this.btnEnvoye.Text = "Envoyer";
            this.btnEnvoye.UseVisualStyleBackColor = false;
            this.btnEnvoye.Click += new System.EventHandler(this.btnEnvoye_Click);
            // 
            // tbxInput
            // 
            this.tbxInput.BackColor = System.Drawing.Color.Black;
            this.tbxInput.Location = new System.Drawing.Point(14, 654);
            this.tbxInput.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbxInput.Multiline = true;
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(881, 163);
            this.tbxInput.TabIndex = 1;
            // 
            // ChatTimer
            // 
            this.ChatTimer.Enabled = true;
            this.ChatTimer.Interval = 2500;
            this.ChatTimer.Tick += new System.EventHandler(this.ChatTimer_Tick);
            // 
            // FrmClientChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1066, 825);
            this.Controls.Add(this.tbxMEssages);
            this.Controls.Add(this.btnEnvoye);
            this.Controls.Add(this.tbxInput);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmClientChat";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.FrmClientChat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxMEssages;
        private System.Windows.Forms.Button btnEnvoye;
        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.Timer ChatTimer;
    }
}