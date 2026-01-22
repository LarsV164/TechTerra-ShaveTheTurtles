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
            "verblijf"
        };

        private List<string> Passwords = new List<string>
        {
            "Admin0000",
            "TeamL0000",
            "Verz0000",
            "Verblijf0000"
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

            bool isValid = ValidateLogIn(UNindex, PWindex);

            Console.WriteLine();
            if (isValid)
            {
                Console.WriteLine($"Welkom {username}!");
                Console.WriteLine(AccessLevel(UNindex));
                return true;
            }
            else
            {
                Console.WriteLine("Gebruikersnaam of Wachtwoord verkeerd!");
                return false;
            }
        }

        private bool ValidateLogIn(int UNindex, int PWindex)
        {
            return UNindex == PWindex;
        }

        public string AccessLevel(int UNindex)
        {
            return Usernames[UNindex];

        }
    }
}
