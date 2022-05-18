using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WavContact.Views.Member;
using WavContact.DB;
using WavContact.Models;

using WavContact.Chat;
using System.Diagnostics;

namespace WavContact.Controllers.Waview
{
    public class WaviewChatController
    {
        private FrmWaviewChat frm;
        private List<User> clients;
        private User user;

        private User selectedChat;
        private bool hiddenMode = false;

        public bool HiddenMode { get => hiddenMode; set => hiddenMode = value; }

        public WaviewChatController(FrmWaviewChat a_frm, User u)
        {
            this.frm = a_frm;
            this.user = u;
            this.clients = new List<User>();
            this.selectedChat = null;
        }

        public void ChangeMode()
        {
            this.HiddenMode = !this.HiddenMode;
        }

        public void LoadClients()
        {
            this.clients = WavContactPDO.ClientsNoProjects();

            List<unreadMessages> unread = WavChatPDO.GetUnread(this.user);

            if(unread != null)
            {
                Debug.WriteLine("Unread: " + unread.Count);

                foreach (unreadMessages un in unread)
                {
                    Debug.WriteLine(un.Client_Id + " --> " + un.Total);

                    foreach (User u in this.clients)
                    {
                        if (u.Id == un.Client_Id)
                        {
                            u.Unread = un.Total;
                            break;
                        }
                    }
                }
            }

            this.frm.LoadClientsList(this.clients);
        }

        public void LoadChat(int index)
        {
            this.selectedChat = this.clients[index];
            this.clients[index].Unread = 0;
            this.frm.LoadClientsList(this.clients);
            this.frm.UpdateChatName(this.selectedChat.ToString());
            this.frm.LoadChat(WavChatPDO.GetMessagesForChat(this.user, this.clients[index]));
        }

        public void LoadNewMessages()
        {
            if (this.selectedChat != null)
            {
                List<WavMessage> messages = WavChatPDO.GetNewMessages(this.user, this.selectedChat);

                if (messages != null)
                {
                    foreach (WavMessage item in messages)
                    {
                        this.frm.AppendMessage(item);
                    }
                }
            }
        }

        public void LoadChat()
        {
            this.frm.LoadChat(WavChatPDO.GetMessagesForChat(this.user, this.selectedChat));
        }

        public void SendMessage(string message)
        {
            if (this.selectedChat != null)
            {
                if (this.hiddenMode)
                {
                    this.frm.AppendMessage(WavChatPDO.SendHiddenMessage(this.user, this.selectedChat, message));
                }
                else
                {
                    this.frm.AppendMessage(WavChatPDO.SendMessage(this.user, this.selectedChat, message));
                }
                
            }
            
        }
    }
}
