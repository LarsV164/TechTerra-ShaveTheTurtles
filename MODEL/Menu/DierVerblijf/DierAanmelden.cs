using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTerra_FrontEnd.DataAccessLayer;
using TechTerra_FrontEnd.DataBase.Data;

namespace TechTerra_FrontEnd.MODEL.Menu.DierVerblijf
{
    internal class DierAanmelden
    {
        public void NieuwDier()
        {
            Console.Clear();
            Console.WriteLine("=== NIEUW DIER AANMELDEN ===\n");

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
    }
}