using System;
using System.Collections.Generic;
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
                return new User((string)jo["first_name"], (string)jo["last_name"], Convert.ToInt32((string)jo["idRole"]));
            }

            return null;
        }

        private static bool CreateUserAsync(string nom, string prenom, string role, string tel, string email, string mdp)
        {
            string hashedPassword = WavHash.ComputeSha256Hash(mdp + email);

            Console.WriteLine("Hash : " + hashedPassword);

            HttpClient hc = new HttpClient();
            hc.DefaultRequestHeaders.Add("Email", email);
            hc.DefaultRequestHeaders.Add("Password", hashedPassword);
            hc.DefaultRequestHeaders.Add("Nom", nom);
            hc.DefaultRequestHeaders.Add("Prenom", prenom);
            hc.DefaultRequestHeaders.Add("Role", role);
            hc.DefaultRequestHeaders.Add("Tel", tel);

            var response = hc.GetAsync(BASE_URL + "/user/create").Result;

            // On vérifie que le code de retour est bien 200 => OK
            return (response.IsSuccessStatusCode);
        }

        private static List<Project> GetProjectsForUser(User u)
        {
            List<Project> projects = new List<Project>();
            Random rnd = new Random();

            for (int i = 0; i < rnd.Next(10); i++)
                projects.Add(new Project(string.Format("Projet de {0} n°{1}", u.Firstname, i)));

            return projects;
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

        public static User CreateUser(string nom, string prenom, string role, string tel, string email, string mdp)
        {
            try
            {
                if (CreateUserAsync(nom, prenom, role, tel, email, mdp))
                    return LoginAsync(email, mdp);
                else
                    return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static List<User> Clients()
        {
            List<User> users = new List<User>();
            Random rnd = new Random();

            for (int i = 0; i < rnd.Next(5,20); i++)
            {
                User u = new User(GenerateName(rnd.Next(5, 10)), GenerateName(rnd.Next(5, 10)), 3);
                u.Projets = GetProjectsForUser(u);
                users.Add(u);
            }

            return users;
        }

        public static string GenerateName(int len)
        {
            Random r = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
            string Name = "";
            Name += consonants[r.Next(consonants.Length)].ToUpper();
            Name += vowels[r.Next(vowels.Length)];
            int b = 2; //b tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.
            while (b < len)
            {
                Name += consonants[r.Next(consonants.Length)];
                b++;
                Name += vowels[r.Next(vowels.Length)];
                b++;
            }

            return Name;


        }



        #endregion
    }
}
