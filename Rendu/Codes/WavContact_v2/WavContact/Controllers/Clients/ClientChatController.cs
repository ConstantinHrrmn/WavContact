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
        #region Variables privées
        private User _connectedUser;
        private FrmClientChat frm;
        #endregion

        #region Variables publiques
        public User ConnectedUser { get => _connectedUser; set => _connectedUser = value; }
        #endregion

        /// <summary>
        /// Constructeur de la classe ClientChatController
        /// </summary>
        /// <param name="a_frm">La form mère</param>
        /// <param name="connectedUser">L'utilisateur connecté</param>
        public ClientChatController(FrmClientChat a_frm, User connectedUser)
        {
            this.ConnectedUser = connectedUser;
            this.frm = a_frm;
        }

        /// <summary>
        /// Charge le chat
        /// </summary>
        public void LoadChat()
        {
            this.frm.LoadChat(WavChatPDO.GetMessagesForChat(this.ConnectedUser, this.ConnectedUser));
        }

        /// <summary>
        /// Charge les nouveaux messages
        /// </summary>
        public void LoadNewMessages()
        {
            // On récupère les messages de la BDD
            List<WavMessage> messages = WavChatPDO.GetNewMessages(this.ConnectedUser, this.ConnectedUser);

            // Si les messages ne sont pas null
            if (messages != null)
            {
                foreach (WavMessage item in messages)
                {
                    this.frm.AppendMessage(item);
                }
            }
        }

        /// <summary>
        /// Envoyer un message
        /// </summary>
        /// <param name="message">Le contenu a envoyer</param>
        public void SendMessage(string message)
        {
            this.frm.AppendMessage(WavChatPDO.SendMessage(this.ConnectedUser, this.ConnectedUser, message));
        }
    }
}
