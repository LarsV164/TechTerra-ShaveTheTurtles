using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechTerra_FrontEnd
{
    public class LogIn
    {

        // Tijdelijk totdat het in de database staat
        private List<string> Usernames = new List<string>
        {
            "admin",
            "teamleider",
            "verzorger",
            "verblijfbeheerder"
        };

        private List<string> Passwords = new List<string>
        {
            "Admin0000",
            "TeamL0000",
            "Verz0000",
            "VbBh0000"
        };

        public bool ShowLogin()
        {
            Console.Clear();
            Console.WriteLine("=== Login ===");
            Console.WriteLine();

            Console.Write("Gebruikersnaam: ");
            string username = Console.ReadLine();

            int UNindex = Usernames.IndexOf(username);

            Console.Write("Wachtwoord: ");
            string password = Console.ReadLine();

            int PWindex = Passwords.IndexOf(password);

            Console.WriteLine();
            if (ValidateLogIn(UNindex, PWindex))
            {
                Console.WriteLine($"Welkom {username}!");
                return true;
            }
            else
            {
                Console.WriteLine("Gebruikersnaam of Wachtwoord verkeerd!");
                Console.WriteLine("Programma wordt afgesloten, druk op een toets.");
                Console.ReadKey();
                return false;
            }
        }

        private bool ValidateLogIn(int UNindex, int PWindex)
        {
            return UNindex == PWindex;
        }
/*
        public int AccessLevel()
        {
            return UNindex;

        }*/
    }
}