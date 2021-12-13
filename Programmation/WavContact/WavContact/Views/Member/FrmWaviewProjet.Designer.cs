
namespace WavContact.Views
{
    partial class FrmProjectWaviewMember
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
            this.lblProjectName = new System.Windows.Forms.Label();
            this.btnOpenChatWaview = new System.Windows.Forms.Button();
            this.lbDocuments = new System.Windows.Forms.ListBox();
            this.lbActivity = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(833, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 29);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProjectName.ForeColor = System.Drawing.Color.White;
            this.lblProjectName.Location = new System.Drawing.Point(12, 12);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(104, 29);
            this.lblProjectName.TabIndex = 6;
            this.lblProjectName.Text = "Projet X";
            // 
            // btnOpenChatWaview
            // 
            this.btnOpenChatWaview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenChatWaview.ForeColor = System.Drawing.Color.White;
            this.btnOpenChatWaview.Location = new System.Drawing.Point(517, 64);
            this.btnOpenChatWaview.Name = "btnOpenChatWaview";
            this.btnOpenChatWaview.Size = new System.Drawing.Size(351, 60);
            this.btnOpenChatWaview.TabIndex = 7;
            this.btnOpenChatWaview.Text = "Ouvrir chat";
            this.btnOpenChatWaview.UseVisualStyleBackColor = true;
            this.btnOpenChatWaview.Click += new System.EventHandler(this.btnOpenChatWaview_Click);
            // 
            // lbDocuments
            // 
            this.lbDocuments.BackColor = System.Drawing.Color.Black;
            this.lbDocuments.ForeColor = System.Drawing.Color.White;
            this.lbDocuments.FormattingEnabled = true;
            this.lbDocuments.ItemHeight = 15;
            this.lbDocuments.Location = new System.Drawing.Point(12, 368);
            this.lbDocuments.Name = "lbDocuments";
            this.lbDocuments.Size = new System.Drawing.Size(499, 154);
            this.lbDocuments.TabIndex = 8;
            // 
            // lbActivity
            // 
            this.lbActivity.BackColor = System.Drawing.Color.Black;
            this.lbActivity.ForeColor = System.Drawing.Color.White;
            this.lbActivity.FormattingEnabled = true;
            this.lbActivity.ItemHeight = 15;
            this.lbActivity.Location = new System.Drawing.Point(517, 368);
            this.lbActivity.Name = "lbActivity";
            this.lbActivity.Size = new System.Drawing.Size(351, 154);
            this.lbActivity.TabIndex = 9;
            // 
            // FrmProjectWaviewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(880, 534);
            this.Controls.Add(this.lbActivity);
            this.Controls.Add(this.lbDocuments);
            this.Controls.Add(this.btnOpenChatWaview);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProjectWaviewMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmProjectWaviewMember";
            this.Load += new System.EventHandler(this.FrmProjectWaviewMember_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Button btnOpenChatWaview;
        private System.Windows.Forms.ListBox lbDocuments;
        private System.Windows.Forms.ListBox lbActivity;
    }
}