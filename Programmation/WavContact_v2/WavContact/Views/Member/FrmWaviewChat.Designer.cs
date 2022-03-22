
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
            this.txtListeMessage = new System.Windows.Forms.TextBox();
            this.lstListeClient = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEnvoye = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtListeMessage
            // 
            this.txtListeMessage.BackColor = System.Drawing.Color.Black;
            this.txtListeMessage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtListeMessage.ForeColor = System.Drawing.Color.White;
            this.txtListeMessage.Location = new System.Drawing.Point(337, 20);
            this.txtListeMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtListeMessage.Multiline = true;
            this.txtListeMessage.Name = "txtListeMessage";
            this.txtListeMessage.ReadOnly = true;
            this.txtListeMessage.Size = new System.Drawing.Size(597, 1151);
            this.txtListeMessage.TabIndex = 8;
            // 
            // lstListeClient
            // 
            this.lstListeClient.BackColor = System.Drawing.Color.Black;
            this.lstListeClient.ForeColor = System.Drawing.Color.White;
            this.lstListeClient.FormattingEnabled = true;
            this.lstListeClient.ItemHeight = 25;
            this.lstListeClient.Location = new System.Drawing.Point(17, 20);
            this.lstListeClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstListeClient.Name = "lstListeClient";
            this.lstListeClient.Size = new System.Drawing.Size(310, 1279);
            this.lstListeClient.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(337, 1248);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(464, 51);
            this.textBox1.TabIndex = 11;
            // 
            // btnEnvoye
            // 
            this.btnEnvoye.BackColor = System.Drawing.Color.Black;
            this.btnEnvoye.ForeColor = System.Drawing.Color.White;
            this.btnEnvoye.Location = new System.Drawing.Point(811, 1248);
            this.btnEnvoye.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnvoye.Name = "btnEnvoye";
            this.btnEnvoye.Size = new System.Drawing.Size(124, 53);
            this.btnEnvoye.TabIndex = 12;
            this.btnEnvoye.Text = "Envoyer";
            this.btnEnvoye.UseVisualStyleBackColor = false;
            // 
            // FrmWaviewChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(964, 1050);
            this.Controls.Add(this.btnEnvoye);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lstListeClient);
            this.Controls.Add(this.txtListeMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.TextBox txtListeMessage;
        private System.Windows.Forms.ListBox lstListeClient;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEnvoye;
    }
}