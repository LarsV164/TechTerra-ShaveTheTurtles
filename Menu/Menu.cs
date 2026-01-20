using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechTerra_FrontEnd
{
    public class Menu
    {
        public void ShowMenu()
        {
            // Hoofdmenu weergeven
            bool doorgaan = true;
            while (doorgaan)
            {
                Console.WriteLine("=== MENU ===");
                Console.WriteLine();
                Console.WriteLine("1. Dieren / Verblijven inzien");
                Console.WriteLine("2. Dier gegevens aanpassen");
                Console.WriteLine("3. Nieuw dier aanmelden");
                Console.WriteLine("4. Deurmeldingen inzien");
                Console.WriteLine();
                Console.WriteLine("U. Gebruiker inzien");
                Console.WriteLine("Q. Applicatie afsluiten");
                Console.WriteLine();
                Console.Write("Selecteer een optie: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        var dierverblijf = new DierVerblijf();
                        dierverblijf.ShowList();
                        break;
                    case "2":
                        DierGegevens();
                        break;
                    case "3":
                        DierAanmelden();
                        break;
                    case "4":
                        DeurMeldingen();
                        break;
                    case "U":
                        Gebruiker();
                        break;
                    case "Q":
                        Console.Clear();
                        doorgaan = false;
                        break;
                    default:
                        Console.WriteLine("\nOngeldige Optie! \nHoud er rekening mee dat de keuzes hoofdlettergevoelig zijn.\n\nDuw op een toets om nog eens te proberen ->");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }

        //Tijdelijke methodes voor menu-opties
        private void DierGegevens()
        {
            Console.Clear();
            Console.WriteLine("=== DIER GEGEVENS VERANDEREN ===");
            Console.WriteLine();
            Console.WriteLine("Hier ga je ooit de gegevens van een dier kunnen veranderen");
            Console.WriteLine();
            Console.Write("Duw op een toets om terug te gaan naar het menu ->");
            Console.ReadKey();
            Console.Clear();
        }

        private void DierAanmelden()
        {
            Console.Clear();
            Console.WriteLine("=== DIER AANMELDEN ===");
            Console.WriteLine();
            Console.WriteLine("Hier ga je ooit een dier kunnen aanmelden");
            Console.WriteLine();
            Console.Write("Duw op een toets om terug te gaan naar het menu ->");
            Console.ReadKey();
            Console.Clear();
        }

        private void DeurMeldingen()
        {
            Console.Clear();
            Console.WriteLine("=== DEUR MELDINGEN ===");
            Console.WriteLine();
            Console.WriteLine("- Voorbeeld -");
            Console.WriteLine();
            Console.WriteLine("ID: SchildpadVerblijf_001");
            Console.WriteLine("MELDING: \nDeur staat langer dan 2 minuten open.");
            Console.WriteLine();
            Console.WriteLine("== OPTIES ==");
            Console.WriteLine("1. Deur is gesloten en verblijf gecontrolleerd");
            Console.WriteLine("2. Deur hoort open te staan");
            Console.WriteLine();
            Console.WriteLine("Duw op een toets om terug te gaan naar het menu ->");
            Console.ReadKey();
            Console.Clear();
        }
        private void Gebruiker()
        {
            Console.Clear();
            Console.WriteLine("=== GEBRUIKER INZIEN ===");
            Console.WriteLine("Naam: admin");
            Console.WriteLine("Rol: Administrator");
            Console.WriteLine("Laatste Login: " + DateTime.Now.ToString("dd - MM - yyyy @ HH:mm"));
            Console.WriteLine();
            Console.WriteLine("Duw op een toets om terug te gaan naar het menu ->");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
