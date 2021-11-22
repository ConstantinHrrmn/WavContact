using System;
using System.Collections.Generic;

namespace WavContactLogin
{
    class Program
    {
        static void Main(string[] args)
        {

            string email = "constantin@waview.ch";
            string real_password = "motdepasse";
            List<string> passwords = new List<string>();

            passwords.Add(real_password);
            passwords.Add("12345");
            passwords.Add("-");

            foreach (string item in passwords)
            {
                DisplayTest(email, item);
            }

            DisplayTest("coco", real_password);

            

            Console.ReadKey();
        }

        static void DisplayTest(string e, string p)
        {

            User u = WavContactPDO.Login(e, p);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Login into WavContact with account : ");
            Console.WriteLine("Email : " + e);
            Console.WriteLine("Password : " + p);

            if (u != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Login OK : " + u.ToString());
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("FAIL IN LOGIN");
            }

            Console.WriteLine("");

            
        }
    }
}
