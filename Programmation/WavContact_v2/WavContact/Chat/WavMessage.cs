using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WavContact.Models;

namespace WavContact.Chat
{
    /// <summary>
    /// Représente un message de chat
    /// </summary>
    public class WavMessage
    {
        #region Variables privées
        private int _id;
        private int _groupId;
        private int _senderId;
        private string _deliveryTime;
        private string _content;
        private string _prenom;
        #endregion

        #region Variables publiques
        public int Id { get => _id; set => _id = value; }
        public int GroupId { get => _groupId; set => _groupId = value; }
        public int SenderId { get => _senderId; set => _senderId = value; }
        public string DeliveryTime { get => _deliveryTime; set => _deliveryTime = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public string Content { 
            get => _content; 
            set {

                string fv = "";
                
                // On vérifie que le message ne contient pas des retours à la ligne
                string[] data = value.Split("\\r\\n");
                
                // Si il possède des retours a la ligne
                if (data.Length > 1)
                {
                    // On parcours toutes les lignes
                    foreach (string item in data)
                    {
                        // Si le nombre de caractères dans la ligne est supérieur à 0
                        if (item.Length > 0)
                        {
                            
                            if (item.Split("\\").Length > 0)
                            {
                                fv += "OLALLAALLA :" + item;
                            }
                            else
                                fv += item + Environment.NewLine;
                        }
                            
                    }
                }
                else
                    fv = value;

                // Si le message contient un apostrophe
                if (fv.Contains("\'"))
                    fv = fv.Replace("\\\'", "\'");

                // Le contenu est égal au message mis en forme
                _content = fv;
            }
            
        }
        
        #endregion

        /// <summary>
        /// Constructeur par défaut d'un Message
        /// </summary>
        /// <param name="id">L'id</param>
        /// <param name="groupId">L'identifiant du groupe</param>
        /// <param name="senderId">L'identifiant de l'utilisateur qui à envoyé le message</param>
        /// <param name="deliveryTime">L'heure d'envoi du message</param>
        /// <param name="content">Le contenu du message</param>
        /// <param name="prenom">Le prenom de l'expéditeur</param>
        public WavMessage(int id, int groupId, int senderId, string deliveryTime, string content, string prenom)
        {
            Id = id;
            GroupId = groupId;
            SenderId = senderId;
            DeliveryTime = deliveryTime;
            Content = content;
            Prenom = prenom;
        }

        /// <summary>
        /// Constructeur vide (Pour JSON)
        /// </summary>
        public WavMessage() { }

        /// <summary>
        /// Affichage d'un message
        /// </summary>
        /// <returns>[Heure d'envoi] Prenom - Contenu du message</returns>
        public override string ToString()
        {
            return string.Format("[{0}] {1} - {2}", this.DeliveryTime, this.Prenom, this.Content);
        }
    }
}
