using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTerra_FrontEnd.DataAccessLayer;
// Dax/Lars
namespace TechTerra_FrontEnd.MODEL.Menu.DierVerblijf
{
    public class DierAanpassen
    {
        public void WijzigDier()
        {
            Console.Clear();
            Console.WriteLine("=== DIER GEGEVENS AANPASSEN ===\n");

            // Vragen om dier ID om te wijzigen
            Console.Write("Dier ID (nummer): ");
            int dierId = int.Parse(Console.ReadLine());

            // Huidige gegevens tonen (optioneel - als DAL dit ondersteunt)
            try
            {
                DAL dal = new DAL();
                var dier = dal.GetDierById(dierId); // Aanname: DAL heeft deze methode
                if (dier != null)
                {
                    Console.WriteLine($"\nHuidige gegevens:");
                    Console.WriteLine($"Naam: {dier.Naam}");
                    Console.WriteLine($"Soort: {dier.Soort}");
                    Console.WriteLine($"Verblijf ID: {dier.VerblijfID}");
                    Console.WriteLine($"Geboortedatum: {dier.Geboortedatum:dd-MM-yyyy}");
                }
                else
                {
                    Console.WriteLine("Dier niet gevonden!");
                    Console.WriteLine("Druk op een toets voor het menu...");
                    Console.ReadKey();
                    Console.Clear();
                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fout bij ophalen dier: {ex.Message}");
                Console.WriteLine("Druk op een toets voor het menu...");
                Console.ReadKey();
                Console.Clear();
                return;
            }

            // Nieuwe gegevens invoeren
            Console.Write("\nNieuwe naam (Enter voor behouden): ");
            string naam = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(naam)) naam = null; // null = geen wijziging

            Console.Write("Nieuwe soort (Enter voor behouden): ");
            string soort = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(soort)) soort = null;

            Console.Write("Nieuw verblijf ID (Enter voor behouden): ");
            string vIdInput = Console.ReadLine();
            int? vId = null;
            if (!string.IsNullOrWhiteSpace(vIdInput))
                vId = int.Parse(vIdInput);

            Console.Write("Nieuwe geboortedatum (dd-mm-jjjj, Enter voor behouden): ");
            string datumInput = Console.ReadLine();
            DateTime? datum = null;
            if (!string.IsNullOrWhiteSpace(datumInput))
                datum = DateTime.Parse(datumInput);

            // Wijzigen via de DAL
            try
            {
                DAL dal = new DAL();
                dal.WijzigDier(dierId, naam, soort, vId, datum);
                Console.WriteLine("\nGelukt! Het dier is gewijzigd.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nFout: {ex.Message}");
            }

            Console.WriteLine("\nDruk op een toets voor het menu...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
    

