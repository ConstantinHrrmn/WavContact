using System;

namespace WavContactLogin
{
    class Program
    {
        static void Main(string[] args)
        {

            string email = "constantin@waview.ch";
            string password = "motdepasse";

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Login into WavContact with account : ");
            Console.WriteLine("Email : " + email);
            Console.WriteLine("Password : " + password);

            Console.WriteLine("---------------------------");


            User u = WavContactPDO.LoginAsync(email, password).Result;

            Console.WriteLine("Login OK : " + u.ToString());

            Console.ReadKey();
        }
    }
}
