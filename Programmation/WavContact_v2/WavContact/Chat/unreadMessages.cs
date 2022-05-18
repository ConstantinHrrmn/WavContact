using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WavContact.Chat
{
    public class unreadMessages
    {

        private int _client_id;
        private int _total;
        public unreadMessages()
        {
            
        }

        public unreadMessages(int client_id, int total)
        {
            _client_id = client_id;
            _total = total;
        }

        public override string ToString()
        {
            return String.Format("({0})", _total);
        }

        public int Client_Id { get => _client_id; set => _client_id = value; }
        public int Total { get => _total; set => _total = value; }
    }
}
