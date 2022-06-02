
namespace WavContact.Views.Client
{
    partial class FrmClientPagePrincipale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientPagePrincipale));
            this.btnSwitchMode = new System.Windows.Forms.Button();
            this.lblMenuPrincipal = new System.Windows.Forms.Label();
            this.lstProjet = new System.Windows.Forms.ListBox();
            this.lblRecapProjet = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnChat = new System.Windows.Forms.Button();
            this.TimerCheckNewMessages = new System.Windows.Forms.Timer(this.components);
            this.btnToday = new System.Windows.Forms.Button();
            this.btnPreviusWeek = new System.Windows.Forms.Button();
            this.btnNextWeek = new System.Windows.Forms.Button();
            this.lbDay6 = new System.Windows.Forms.ListBox();
            this.lblDay6 = new System.Windows.Forms.Label();
            this.lbDay7 = new System.Windows.Forms.ListBox();
            this.lblDay7 = new System.Windows.Forms.Label();
            this.lbDay5 = new System.Windows.Forms.ListBox();
            this.lblDay5 = new System.Windows.Forms.Label();
            this.lbDay3 = new System.Windows.Forms.ListBox();
            this.lblDay3 = new System.Windows.Forms.Label();
            this.lbDay4 = new System.Windows.Forms.ListBox();
            this.lblDay4 = new System.Windows.Forms.Label();
            this.lbDay2 = new System.Windows.Forms.ListBox();
            this.lblDay2 = new System.Windows.Forms.Label();
            this.lblDay1 = new System.Windows.Forms.Label();
            this.lbDay1 = new System.Windows.Forms.ListBox();
            this.CalendarTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnSwitchMode
            // 
            this.btnSwitchMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitchMode.ForeColor = System.Drawing.Color.White;
            this.btnSwitchMode.Location = new System.Drawing.Point(1143, 14);
            this.btnSwitchMode.Margin = new System.Windows.Forms.Padding(4);
            this.btnSwitchMode.Name = "btnSwitchMode";
            this.btnSwitchMode.Size = new System.Drawing.Size(139, 58);
            this.btnSwitchMode.TabIndex = 30;
            this.btnSwitchMode.Text = "Clair";
            this.btnSwitchMode.UseVisualStyleBackColor = true;
            this.btnSwitchMode.Click += new System.EventHandler(this.btnSwitchMode_Click);
            // 
            // lblMenuPrincipal
            // 
            this.lblMenuPrincipal.AutoSize = true;
            this.lblMenuPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.lblMenuPrincipal.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMenuPrincipal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMenuPrincipal.Location = new System.Drawing.Point(16, 14);
            this.lblMenuPrincipal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMenuPrincipal.Name = "lblMenuPrincipal";
            this.lblMenuPrincipal.Size = new System.Drawing.Size(263, 65);
            this.lblMenuPrincipal.TabIndex = 31;
            this.lblMenuPrincipal.Text = "Bonjour X !";
            // 
            // lstProjet
            // 
            this.lstProjet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstProjet.BackColor = System.Drawing.Color.Black;
            this.lstProjet.ForeColor = System.Drawing.Color.White;
            this.lstProjet.FormattingEnabled = true;
            this.lstProjet.ItemHeight = 30;
            this.lstProjet.Location = new System.Drawing.Point(16, 151);
            this.lstProjet.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lstProjet.Name = "lstProjet";
            this.lstProjet.Size = new System.Drawing.Size(371, 694);
            this.lstProjet.TabIndex = 32;
            this.lstProjet.SelectedIndexChanged += new System.EventHandler(this.lstProjet_SelectedIndexChanged);
            // 
            // lblRecapProjet
            // 
            this.lblRecapProjet.AutoSize = true;
            this.lblRecapProjet.Location = new System.Drawing.Point(16, 115);
            this.lblRecapProjet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecapProjet.Name = "lblRecapProjet";
            this.lblRecapProjet.Size = new System.Drawing.Size(235, 30);
            this.lblRecapProjet.TabIndex = 33;
            this.lblRecapProjet.Text = "Récapitulatif des projets";
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(1291, 14);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(261, 58);
            this.btnLogout.TabIndex = 37;
            this.btnLogout.Text = "Déconnexion";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnChat
            // 
            this.btnChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChat.ForeColor = System.Drawing.Color.White;
            this.btnChat.Location = new System.Drawing.Point(761, 14);
            this.btnChat.Margin = new System.Windows.Forms.Padding(4);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(374, 58);
            this.btnChat.TabIndex = 40;
            this.btnChat.Text = "Chat";
            this.btnChat.UseVisualStyleBackColor = true;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // TimerCheckNewMessages
            // 
            this.TimerCheckNewMessages.Enabled = true;
            this.TimerCheckNewMessages.Interval = 2500;
            this.TimerCheckNewMessages.Tick += new System.EventHandler(this.TimerCheckNewMessages_Tick);
            // 
            // btnToday
            // 
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToday.ForeColor = System.Drawing.Color.White;
            this.btnToday.Location = new System.Drawing.Point(1261, 110);
            this.btnToday.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(202, 58);
            this.btnToday.TabIndex = 57;
            this.btnToday.Text = "Aujourd\'hui";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnPreviusWeek
            // 
            this.btnPreviusWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviusWeek.ForeColor = System.Drawing.Color.White;
            this.btnPreviusWeek.Location = new System.Drawing.Point(1172, 110);
            this.btnPreviusWeek.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnPreviusWeek.Name = "btnPreviusWeek";
            this.btnPreviusWeek.Size = new System.Drawing.Size(79, 58);
            this.btnPreviusWeek.TabIndex = 56;
            this.btnPreviusWeek.Text = "<";
            this.btnPreviusWeek.UseVisualStyleBackColor = true;
            this.btnPreviusWeek.Click += new System.EventHandler(this.btnPreviusWeek_Click);
            // 
            // btnNextWeek
            // 
            this.btnNextWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextWeek.ForeColor = System.Drawing.Color.White;
            this.btnNextWeek.Location = new System.Drawing.Point(1473, 110);
            this.btnNextWeek.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnNextWeek.Name = "btnNextWeek";
            this.btnNextWeek.Size = new System.Drawing.Size(79, 58);
            this.btnNextWeek.TabIndex = 55;
            this.btnNextWeek.Text = ">";
            this.btnNextWeek.UseVisualStyleBackColor = true;
            this.btnNextWeek.Click += new System.EventHandler(this.btnNextWeek_Click);
            // 
            // lbDay6
            // 
            this.lbDay6.BackColor = System.Drawing.Color.Black;
            this.lbDay6.ForeColor = System.Drawing.Color.White;
            this.lbDay6.FormattingEnabled = true;
            this.lbDay6.ItemHeight = 30;
            this.lbDay6.Location = new System.Drawing.Point(805, 691);
            this.lbDay6.Name = "lbDay6";
            this.lbDay6.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbDay6.Size = new System.Drawing.Size(352, 154);
            this.lbDay6.TabIndex = 54;
            // 
            // lblDay6
            // 
            this.lblDay6.AutoSize = true;
            this.lblDay6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDay6.ForeColor = System.Drawing.Color.White;
            this.lblDay6.Location = new System.Drawing.Point(822, 637);
            this.lblDay6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDay6.Name = "lblDay6";
            this.lblDay6.Size = new System.Drawing.Size(100, 51);
            this.lblDay6.TabIndex = 53;
            this.lblDay6.Text = "xx.yy";
            // 
            // lbDay7
            // 
            this.lbDay7.BackColor = System.Drawing.Color.Black;
            this.lbDay7.ForeColor = System.Drawing.Color.White;
            this.lbDay7.FormattingEnabled = true;
            this.lbDay7.ItemHeight = 30;
            this.lbDay7.Location = new System.Drawing.Point(1200, 691);
            this.lbDay7.Name = "lbDay7";
            this.lbDay7.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbDay7.Size = new System.Drawing.Size(352, 154);
            this.lbDay7.TabIndex = 52;
            // 
            // lblDay7
            // 
            this.lblDay7.AutoSize = true;
            this.lblDay7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDay7.ForeColor = System.Drawing.Color.White;
            this.lblDay7.Location = new System.Drawing.Point(1217, 637);
            this.lblDay7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDay7.Name = "lblDay7";
            this.lblDay7.Size = new System.Drawing.Size(100, 51);
            this.lblDay7.TabIndex = 51;
            this.lblDay7.Text = "xx.yy";
            // 
            // lbDay5
            // 
            this.lbDay5.BackColor = System.Drawing.Color.Black;
            this.lbDay5.ForeColor = System.Drawing.Color.White;
            this.lbDay5.FormattingEnabled = true;
            this.lbDay5.ItemHeight = 30;
            this.lbDay5.Location = new System.Drawing.Point(412, 691);
            this.lbDay5.Name = "lbDay5";
            this.lbDay5.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbDay5.Size = new System.Drawing.Size(352, 154);
            this.lbDay5.TabIndex = 50;
            // 
            // lblDay5
            // 
            this.lblDay5.AutoSize = true;
            this.lblDay5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDay5.ForeColor = System.Drawing.Color.White;
            this.lblDay5.Location = new System.Drawing.Point(429, 637);
            this.lblDay5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDay5.Name = "lblDay5";
            this.lblDay5.Size = new System.Drawing.Size(100, 51);
            this.lblDay5.TabIndex = 49;
            this.lblDay5.Text = "xx.yy";
            // 
            // lbDay3
            // 
            this.lbDay3.BackColor = System.Drawing.Color.Black;
            this.lbDay3.ForeColor = System.Drawing.Color.White;
            this.lbDay3.FormattingEnabled = true;
            this.lbDay3.ItemHeight = 30;
            this.lbDay3.Location = new System.Drawing.Point(805, 457);
            this.lbDay3.Name = "lbDay3";
            this.lbDay3.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbDay3.Size = new System.Drawing.Size(352, 154);
            this.lbDay3.TabIndex = 48;
            // 
            // lblDay3
            // 
            this.lblDay3.AutoSize = true;
            this.lblDay3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDay3.ForeColor = System.Drawing.Color.White;
            this.lblDay3.Location = new System.Drawing.Point(822, 403);
            this.lblDay3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDay3.Name = "lblDay3";
            this.lblDay3.Size = new System.Drawing.Size(100, 51);
            this.lblDay3.TabIndex = 47;
            this.lblDay3.Text = "xx.yy";
            // 
            // lbDay4
            // 
            this.lbDay4.BackColor = System.Drawing.Color.Black;
            this.lbDay4.ForeColor = System.Drawing.Color.White;
            this.lbDay4.FormattingEnabled = true;
            this.lbDay4.ItemHeight = 30;
            this.lbDay4.Location = new System.Drawing.Point(1200, 457);
            this.lbDay4.Name = "lbDay4";
            this.lbDay4.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbDay4.Size = new System.Drawing.Size(352, 154);
            this.lbDay4.TabIndex = 46;
            // 
            // lblDay4
            // 
            this.lblDay4.AutoSize = true;
            this.lblDay4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDay4.ForeColor = System.Drawing.Color.White;
            this.lblDay4.Location = new System.Drawing.Point(1217, 403);
            this.lblDay4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDay4.Name = "lblDay4";
            this.lblDay4.Size = new System.Drawing.Size(100, 51);
            this.lblDay4.TabIndex = 45;
            this.lblDay4.Text = "xx.yy";
            // 
            // lbDay2
            // 
            this.lbDay2.BackColor = System.Drawing.Color.Black;
            this.lbDay2.ForeColor = System.Drawing.Color.White;
            this.lbDay2.FormattingEnabled = true;
            this.lbDay2.ItemHeight = 30;
            this.lbDay2.Location = new System.Drawing.Point(412, 457);
            this.lbDay2.Name = "lbDay2";
            this.lbDay2.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbDay2.Size = new System.Drawing.Size(352, 154);
            this.lbDay2.TabIndex = 44;
            // 
            // lblDay2
            // 
            this.lblDay2.AutoSize = true;
            this.lblDay2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDay2.ForeColor = System.Drawing.Color.White;
            this.lblDay2.Location = new System.Drawing.Point(429, 403);
            this.lblDay2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDay2.Name = "lblDay2";
            this.lblDay2.Size = new System.Drawing.Size(100, 51);
            this.lblDay2.TabIndex = 43;
            this.lblDay2.Text = "xx.yy";
            // 
            // lblDay1
            // 
            this.lblDay1.AutoSize = true;
            this.lblDay1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDay1.ForeColor = System.Drawing.Color.White;
            this.lblDay1.Location = new System.Drawing.Point(412, 123);
            this.lblDay1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDay1.Name = "lblDay1";
            this.lblDay1.Size = new System.Drawing.Size(152, 51);
            this.lblDay1.TabIndex = 42;
            this.lblDay1.Text = "Demain";
            // 
            // lbDay1
            // 
            this.lbDay1.BackColor = System.Drawing.Color.Black;
            this.lbDay1.ForeColor = System.Drawing.Color.White;
            this.lbDay1.FormattingEnabled = true;
            this.lbDay1.ItemHeight = 30;
            this.lbDay1.Location = new System.Drawing.Point(412, 177);
            this.lbDay1.Name = "lbDay1";
            this.lbDay1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbDay1.Size = new System.Drawing.Size(1140, 214);
            this.lbDay1.TabIndex = 41;
            // 
            // CalendarTimer
            // 
            this.CalendarTimer.Enabled = true;
            this.CalendarTimer.Interval = 3000;
            this.CalendarTimer.Tick += new System.EventHandler(this.CalendarTimer_Tick);
            // 
            // FrmClientPagePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1572, 874);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.btnPreviusWeek);
            this.Controls.Add(this.btnNextWeek);
            this.Controls.Add(this.lbDay6);
            this.Controls.Add(this.lblDay6);
            this.Controls.Add(this.lbDay7);
            this.Controls.Add(this.lblDay7);
            this.Controls.Add(this.lbDay5);
            this.Controls.Add(this.lblDay5);
            this.Controls.Add(this.lbDay3);
            this.Controls.Add(this.lblDay3);
            this.Controls.Add(this.lbDay4);
            this.Controls.Add(this.lblDay4);
            this.Controls.Add(this.lbDay2);
            this.Controls.Add(this.lblDay2);
            this.Controls.Add(this.lblDay1);
            this.Controls.Add(this.lbDay1);
            this.Controls.Add(this.btnChat);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblRecapProjet);
            this.Controls.Add(this.lstProjet);
            this.Controls.Add(this.lblMenuPrincipal);
            this.Controls.Add(this.btnSwitchMode);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmClientPagePrincipale";
            this.Text = "Waview Client";
            this.Load += new System.EventHandler(this.FrmClientPagePrincipale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSwitchMode;
        private System.Windows.Forms.Label lblMenuPrincipal;
        private System.Windows.Forms.ListBox lstProjet;
        private System.Windows.Forms.Label lblRecapProjet;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnChat;
        private System.Windows.Forms.Timer TimerCheckNewMessages;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnPreviusWeek;
        private System.Windows.Forms.Button btnNextWeek;
        private System.Windows.Forms.ListBox lbDay6;
        private System.Windows.Forms.Label lblDay6;
        private System.Windows.Forms.ListBox lbDay7;
        private System.Windows.Forms.Label lblDay7;
        private System.Windows.Forms.ListBox lbDay5;
        private System.Windows.Forms.Label lblDay5;
        private System.Windows.Forms.ListBox lbDay3;
        private System.Windows.Forms.Label lblDay3;
        private System.Windows.Forms.ListBox lbDay4;
        private System.Windows.Forms.Label lblDay4;
        private System.Windows.Forms.ListBox lbDay2;
        private System.Windows.Forms.Label lblDay2;
        private System.Windows.Forms.Label lblDay1;
        private System.Windows.Forms.ListBox lbDay1;
        private System.Windows.Forms.Timer CalendarTimer;
    }
}