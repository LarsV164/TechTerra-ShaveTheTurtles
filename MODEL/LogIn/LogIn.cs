using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTerra_FrontEnd.DataAccessLayer;
using TechTerra_FrontEnd.MODEL.Data;

namespace TechTerra_FrontEnd
{
    public class LogIn
    {
        public int ShowLogin()
        {
            Console.Clear();
            Console.WriteLine("=== Login ===");
            Console.WriteLine();

            Console.Write("Gebruikersnaam: ");
            string username = Console.ReadLine();

            Console.Write("Wachtwoord: ");
            string password = Console.ReadLine();

            Console.WriteLine();
            int accessLevel = UserAccess(username, password);
            if (accessLevel != -1)
            {
                Console.WriteLine($"Welkom {username}! (Toegangsniveau: {accessLevel})");
                return accessLevel;
            }
            else
            {
                Console.WriteLine("Gebruikersnaam of Wachtwoord verkeerd!");
                Console.WriteLine("Programma wordt afgesloten, druk op een toets.");
                Console.ReadKey();
                return -1;
            }
        }

        private int UserAccess(string userName, string passWord)
        {
            var dal = new DAL();
            int UserAccessLevel = dal.GetUserAccessLevel(userName, passWord);
            var gebruiker = new Gebruiker
            {
                Gebruikersnaam = userName,
                Wachtwoord = passWord,
                UserAccess = UserAccessLevel
            };
            return UserAccessLevel;
        }
    }
}