using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace WavContact.DB
{
    class WavHash
    {
        /// <summary>
        /// Création d'un hash 256 à partir d'un string
        /// Pour le login : mot de passe non hashé + email
        /// </summary>
        /// <param name="rawData">Le string que l'on souhaite hasher (mdp + email)</param>
        /// <returns>Un string contenant le hash 256</returns>
        public static string ComputeSha256Hash(string rawData)
        {
            // Création du sha 256 
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // On retourne un array de bytes à partir du string
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // A l'aide d'un string builder on convertit le tableau de byte en string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                    builder.Append(bytes[i].ToString("x2"));

                // On retourne le string
                return builder.ToString();
            }
        }
    }
}
