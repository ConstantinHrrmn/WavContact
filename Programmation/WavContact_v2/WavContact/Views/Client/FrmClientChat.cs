using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WavContact.Chat;
using WavContact.Controllers;
using WavContact.Controllers.Clients;
using WavContact.Metier;
using WavContact.Models;

namespace WavContact.Views.Client
{
    public partial class FrmClientChat : Form
    {

        private static FrmClientChat instance;
        private ClientChatController ctrl;
        
        public FrmClientChat(User u)
        {
            InitializeComponent();
            this.ctrl = new ClientChatController(this, u);
        }

        private void FrmClientChat_Load(object sender, EventArgs e)
        {
            this.SwitchMode();
            this.ctrl.LoadChat();
            
        }

        public void LoadChat(List<WavMessage> messages)
        {
            this.tbxMEssages.Invoke(() => this.tbxMEssages.Text = "");

            if (messages != null)
            {
                foreach (WavMessage item in messages)
                {
                    this.AppendMessage(item);
                }
            }
        }

        public static FrmClientChat GetInstance(User u)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmClientChat(u);
            }
            return instance;
        }

        public void AppendMessage(WavMessage message)
        {
            if (message != null)
            {
                this.tbxMEssages.Invoke(() => this.tbxMEssages.AppendText(message + Environment.NewLine));
            }
            
        }

        

        #region MouseMoving
        private MovingForms mf = new MovingForms();
        private void frm_MouseDown(object sender, MouseEventArgs e)
        {
            this.mf.MouseDown(this.Location);
        }

        private void frm_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.mf.CanDrag())
                this.Location = this.mf.MouseMove(sender, e);
        }

        private void frm_MouseUp(object sender, MouseEventArgs e)
        {
            this.mf.MouseUp();
        }
        #endregion

        /// <summary>
        /// Passage du darkmode au lightmode et vice versa
        /// </summary>
        public void SwitchMode()
        {
            this.BackColor = Darkmode.ChangeMode(this.Controls);
        }

        private void btnSwitchMode_Click(object sender, EventArgs e)
        {
            PropertiesManager.ChangeTheme();
            this.SwitchMode();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
            //this.Close();
        }

        private void ChatTimer_Tick(object sender, EventArgs e)
        {
            Thread t = new Thread(() => this.ctrl.LoadNewMessages());
            t.Start();
        }

        private void btnEnvoye_Click(object sender, EventArgs e)
        {
            this.SendMessage();
        }

        private void SendMessage()
        {
            this.ctrl.SendMessage(this.tbxInput.Text);
            this.tbxInput.Text = "";
        }

        private void FrmClientChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.Continue;
        }

        private void tbxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                this.SendMessage();
            }
        }

        private void tbxInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
