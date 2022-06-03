using Nancy.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using WavContact.DB;
using WavContact.Models;

namespace WavContact.Chat
{
    /// <summary>
    /// Gestionnaire du Chat de WavContact
    /// </summary>
    public class WavChatPDO
    {
        /// <summary>
        /// Récupère le nombre total de messages non-lu pour un utilisateur
        /// </summary>
        /// <param name="user">L'utilisateur pour lequel on veut récupérer le nombre</param>
        /// <returns>Un nombre entier INT</returns>
        public static int GetUnreadMessagesCount(User user)
        {
            string url = WavContactPDO.BASE_URL + "/CHAT/read";

            HttpClient hc = new HttpClient();
            hc.DefaultRequestHeaders.Add("Personne", user.Id.ToString());
            hc.DefaultRequestHeaders.Add("Total", "Total");

            var response = hc.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
            {
                var a = response.Content.ReadAsStringAsync().Result;
                
                JavaScriptSerializer js = new JavaScriptSerializer();

                return js.Deserialize<Int32>(a);
            }

            return 0;
        }

        /// <summary>
        /// Récupère le nombre de messages non-lu par utilisateur de la BDD pour un user (admin)
        /// </summary>
        /// <param name="user">L'utilisateur (admin)</param>
        /// <returns>Une liste de "UnredMessages"</returns>
        public static List<unreadMessages> GetUnread(User user)
        {
            string url = WavContactPDO.BASE_URL + "/CHAT/read";

            HttpClient hc = new HttpClient();
            hc.DefaultRequestHeaders.Add("Personne", user.Id.ToString());

            var response = hc.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
            {
                var a = response.Content.ReadAsStringAsync().Result;

                JavaScriptSerializer js = new JavaScriptSerializer();
                unreadMessages[] tunreadMessages = js.Deserialize<unreadMessages[]>(a);

                List<unreadMessages> unreadMessagesList = new List<unreadMessages>();

                if (tunreadMessages != null)
                {
                    for (int i = 0; i < tunreadMessages.Length; i++)
                    {
                        unreadMessagesList.Add(tunreadMessages[i]);
                    }
                }

                return unreadMessagesList;
            }

            return null;
        }

        /// <summary>
        /// Récupère tous les messages du chat
        /// </summary>
        /// <param name="user">L'utilistateur connecté</param>
        /// <param name="client">Le client (équivalent au chat)</param>
        /// <returns>Retourne une liste de Messages</returns>
        public static List<WavMessage> GetMessagesForChat(User user, User client)
        {
            string url = WavContactPDO.BASE_URL + "/CHAT/read";

            HttpClient hc = new HttpClient();
            hc.DefaultRequestHeaders.Add("Personne", user.Id.ToString());
            hc.DefaultRequestHeaders.Add("Client", client.Id.ToString());

            var response = hc.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
            {
                var a = response.Content.ReadAsStringAsync().Result;

                JavaScriptSerializer js = new JavaScriptSerializer();
                WavMessage[] tmessages = js.Deserialize<WavMessage[]>(a);

                List<WavMessage> messages = new List<WavMessage>();

                if (tmessages != null && tmessages.Length > 0)
                {
                    for (int i = 0; i < tmessages.Length; i++)
                    {
                        messages.Add(tmessages[i]);
                    }

                    return messages;
                }

            }

            return null;
        }

        /// <summary>
        /// Récupère les nouveaux messages d'une conversation
        /// </summary>
        /// <param name="user">L'utilisateur connecté</param>
        /// <param name="client">Le client (équivalent au chat)</param>
        /// <returns>Une liste de Messages</returns>
        public static List<WavMessage> GetNewMessages(User user, User client)
        {
            string url = WavContactPDO.BASE_URL + "/CHAT/read";

            HttpClient hc = new HttpClient();
            hc.DefaultRequestHeaders.Add("Personne", user.Id.ToString());
            hc.DefaultRequestHeaders.Add("Client", client.Id.ToString());
            hc.DefaultRequestHeaders.Add("New", "New");

            var response = hc.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
            {
                var a = response.Content.ReadAsStringAsync().Result;

                JavaScriptSerializer js = new JavaScriptSerializer();
                WavMessage[] tmessages = js.Deserialize<WavMessage[]>(a);

                List<WavMessage> messages = new List<WavMessage>();

                if (tmessages != null && tmessages.Length > 0)
                {
                    for (int i = 0; i < tmessages.Length; i++)
                    {
                        messages.Add(tmessages[i]);
                    }

                    return messages;
                }

            }

            return null;
        }

        /// <summary>
        /// Récupère un message en fonction de son ID
        /// </summary>
        /// <param name="id">l'id du message</param>
        /// <returns>Un WavMessage contenant le message</returns>
        public static WavMessage GetMessageById(int id)
        {
            string url = WavContactPDO.BASE_URL + "/CHAT/read";

            HttpClient hc = new HttpClient();
            hc.DefaultRequestHeaders.Add("Id", id.ToString());
            
            var response = hc.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
            {
                var a = response.Content.ReadAsStringAsync().Result;

                JavaScriptSerializer js = new JavaScriptSerializer();

                return js.Deserialize<WavMessage>(a);
            }

            return null;
        }

        /// <summary>
        /// Envoie d'un message dans le chat
        /// </summary>
        /// <param name="sender">L'utilisateur qui envoie le message</param>
        /// <param name="client">Le client (qui est équivalent au chat)</param>
        /// <param name="message">Le texte que l'on souhaite envoyer</param>
        /// <returns>Le message envoyé</returns>
        public static WavMessage SendMessage(User sender, User client, string message)
        {
            // On met en forme le message afin d'éviter des erreurs
            message = FormatMessage(message);

            if (message.Length > 0 )
            {
                string url = WavContactPDO.BASE_URL + "/CHAT/send";

                HttpClient hc = new HttpClient();
                hc.DefaultRequestHeaders.Add("Sender", sender.Id.ToString());
                hc.DefaultRequestHeaders.Add("Group", client.Id.ToString());
                hc.DefaultRequestHeaders.Add("Content", message);

                var response = hc.GetAsync(url).Result;

                if (response.IsSuccessStatusCode)
                {
                    var a = response.Content.ReadAsStringAsync().Result;
                    JavaScriptSerializer js = new JavaScriptSerializer();

                    int id = js.Deserialize<Int32>(a);
                    return GetMessageById(id);
                }
            }
            return null;
        }

        /// <summary>
        /// Envoie d'un message caché uniquement visible par les membre Waview
        /// </summary>
        /// <param name="sender">L'utilisateur qui envoie le message</param>
        /// <param name="client">Le client (qui est équivalent au chat)</param>
        /// <param name="message">Le texte que l'on souhaite envoyer</param>
        /// <returns>Le message envoyé</returns>
        public static WavMessage SendHiddenMessage(User sender, User client, string message)
        {
            // On met en forme le message afin d'éviter des erreurs
            message = FormatMessage(message);

            if (message.Length > 0)
            {
                string url = WavContactPDO.BASE_URL + "/CHAT/send";

                HttpClient hc = new HttpClient();
                hc.DefaultRequestHeaders.Add("Sender", sender.Id.ToString());
                hc.DefaultRequestHeaders.Add("Group", client.Id.ToString());
                hc.DefaultRequestHeaders.Add("Content", message);
                hc.DefaultRequestHeaders.Add("Hidden", "Hidden");

                var response = hc.GetAsync(url).Result;

                if (response.IsSuccessStatusCode)
                {
                    var a = response.Content.ReadAsStringAsync().Result;
                    JavaScriptSerializer js = new JavaScriptSerializer();

                    int id = js.Deserialize<Int32>(a);
                    return GetMessageById(id);
                }
            }
            

            return null;
        }

        /// <summary>
        /// Permet de remettre en forme un message afin d'éviter des erreurs d'encodage
        /// </summary>
        /// <param name="message">Le message a mettre en forme</param>
        /// <returns>Le message (string) mis en forme</returns>
        public static string FormatMessage(string message)
        {
            message = message.Replace("\'", "\\'");
            message = message.Replace("\r\n", "\\r\\n").Replace("é", "e").Replace("è", "e").Replace("ê", "e").Replace("à", "a").Replace("â", "a").Replace("ô", "o").Replace("î", "i").Replace("ç", "c");
            return message;
        }
    }
}
