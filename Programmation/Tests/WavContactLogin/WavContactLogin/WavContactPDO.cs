using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace WavContactLogin
{
    class WavContactPDO
    {
        private static string BASE_URL = "https://waview.ch/wavcontact/api";

        public static async Task<User> LoginAsync(string email, string non_encrypted_password)
        {
            string hashedPassword = WavHash.ComputeSha256Hash(non_encrypted_password + email);

            HttpClient hc = new HttpClient();
            hc.DefaultRequestHeaders.Add("Email", email);
            hc.DefaultRequestHeaders.Add("Password", hashedPassword);

            var response = await hc.GetAsync(BASE_URL + "/user/login");
            response.EnsureSuccessStatusCode();

            var a = await response.Content.ReadAsStringAsync();

            JObject jo = JObject.Parse(a);
            return new User((string)jo["first_name"], (string)jo["last_name"]);
        }

        
    }
}
