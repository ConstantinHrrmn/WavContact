using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WavContact.Models;

namespace WavContact.Chat
{
    public class WavMessage
    {
        private int _id;
        private int _groupId;
        private int _senderId;
        private string _deliveryTime;
        private string _content;

        private string _prenom;

        public int Id { get => _id; set => _id = value; }
        public int GroupId { get => _groupId; set => _groupId = value; }
        public int SenderId { get => _senderId; set => _senderId = value; }
        public string DeliveryTime { get => _deliveryTime; set => _deliveryTime = value; }
        public string Content { 
            get => _content; 
            set {
                _content = value;

                string fv = "";
                
                string[] data = this._content.Split("\\r\\n");
                if (data.Length > 1)
                {
                    foreach (string item in data)
                    {
                        if (item.Length > 0)
                            fv += item + Environment.NewLine;
                    }

                    _content = fv;
                }
            }
            
        }
        public string Prenom { get => _prenom; set => _prenom = value; }

        public WavMessage(int id, int groupId, int senderId, string deliveryTime, string content, string prenom)
        {
            Id = id;
            GroupId = groupId;
            SenderId = senderId;
            DeliveryTime = deliveryTime;
            
            Content = content;

            
            
            Prenom = prenom;
        }

        public WavMessage() { }

        public override string ToString()
        {
            return string.Format("[{0}] {1} - {2}", this.DeliveryTime, this.Prenom, this.Content);
        }
    }
}
