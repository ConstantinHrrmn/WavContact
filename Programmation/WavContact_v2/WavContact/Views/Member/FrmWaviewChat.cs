using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WavContact.Controllers.Waview;
using WavContact.Metier;
using WavContact.Models;

using WavContact.Chat;
using System.Threading;
using System.Diagnostics;

namespace WavContact.Views.Member
{
    public partial class FrmWaviewChat : Form
    {
        private WaviewChatController wcc;
        private User user;

        public FrmWaviewChat(User u)
        {
            InitializeComponent();
            this.wcc = new WaviewChatController(this, u);
        }

        
        private void FrmWaviewChat_Load(object sender, EventArgs e)
        {
            this.SwitchMode();

            this.btnMode.ForeColor = Color.Green;
            this.btnMode.Text = "Visible";
            
            this.wcc.LoadClients();
        }


        public void LoadClientsList(List<User> clients)
        {
            try
            {
                this.lstListeClient.Invoke(() =>
                {
                    this.lstListeClient.Items.Clear();
                    foreach (User u in clients)
                    {
                        this.lstListeClient.Items.Add(u.ToChatList());
                    }
                });
            }
            catch (Exception)
            {

                
            }
            
        }

        /// <summary>
        /// Passage du darkmode au lightmode et vice versa
        /// </summary>
        public void SwitchMode()
        {
            this.BackColor = Darkmode.ChangeMode(this.Controls);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadChat(List<WavMessage> messages)
        {
            this.tbxMEssages.Invoke(() => this.tbxMEssages.Text = "");

            if (messages != null)
            {
                foreach (WavMessage item in messages)
                {
                    this.tbxMEssages.Invoke(() => this.tbxMEssages.AppendText(item + Environment.NewLine));
                }
            } 
        }

        public void UpdateChatName(string text)
        {
            this.lblChat.Invoke(() => this.lblChat.Text = text);
        }

        public void AppendMessage(WavMessage message)
        {
            this.tbxMEssages.Invoke(() => this.tbxMEssages.AppendText(message + Environment.NewLine));
        }

        private void lstListeClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstListeClient.SelectedIndex;
            if (index != -1)
            {
                this.wcc.LoadChat(index);
                this.ChatTimer.Start();
            }
        }

        private void btnEnvoye_Click(object sender, EventArgs e)
        {
            this.wcc.SendMessage(this.tbxInput.Text);
            this.tbxInput.Text = "";
        }

        private void IncomeTimer_Tick(object sender, EventArgs e)
        {
            Thread t = new Thread(() => this.wcc.LoadClients());
            t.Start();
        }

        private void ChatTimer_Tick(object sender, EventArgs e)
        {
            Thread t = new Thread(() => this.wcc.LoadNewMessages());
            t.Start();
        }

        private void btnMode_Click(object sender, EventArgs e)
        {
            this.wcc.ChangeMode();
            if (this.wcc.HiddenMode)
            {
                this.btnMode.ForeColor = Color.Red;
                this.btnMode.Text = "Caché";
                tbxInput.ForeColor = Color.Red;
            }
            else
            {
                this.btnMode.ForeColor = Color.Green;
                this.btnMode.Text = "Visible";

                if (this.BackColor == Color.Black)
                {
                    this.tbxInput.ForeColor = Color.White;
                }
                else
                {
                    this.tbxInput.ForeColor = Color.Black;
                }
            }
            
            
        }
    }
}
