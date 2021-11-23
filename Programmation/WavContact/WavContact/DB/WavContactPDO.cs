using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

using WavContact.Models;

namespace WavContact.DB
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
        private static User LoginAsync(string email, string non_encrypted_password)
        {
            string hashedPassword = WavHash.ComputeSha256Hash(non_encrypted_password + email);

            HttpClient hc = new HttpClient();
            hc.DefaultRequestHeaders.Add("Email", email);
            hc.DefaultRequestHeaders.Add("Password", hashedPassword);
            var response = hc.GetAsync(BASE_URL + "/user/login").Result;

            // On vérifie que le code de retour est bien 200 => OK
            if (response.IsSuccessStatusCode)
            {
                var a = response.Content.ReadAsStringAsync().Result;
                JObject jo = JObject.Parse(a);
                return new User((string)jo["first_name"], (string)jo["last_name"]);
            }

            return null;
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
                return LoginAsync(email, non_encrypted_password);
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        #endregion
    }
}
