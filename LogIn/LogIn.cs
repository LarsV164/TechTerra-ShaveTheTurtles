using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechTerra_FrontEnd
{
    public class LogIn
    {
        private string VALID_USERNAME = "admin";
        private string VALID_PASSWORD = "0000";

        public bool ShowLogin()
        {
            Console.Clear();
            Console.WriteLine("=== Login ===");
            Console.WriteLine();

            Console.Write("Gebruikersnaam: ");
            string username = Console.ReadLine();

            Console.Write("Wachtwoord: ");
            string password = Console.ReadLine();

            bool isValid = ValidateCredentials(username, password);

            Console.WriteLine();
            if (isValid)
            {
                Console.WriteLine($"Welkom {username}!");
                return true;
            }
            else
            {
                Console.WriteLine("Gebruikersnaam of Wachtwoord verkeerd!");
                return false;
            }
        }

        private bool ValidateCredentials(string username, string password)
        {
            return username == VALID_USERNAME && password == VALID_PASSWORD;
        }
    }
}
