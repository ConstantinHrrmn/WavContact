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
    public class WavChatPDO
    {
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

        public static WavMessage SendMessage(User sender, User client, string message)
        {
            message = message.Replace("\'", "\\'");
            message = message.Replace("\r\n", "\\r\\n").Replace("é", "e").Replace("è", "e").Replace("ê", "e").Replace("à", "a").Replace("â", "a").Replace("ô", "o").Replace("î", "i").Replace("ç", "c");

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

        public static WavMessage SendHiddenMessage(User sender, User client, string message)
        {
            message = message.Replace("\'", "\\'");
            message = message.Replace("\r\n", "\\r\\n").Replace("é", "e").Replace("è", "e").Replace("ê", "e").Replace("à", "a").Replace("â", "a").Replace("ô", "o").Replace("î", "i").Replace("ç", "c");

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
    }
}
