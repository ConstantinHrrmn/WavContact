namespace WavContact.Views
{
    partial class FrmReviewClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReviewClients));
            this.lstListeClients = new System.Windows.Forms.ListBox();
            this.t_update = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lstListeClients
            // 
            this.lstListeClients.BackColor = System.Drawing.Color.Black;
            this.lstListeClients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstListeClients.ForeColor = System.Drawing.Color.White;
            this.lstListeClients.FormattingEnabled = true;
            this.lstListeClients.ItemHeight = 30;
            this.lstListeClients.Items.AddRange(new object[] {
            "Client 1",
            "Client 2",
            "Client 3"});
            this.lstListeClients.Location = new System.Drawing.Point(14, 15);
            this.lstListeClients.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lstListeClients.Name = "lstListeClients";
            this.lstListeClients.Size = new System.Drawing.Size(434, 692);
            this.lstListeClients.TabIndex = 22;
            this.lstListeClients.SelectedIndexChanged += new System.EventHandler(this.lstListeClients_SelectedIndexChanged);
            // 
            // t_update
            // 
            this.t_update.Enabled = true;
            this.t_update.Interval = 5000;
            this.t_update.Tick += new System.EventHandler(this.t_update_Tick);
            // 
            // FrmReviewClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(462, 729);
            this.Controls.Add(this.lstListeClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReviewClients";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nouveaux clients";
            this.Load += new System.EventHandler(this.FrmReviewClients_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstListeClients;
        private System.Windows.Forms.Timer t_update;
    }
}