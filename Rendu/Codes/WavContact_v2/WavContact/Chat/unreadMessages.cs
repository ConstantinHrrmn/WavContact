using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WavContact.Chat
{
    /// <summary>
    /// Unread message permet de stocker tous les messages non-lus d'un client
    /// </summary>
    public class unreadMessages
    {

        private int _client_id;
        private int _total;
        
        /// <summary>
        /// Constructeur vide d'un message non-lu
        /// </summary>
        public unreadMessages()
        {
            
        }

        /// <summary>
        /// Constructeur par défaut d'un UnreadMessage
        /// </summary>
        /// <param name="client_id">l'identifiant du client</param>
        /// <param name="total">le nombre total de messages</param>
        public unreadMessages(int client_id, int total)
        {
            _client_id = client_id;
            _total = total;
        }

        /// <summary>
        /// Affichage des messages non-lus
        /// </summary>
        /// <returns>un string : (0) ou 0 = le nombre de messages non-lus</returns>
        public override string ToString()
        {
            return String.Format("({0})", _total);
        }

        public int Client_Id { get => _client_id; set => _client_id = value; }
        public int Total { get => _total; set => _total = value; }
    }
}
