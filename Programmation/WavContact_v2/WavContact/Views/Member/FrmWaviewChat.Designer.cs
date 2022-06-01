
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWaviewChat));
            this.lstListeClient = new System.Windows.Forms.ListBox();
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.btnEnvoye = new System.Windows.Forms.Button();
            this.tbxMEssages = new System.Windows.Forms.TextBox();
            this.ChatTimer = new System.Windows.Forms.Timer(this.components);
            this.IncomeTimer = new System.Windows.Forms.Timer(this.components);
            this.lblChat = new System.Windows.Forms.Label();
            this.btnMode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstListeClient
            // 
            this.lstListeClient.BackColor = System.Drawing.Color.Black;
            this.lstListeClient.ForeColor = System.Drawing.Color.White;
            this.lstListeClient.FormattingEnabled = true;
            this.lstListeClient.ItemHeight = 30;
            this.lstListeClient.Location = new System.Drawing.Point(20, 24);
            this.lstListeClient.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lstListeClient.Name = "lstListeClient";
            this.lstListeClient.Size = new System.Drawing.Size(371, 1534);
            this.lstListeClient.TabIndex = 10;
            this.lstListeClient.SelectedIndexChanged += new System.EventHandler(this.lstListeClient_SelectedIndexChanged);
            // 
            // tbxInput
            // 
            this.tbxInput.BackColor = System.Drawing.Color.Black;
            this.tbxInput.Location = new System.Drawing.Point(404, 1395);
            this.tbxInput.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbxInput.Multiline = true;
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(556, 163);
            this.tbxInput.TabIndex = 11;
            this.tbxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxInput_KeyPress);
            // 
            // btnEnvoye
            // 
            this.btnEnvoye.BackColor = System.Drawing.Color.Black;
            this.btnEnvoye.ForeColor = System.Drawing.Color.White;
            this.btnEnvoye.Location = new System.Drawing.Point(973, 1468);
            this.btnEnvoye.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnEnvoye.Name = "btnEnvoye";
            this.btnEnvoye.Size = new System.Drawing.Size(149, 90);
            this.btnEnvoye.TabIndex = 12;
            this.btnEnvoye.Text = "Envoyer";
            this.btnEnvoye.UseVisualStyleBackColor = false;
            this.btnEnvoye.Click += new System.EventHandler(this.btnEnvoye_Click);
            // 
            // tbxMEssages
            // 
            this.tbxMEssages.Location = new System.Drawing.Point(404, 77);
            this.tbxMEssages.Multiline = true;
            this.tbxMEssages.Name = "tbxMEssages";
            this.tbxMEssages.ReadOnly = true;
            this.tbxMEssages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxMEssages.Size = new System.Drawing.Size(718, 1309);
            this.tbxMEssages.TabIndex = 13;
            // 
            // ChatTimer
            // 
            this.ChatTimer.Enabled = true;
            this.ChatTimer.Interval = 1500;
            this.ChatTimer.Tick += new System.EventHandler(this.ChatTimer_Tick);
            // 
            // IncomeTimer
            // 
            this.IncomeTimer.Enabled = true;
            this.IncomeTimer.Interval = 2000;
            this.IncomeTimer.Tick += new System.EventHandler(this.IncomeTimer_Tick);
            // 
            // lblChat
            // 
            this.lblChat.AutoSize = true;
            this.lblChat.Font = new System.Drawing.Font("Segoe UI", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChat.ForeColor = System.Drawing.Color.White;
            this.lblChat.Location = new System.Drawing.Point(404, 24);
            this.lblChat.Name = "lblChat";
            this.lblChat.Size = new System.Drawing.Size(225, 50);
            this.lblChat.TabIndex = 14;
            this.lblChat.Text = "CHAT NAME";
            // 
            // btnMode
            // 
            this.btnMode.BackColor = System.Drawing.Color.Black;
            this.btnMode.ForeColor = System.Drawing.Color.White;
            this.btnMode.Location = new System.Drawing.Point(973, 1395);
            this.btnMode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(149, 61);
            this.btnMode.TabIndex = 15;
            this.btnMode.Text = "Public";
            this.btnMode.UseVisualStyleBackColor = false;
            this.btnMode.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // FrmWaviewChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1157, 1579);
            this.Controls.Add(this.btnMode);
            this.Controls.Add(this.lblChat);
            this.Controls.Add(this.tbxMEssages);
            this.Controls.Add(this.btnEnvoye);
            this.Controls.Add(this.tbxInput);
            this.Controls.Add(this.lstListeClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "FrmWaviewChat";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chats";
            this.Load += new System.EventHandler(this.FrmWaviewChat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstListeClient;
        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.Button btnEnvoye;
        private System.Windows.Forms.TextBox tbxMEssages;
        private System.Windows.Forms.Timer ChatTimer;
        private System.Windows.Forms.Timer IncomeTimer;
        private System.Windows.Forms.Label lblChat;
        private System.Windows.Forms.Button btnMode;
    }
}