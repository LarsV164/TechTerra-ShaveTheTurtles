using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechTerra_FrontEnd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var loginManager = new LogIn();
            int UserAccess = loginManager.ShowLogin();

            if (UserAccess != -1)
            {
                Console.WriteLine("\ndruk op een toets om verder te gaan ->");
                Console.ReadKey();
                Console.Clear();

                var menu = new Menu();
                menu.ShowMenu(UserAccess);
            }
        }
    }
}