using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WavContact.Chat;
using WavContact.Models;
using WavContact.Views.Client;

namespace WavContact.Controllers.Clients
{
    public class ClientChatController
    {
        private User _connectedUser;
        private FrmClientChat frm;

        public User ConnectedUser { get => _connectedUser; set => _connectedUser = value; }

        public ClientChatController(FrmClientChat a_frm, User connectedUser)
        {
            this.ConnectedUser = connectedUser;
            this.frm = a_frm;
        }

        public void LoadChat()
        {
            this.frm.LoadChat(WavChatPDO.GetMessagesForChat(this.ConnectedUser, this.ConnectedUser));
        }

        public void LoadNewMessages()
        {
            List<WavMessage> messages = WavChatPDO.GetNewMessages(this.ConnectedUser, this.ConnectedUser);

            if (messages != null)
            {
                foreach (WavMessage item in messages)
                {
                    this.frm.AppendMessage(item);
                }
            }
        }

        public void SendMessage(string message)
        {
            this.frm.AppendMessage(WavChatPDO.SendMessage(this.ConnectedUser, this.ConnectedUser, message));
        }
    }
}
