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
    public class WavContactPDO
    {
        #region VARIABLES
        private static string BASE_URL = "https://waview.ch/wavcontact/api";
        #endregion

        #region PRIVEES

        /// <summary>
        /// Faire le login PRIVER d'une personne sur le serveur de WavContact
        /// </summary>
        /// <param name="email">L'email de l'utilisateur</param>
        /// <param name="non_encrypted_password">Le mot de passe brut de l'utilisateur</param>
        /// <returns>L'utilisateur si il est connecté, null si non</returns>
        private static async Task<User> LoginAsync(string email, string non_encrypted_password)
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

        #endregion

        #region PUBLIQUES

        /// <summary>
        /// Login utilisateur WavContact
        /// </summary>
        /// <param name="email">L'email de l'utilisateur</param>
        /// <param name="non_encrypted_password">Le mot de passe de l'utilisateur</param>
        /// <returns>User si il est trouvé, NULL si le login à échoué</returns>
        public static User Login(string email, string non_encrypted_password)
        {
            try
            {
                return LoginAsync(email, non_encrypted_password).Result;
            }
            catch (Exception ex)
            {
                return null;
            }
            
        }

        #endregion
    }
}
