using System;
using WavContact.DB;
using WavContact.Models;

namespace UserCreator
{
    class Program
    {
        


        static void Main(string[] args)
        {

            Console.WriteLine("CREATEUR D'UTILISATEUR WAVCONTACT");
            Console.WriteLine("---------------------------------");

            Console.Write("NOM : ");
            string nom = Console.ReadLine();

            Console.Write("PRENOM : ");
            string prenom = Console.ReadLine();

            Console.Write("ROLE (1:ADMIN / 2:COLLABORATEUR / 3:CLIENT) : ");
            string role = Console.ReadLine();

            Console.Write("TEL : ");
            string tel = Console.ReadLine();

            Console.Write("EMAIL : ");
            string email = Console.ReadLine();

            Console.Write("MOT DE PASSE : ");
            string mdp = Console.ReadLine();

            WavContactPDO.CreateUser(nom, prenom, role, tel, email, mdp);
            
            User u = WavContactPDO.Login(email, mdp);

            Console.WriteLine("Tout est fonctionnel pour : " + u);
        }
    }
}
