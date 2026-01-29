using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTerra_FrontEnd.MODEL.Data;
using TechTerra_FrontEnd.DataAccessLayer;

namespace TechTerra_FrontEnd
{
    public class Menu
    {
        public void ShowMenu(int UserAccess)
        {
            string User;

            if (UserAccess == 1)
                User = "Admin";
            else if (UserAccess == 2)
                User = "Teamleider";
            else if (UserAccess == 3)
                User = "Verblijfsbeheerder";
            else
                User = "Verzorger";

            // Hoofdmenu weergeven
            bool doorgaan = true;

            while (doorgaan)
            {
                Console.WriteLine("=== MENU ===");
                Console.WriteLine($"ingelogd als:{User}");
                Console.WriteLine();

                Console.WriteLine("1. Dieren / Verblijven inzien");

                if (UserAccess <= 2)
                {
                    Console.WriteLine("2. Dier gegevens aanpassen");
                    Console.WriteLine("3. Nieuw dier aanmelden");
                    Console.WriteLine("4. Deurmeldingen inzien");
                }

                if (UserAccess == 3)
                {
                    Console.WriteLine("2. Deurmeldingen inzien");
                }
                    
                Console.WriteLine();
                Console.WriteLine("Q. Applicatie afsluiten");
                Console.WriteLine();
                Console.Write("Selecteer een optie: ");

                string choice = Console.ReadLine();
                string choice1 = choice.ToUpper();

                switch (choice1)
                {
                    case "1":
                        var dierverblijf = new DierVerblijf();
                        dierverblijf.ShowList();
                        break;
                    case "2":
                        if (UserAccess == 3)
                        {
                            DeurMeldingen();
                            break;
                        }
                        if (UserAccess == 4)
                        {
                            OngeldigeOptie();
                            break;
                        }
                        DierGegevens();
                        break;
                    case "3":
                        if (UserAccess > 2)
                        {
                            OngeldigeOptie();
                            break;
                        }
                        DierAanmelden();
                        break;
                    case "4":
                        if (UserAccess > 2)
                        {
                            OngeldigeOptie();
                            break;
                        }
                        DeurMeldingen();
                        break;
                    case "Q":
                        Console.Clear();
                        doorgaan = false;
                        break;
                    default:
                        OngeldigeOptie();
                        break;
                }
                
            }
        }
        private void OngeldigeOptie()
        {
            Console.WriteLine("\nOngeldige Optie! \n\nDruk op een toets om nog eens te proberen ->");
            Console.ReadKey();
            Console.Clear();
        }

        //Tijdelijke methodes voor menu-opties
        private void DierGegevens()
        {
            Console.Clear();
            Console.WriteLine("=== DIER GEGEVENS VERANDEREN ===");
            Console.WriteLine();
            Console.WriteLine("Hier ga je ooit de gegevens van een dier kunnen veranderen");
            Console.WriteLine();
            Console.Write("druk op een toets om terug te gaan naar het menu ->");
            Console.ReadKey();
            Console.Clear();
        }


            private void DierAanmelden()
        {
            Console.Clear();
            Console.WriteLine("=== NIEUW DIER AANMELDEN ===");

            // Vragen om invoer 
            Console.Write("Naam dier: ");
            string naam = Console.ReadLine();

            Console.Write("Soort: ");
            string soort = Console.ReadLine();

            Console.Write("Verblijf ID (nummer): ");
            int vId = int.Parse(Console.ReadLine());

            Console.Write("Geboortedatum (dd-mm-jjjj): ");
            DateTime datum = DateTime.Parse(Console.ReadLine());

          // Opslaan via de DAL
            try
            {
                DAL dal = new DAL();
                dal.VoegDierToe(naam, soort, vId, datum);
                Console.WriteLine("Gelukt! Het dier is opgeslagen."); // Bevestiging 
            }
            catch (Exception ex)
            {
                // als het misgaat
                Console.WriteLine("Fout: ");
            }

            Console.WriteLine("Druk op een toets voor het menu...");
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
            Console.WriteLine("druk op een toets om terug te gaan naar het menu ->");
            Console.ReadKey();
            Console.Clear();
        }
    }
}