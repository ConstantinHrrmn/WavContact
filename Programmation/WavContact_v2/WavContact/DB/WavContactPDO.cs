using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Newtonsoft.Json.Linq;

using WavContact.Models;
using WavContact.Metier;
using Nancy.Json;

namespace WavContact.DB
{
    public class WavContactPDO
    {
        #region VARIABLES
        private static string BASE_URL = "https://waview.ch/wavcontact/apiv2";
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

            Debug.WriteLine(hashedPassword);

            Debug.WriteLine("email : " + email);
            Debug.WriteLine("pass : " + hashedPassword);

            HttpClient hc = new HttpClient();
            hc.DefaultRequestHeaders.Add("Login", "hey");
            hc.DefaultRequestHeaders.Add("Email", email);
            hc.DefaultRequestHeaders.Add("Password", hashedPassword);

            var response = hc.GetAsync(BASE_URL + "/PERSONNE/read").Result;

            Debug.WriteLine(response);

            
            // On vérifie que le code de retour est bien 200 => OK
            if (response.IsSuccessStatusCode)
            {
                var a = response.Content.ReadAsStringAsync().Result;
                Debug.WriteLine(a);
                JObject jo = JObject.Parse(a);
                return new User(Convert.ToInt32((string)jo["id"]), (string)jo["email"], (string)jo["first_name"], (string)jo["last_name"], Convert.ToInt32((string)jo["roleNumber"]), (string)jo["phone"]);
            }
            

            return null;
        }

        private static List<Project> GetProjectsForUser(User u)
        {
            HttpClient hc = new HttpClient();
            hc.DefaultRequestHeaders.Add("Userid", u.Id.ToString());

            var response = hc.GetAsync(BASE_URL + "/PROJET/read").Result;

            // On vérifie que le code de retour est bien 200 => OK
            if (response.IsSuccessStatusCode)
            {
                var a = response.Content.ReadAsStringAsync().Result;
                //JObject jo = JObject.Parse(a);
                JavaScriptSerializer js = new JavaScriptSerializer();
                Project[] p = js.Deserialize<Project[]>(a);

                List<Project> projects = new List<Project>();

                foreach (Project item in p)
                {
                    projects.Add(item);
                }

                return projects;

            }

            return null;
        }

        /// <summary>
        /// Récupère tous les utilisateurs de la BDD
        /// </summary>
        /// <returns>Une liste d'utilisateurs</returns>
        private static List<User> GetAllClients()
        {
            HttpClient hc = new HttpClient();
            hc.DefaultRequestHeaders.Add("All", "yes");

            var response = hc.GetAsync(BASE_URL + "/CLIENT/read").Result;

            // On vérifie que le code de retour est bien 200 => OK
            if (response.IsSuccessStatusCode)
            {
                var a = response.Content.ReadAsStringAsync().Result;
                JavaScriptSerializer js = new JavaScriptSerializer();
                User[] persons = js.Deserialize<User[]>(a);

                List<User> clients = new List<User>();

                foreach (User item in persons)
                {
                    item.Projets = GetProjectsForUser(item);
                    clients.Add(item);
                }

                return clients;
            }

            return null;
        }

        private static List<Materiel> GetAllMateriel()
        {
            HttpClient hc = new HttpClient();
            hc.DefaultRequestHeaders.Add("All", "all");

            var response = hc.GetAsync(BASE_URL + "/MATERIEL/read").Result;

            if (response.IsSuccessStatusCode)
            {
                var a = response.Content.ReadAsStringAsync().Result;
                JavaScriptSerializer js = new JavaScriptSerializer();
                Materiel[] matos = js.Deserialize<Materiel[]>(a);
                //User[] persons = js.Deserialize<User[]>(a);

                //List<User> clients = new List<User>();
                List<Materiel> materiel = new List<Materiel>();

                foreach (Materiel item in matos)
                    materiel.Add(item);

                return materiel;
            }

            return null;
        }

        private static List<CategorieMateriel> GetAllCategories()
        {
            HttpClient hc = new HttpClient();
            hc.DefaultRequestHeaders.Add("All", "all");

            var response = hc.GetAsync(BASE_URL + "/CATEGORIE/read").Result;

            if (response.IsSuccessStatusCode)
            {
                var a = response.Content.ReadAsStringAsync().Result;
                JavaScriptSerializer js = new JavaScriptSerializer();
                CategorieMateriel[] cate = js.Deserialize<CategorieMateriel[]>(a);
                //User[] persons = js.Deserialize<User[]>(a);

                //List<User> clients = new List<User>();
                List<CategorieMateriel> categories = new List<CategorieMateriel>();

                foreach (CategorieMateriel item in cate)
                    categories.Add(item);

                return categories;
            }

            return null;
        }

        private static User NewUser(User u)
        {
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

        public static List<User> Clients()
        {
            return GetAllClients();
        }

        public static List<Materiel> GetMateriel()
        {
            return GetAllMateriel();
        }

        public static List<CategorieMateriel> GetCategories()
        {
            return GetAllCategories();
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

        public static string GenerateCode(int len)
        {
            Random r = new Random();
            string[] consonants = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string Name = "";
            int b = 0; //b tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.
            while (b < len)
            {
                Name += consonants[r.Next(consonants.Length)];
                b++;
            }

            return Name;
        }

        /// <summary>
        /// Permet d'envoyer un code par mail à l'utilisateur afin de pouvoir réinitialiser son mot de passe
        /// </summary>
        /// <param name="u">L'utilisateur à qui on souahite enovoyer le code</param>
        /// <returns>Le code attendu par l'application / celui envoyé au client</returns>
        public static int SendCodeEmail(string email)
        {
            string code = GenerateCode(4);
            Debug.WriteLine(string.Format("Email => {0} || Code => {1}", email, code));
            Mailing.SendMail(email);
            return 0;
        }

        #endregion
    }
}
