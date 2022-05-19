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
        public static string BASE_URL = "https://waview.ch/wavcontact/apiv2";
        #endregion

        #region SECURITY

        /// <summary>
        /// Permet de mettre a jour le mot de passe d'un utilisateur avec son email
        /// </summary>
        /// <param name="email">l'email de l'utilisateur</param>
        /// <param name="non_encrypted_password">le mot de passe non encrypté</param>
        /// <returns>True si le mot de passe a bien été changé, False si non</returns>
        public static bool ResetUserPassword(string email, string non_encrypted_password)
        {
            string hashedPassword = WavHash.ComputeSha256Hash(non_encrypted_password + email);

            HttpClient hc = new HttpClient();
            hc.DefaultRequestHeaders.Add("Reset", "password");
            hc.DefaultRequestHeaders.Add("Email", email);
            hc.DefaultRequestHeaders.Add("Password", hashedPassword);

            var response = hc.GetAsync(BASE_URL + "/PERSONNE/update/").Result;

            if (response.IsSuccessStatusCode)
            {
                var a = response.Content.ReadAsStringAsync().Result;
                Debug.WriteLine(a);

                return a == "true";
            }

            return false;
        }

        /// <summary>
        /// Permet d'envoyer un code par mail à l'utilisateur afin de pouvoir réinitialiser son mot de passe
        /// </summary>
        /// <param name="u">L'utilisateur à qui on souahite enovoyer le code</param>
        /// <returns>Le code attendu par l'application / celui envoyé au client</returns>
        public static string SendCodeEmail(string email)
        {
            string code = GenerateCode(6);

            Debug.WriteLine(string.Format("Email => {0} || Code => {1}", email, code));
            Mailing.SendMail(email, code);

            return code;
        }

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
                    Debug.WriteLine(jo["roleNumber"]);
                    return new User(Convert.ToInt32((string)jo["id"]), (string)jo["email"], (string)jo["first_name"], (string)jo["last_name"], Convert.ToInt32((string)jo["roleNumber"]), (string)jo["phone"]);
                }


                return null;
            }
            catch (Exception ex)
            {
                
                return null;
            }

        }

        #endregion

        #region CREATE

        /// <summary>
        /// Création d'un utilisteur
        /// </summary>
        /// <param name="user">L'utilistateur à ajouter dans la BDD</param>
        /// <returns>NULL</returns>
        public static User CreateClient(User user)
        {
            HttpClient hc = new HttpClient();

            hc.DefaultRequestHeaders.Add("Nom", user.Last_name);
            hc.DefaultRequestHeaders.Add("Prenom", user.First_name);
            hc.DefaultRequestHeaders.Add("Email", user.Email);
            hc.DefaultRequestHeaders.Add("Tel", user.Phone);
            hc.DefaultRequestHeaders.Add("Password", WavHash.ComputeSha256Hash("Bonjour" + user.Email));
            hc.DefaultRequestHeaders.Add("Role", user.IdRole.ToString());

            var response = hc.GetAsync(BASE_URL + "/PERSONNE/create").Result;
            return null;
        }

        /// <summary>
        /// Cération d'un projet pour un utilistateur
        /// </summary>
        /// <param name="p">le projet</param>
        /// <param name="owner">l'utilisateur</param>
        public static void CreateProject(Project p, User owner)
        {
            HttpClient hc = new HttpClient();

            hc.DefaultRequestHeaders.Add("Nom", p.Name);
            hc.DefaultRequestHeaders.Add("Description", p.Description);
            hc.DefaultRequestHeaders.Add("Client", owner.Id.ToString());
            hc.DefaultRequestHeaders.Add("Valider", p.Valider.ToString());

            var response = hc.GetAsync(BASE_URL + "/PROJET/create").Result;
        }

        /// <summary>
        /// Création d'un nouveau materiel
        /// </summary>
        /// <param name="m">Le matériel à ajouter dans la base de données</param>
        public static void CreateMaterial(Materiel m)
        {
            HttpClient hc = new HttpClient();

            hc.DefaultRequestHeaders.Add("Nom", m.Nom);
            hc.DefaultRequestHeaders.Add("Description", m.Description);
            hc.DefaultRequestHeaders.Add("Prix", m.Prix.ToString());
            hc.DefaultRequestHeaders.Add("Quantite", m.Quantite.ToString());
            hc.DefaultRequestHeaders.Add("Categorie", m.IdCat.ToString());

            var response = hc.GetAsync(BASE_URL + "/MATERIEL/create").Result;
        }

        public static void CreateDateForProject(Project p, Tournage t)
        {
            HttpClient hc = new HttpClient();

            string debut = t.Debut.ToString("yyyy-M-dd HH:mm:ss.ms");
            string fin = t.Fin.ToString("yyyy-M-dd HH:mm:ss.ms");

            Debug.WriteLine(debut);
            Debug.WriteLine(fin);

            hc.DefaultRequestHeaders.Add("Project", p.Id.ToString());
            hc.DefaultRequestHeaders.Add("Start", debut);
            hc.DefaultRequestHeaders.Add("End", fin);

            var response = hc.GetAsync(BASE_URL + "/TOURNAGE/create").Result;
        }
       
        #endregion

        #region UPDATE

        /// <summary>
        /// Met a jour l'utilistateur avec les nouvelles informations
        /// </summary>
        /// <param name="user">l'utilisateur à mettre à jour</param>
        public static void UpdateUser(User user)
        {
            // Update user
            HttpClient hc = new HttpClient();

            hc.DefaultRequestHeaders.Add("Update", "Update");
            hc.DefaultRequestHeaders.Add("Id", user.Id.ToString());
            hc.DefaultRequestHeaders.Add("Lastname", user.Last_name);
            hc.DefaultRequestHeaders.Add("Firstname", user.First_name);
            hc.DefaultRequestHeaders.Add("Phone", user.Phone);
            hc.DefaultRequestHeaders.Add("Role", user.IdRole.ToString());

            var response = hc.GetAsync(BASE_URL + "/PERSONNE/update").Result;
        }

        // Update project
        public static void UpdateProject(Project p)
        {
            string description = p.Description.Replace("\'", "\\'");
            string commentaire = p.Commentaire.Replace("\'", "\\'");
            commentaire = commentaire.Replace("\r\n", "\\r\\n").Replace("é", "e").Replace("è", "e").Replace("ê", "e").Replace("à", "a").Replace("â", "a").Replace("ô", "o").Replace("î", "i").Replace("ç", "c");

            HttpClient hc = new HttpClient();

            hc.DefaultRequestHeaders.Add("Update", "Update");
            hc.DefaultRequestHeaders.Add("Id", p.Id.ToString());
            hc.DefaultRequestHeaders.Add("Nom", p.Name);
            hc.DefaultRequestHeaders.Add("Description", description);
            hc.DefaultRequestHeaders.Add("Client", p.Owner.Id.ToString());
            hc.DefaultRequestHeaders.Add("Valider", p.Valider.ToString());
            hc.DefaultRequestHeaders.Add("Commentaire", commentaire);
            
            var response = hc.GetAsync(BASE_URL + "/PROJET/update").Result;
        }

        /// <summary>
        /// Mise à jour d'un matériel
        /// </summary>
        /// <param name="m">Le matériel à mettre a jour</param>
        public static void UpdateMaterial(Materiel m)
        {
            HttpClient hc = new HttpClient();

            hc.DefaultRequestHeaders.Add("Nom", m.Nom);
            hc.DefaultRequestHeaders.Add("Description", m.Description);
            hc.DefaultRequestHeaders.Add("Prix", m.Prix.ToString());
            hc.DefaultRequestHeaders.Add("Quantite", m.Quantite.ToString());
            hc.DefaultRequestHeaders.Add("Categorie", m.IdCat.ToString());
            hc.DefaultRequestHeaders.Add("Id", m.Id.ToString());

            var response = hc.GetAsync(BASE_URL + "/MATERIEL/update").Result;
        }

        public static void UpdateTournage(Tournage t)
        {
            HttpClient hc = new HttpClient();
            
            string debut = t.Debut.ToString("yyyy-M-dd HH:mm:ss.ms");
            string fin = t.Fin.ToString("yyyy-M-dd HH:mm:ss.ms");

            Debug.WriteLine(debut);
            Debug.WriteLine(fin);

            hc.DefaultRequestHeaders.Add("Id", t.Id.ToString());
            hc.DefaultRequestHeaders.Add("Start", debut) ;
            hc.DefaultRequestHeaders.Add("End", fin);

            var response = hc.GetAsync(BASE_URL + "/TOURNAGE/update").Result;
        }

        #endregion

        #region DELETE

        /// <summary>
        /// Supprimer un utilisateur
        /// </summary>
        /// <param name="user">L'utilisateur a supprimer</param>
        public static void DeleteUser(User user)
        {
            HttpClient hc = new HttpClient();

            hc.DefaultRequestHeaders.Add("Id", user.Id.ToString());

            var response = hc.GetAsync(BASE_URL + "/PERSONNE/delete").Result;
        }

        /// <summary>
        /// Suprression d'un matériel
        /// </summary>
        /// <param name="m">Le matériel à supprimer</param>
        public static void DeleteMaterial(Materiel m)
        {
            HttpClient hc = new HttpClient();

            hc.DefaultRequestHeaders.Add("Id", m.Id.ToString());

            var response = hc.GetAsync(BASE_URL + "/MATERIEL/delete").Result;
        }

        public static void DeleteDate(Tournage t)
        {
            HttpClient hc = new HttpClient();

            hc.DefaultRequestHeaders.Add("Id", t.Id.ToString());

            var response = hc.GetAsync(BASE_URL + "/TOURNAGE/delete").Result;
        } 

        #endregion

        #region GET

        /// <summary>
        /// Récupère tous les projets pour un utilisateur
        /// </summary>
        /// <param name="u">L'utilisateur</param>
        /// <returns>Une liste de projets</returns>
        public static List<Project> ProjectsForUser(User u)
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

                if (p != null)
                {
                    foreach (Project item in p)
                    {
                        item.Owner = u;
                        projects.Add(item);
                        
                    }
                }


                return projects;

            }

            return null;
        }

        /// <summary>
        /// Récupère tous les clients
        /// </summary>
        /// <returns>La liste de tous les clients sous forme de list<User></returns>
        public static List<User> Clients()
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
                    item.Projets = ProjectsForUser(item);
                    clients.Add(item);
                }

                return clients;
            }

            return null;
        }

        /// <summary>
        /// Récupère tous les clients SANS leurs projets
        /// </summary>
        /// <returns>Une liste de clients simple</returns>
        public static List<User> ClientsNoProjects()
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
                    //item.Projets = ProjectsForUser(item);
                    clients.Add(item);
                }

                return clients;
            }

            return null;
        }

        /// <summary>
        /// Récupère la liste de tout le matériel
        /// </summary>
        /// <returns>La liste du matériel</returns>
        public static List<Materiel> GetMateriel()
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

        /// <summary>
        /// Récupère la liste de toutes les catégories de matériel
        /// </summary>
        /// <returns>La liste des catégories</returns>
        public static List<CategorieMateriel> GetCategories()
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

        /// <summary>
        /// Get a user by its email
        /// </summary>
        /// <param name="email">The email of the user</param>
        /// <returns>The user corresponding to the email if found, else NULL</returns>
        public static User GetUserByEmail(string email)
        {
            HttpClient hc = new HttpClient();

            hc.DefaultRequestHeaders.Add("Email", email);
            hc.DefaultRequestHeaders.Add("Infos", "Infos");

            var response = hc.GetAsync(BASE_URL + "/PERSONNE/read").Result;

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

        /// <summary>
        /// Vérifie si un utilisateur éxiste en fonction de son email 
        /// </summary>
        /// <param name="email">l'email à vérifier</param>
        /// <returns>True si l'utilisateur existe, False si non</returns>
        public static bool UserExists(string email)
        {
            HttpClient hc = new HttpClient();
            hc.DefaultRequestHeaders.Add("Email", email);

            var response = hc.GetAsync(BASE_URL + "/PERSONNE/read").Result;

            if (response.IsSuccessStatusCode)
            {
                var a = response.Content.ReadAsStringAsync().Result;

                if (a == "null")
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Récupère toutes les dates de tournages pour un projet
        /// </summary>
        /// <param name="p">Le projet en question</param>
        /// <returns>Une liste de "Tournages"</returns>
        public static List<Tournage> GetTournageForProject(Project p)
        {
            HttpClient hc = new HttpClient();
            hc.DefaultRequestHeaders.Add("Project", p.Id.ToString());

            var response = hc.GetAsync(BASE_URL + "/TOURNAGE/read").Result;
            
            if (response.IsSuccessStatusCode)
            {
                string a = response.Content.ReadAsStringAsync().Result;
                a.Replace("-", "/");
                JavaScriptSerializer js = new JavaScriptSerializer();
                Tournage[] tournages = js.Deserialize<Tournage[]>(a);

                List<Tournage> tournagesList = new List<Tournage>();

                if (tournages != null)
                {
                    foreach (Tournage item in tournages)
                        tournagesList.Add(item);
                    return tournagesList;                    
                }
                else
                {
                    return null;
                }
                
            }

            return null;
        }

        public static Calendat[][] GetCalendar(DateTime baseDate)
        {
            HttpClient hc = new HttpClient();
            hc.DefaultRequestHeaders.Add("Da", Convert.ToString(baseDate.Year + "-" + baseDate.Month + "-" + baseDate.Day));
            var response = hc.GetAsync(BASE_URL + "/TOURNAGE/read").Result;

            if (response.IsSuccessStatusCode)
            {
                string a = response.Content.ReadAsStringAsync().Result;

                a.Replace("-", "/");
                JavaScriptSerializer js = new JavaScriptSerializer();
                Calendat[][] tournages = js.Deserialize<Calendat[][]>(a);

                if (tournages != null)
                {
                    return tournages;
                }
                else
                {
                    return null;
                }
            }

            return null;
        }

        public static Calendat[][] GetCalendarClient(DateTime baseDate, User u)
        {
            HttpClient hc = new HttpClient();
            hc.DefaultRequestHeaders.Add("Do", Convert.ToString(baseDate.Year + "-" + baseDate.Month + "-" + baseDate.Day));
            hc.DefaultRequestHeaders.Add("Id", u.Id.ToString());
            
            var response = hc.GetAsync(BASE_URL + "/TOURNAGE/read").Result;

            if (response.IsSuccessStatusCode)
            {
                string a = response.Content.ReadAsStringAsync().Result;

                a.Replace("-", "/");
                JavaScriptSerializer js = new JavaScriptSerializer();
                Calendat[][] tournages = js.Deserialize<Calendat[][]>(a);

                if (tournages != null)
                {
                    return tournages;
                }
                else
                {
                    return null;
                }
            }

            return null;
        }

        #endregion

        #region ACTIVITY_LOG

        public static void AddActivityLog(User a_user, Project a_project, string a_log)
        {
            HttpClient hc = new HttpClient();

            a_log = a_log.Replace("'", "\\'");

            hc.DefaultRequestHeaders.Add("User", a_user.Id.ToString());
            hc.DefaultRequestHeaders.Add("Project", a_project.Id.ToString());
            hc.DefaultRequestHeaders.Add("Activity", a_log);

            var response = hc.GetAsync(BASE_URL + "/ACTIVITY").Result;
        }

        public static List<Activity> GetActivitiesForProject(Project p)
        {
            HttpClient hc = new HttpClient();
            hc.DefaultRequestHeaders.Add("Id", p.Id.ToString());

            var response = hc.GetAsync(BASE_URL + "/ACTIVITY").Result;

            if (response.IsSuccessStatusCode)
            {
                var a = response.Content.ReadAsStringAsync().Result;
                JavaScriptSerializer js = new JavaScriptSerializer();
                Activity[] activity = js.Deserialize<Activity[]>(a);

                List<Activity> activities = new List<Activity>();

                if (activity != null)
                {
                    foreach (Activity item in activity)
                        activities.Add(item);
                }

                return activities;
            }

            return null;
        }

        public static List<Activity> GetLastActivites(int amount)
        {
            HttpClient hc = new HttpClient();
            hc.DefaultRequestHeaders.Add("Last", amount.ToString());

            var response = hc.GetAsync(BASE_URL + "/ACTIVITY").Result;

            if (response.IsSuccessStatusCode)
            {
                var a = response.Content.ReadAsStringAsync().Result;
                JavaScriptSerializer js = new JavaScriptSerializer();
                Activity[] activity = js.Deserialize<Activity[]>(a);

                List<Activity> activities = new List<Activity>();

                if (activity != null)
                {
                    foreach (Activity item in activity)
                        activities.Add(item);
                }

                return activities;
            }

            return null;
        }

        #endregion

        #region Custom Methods

        /// <summary>
        /// Génrère un nom aléatoire
        /// </summary>
        /// <param name="len">la longueur du nom</param>
        /// <returns>le nom généré</returns>
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

        /// <summary>
        /// Genère un code a chiffre avec un longueur donnée
        /// </summary>
        /// <param name="len">la longueur du code</param>
        /// <returns>le string avec le code</returns>
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

        #endregion
    }
}
