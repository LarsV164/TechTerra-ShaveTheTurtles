using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTerra_FrontEnd.DataAccessLayer;
using TechTerra_FrontEnd.DataBase.Data;

namespace TechTerra_FrontEnd
{
    internal class DierVerblijf
    {
        public void ShowList()
        {
            // DAL instantie aanmaken
            var dal = new DAL();

            List<Dier> dieren;
            // DAL aanroepen om dieren op te halen
            try
            {
                dieren = dal.GetDieren();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fout bij ophalen van dieren: " + ex.Message);
                Console.WriteLine();
                Console.WriteLine("druk op een toets om terug te gaan naar het menu ->");
                Console.ReadKey();
                Console.Clear();
                return;
            }
            // header
            Console.Clear();
            Console.Clear();
            Console.WriteLine("=== DIEREN / VERBLIJVEN INZIEN ===");

            // dieren weergeven
            foreach (var dier in dieren)
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("DIER ID: " + dier.ID);
                    Console.WriteLine("NAAM: " + (dier.Naam));
                    Console.WriteLine("SOORT: " + (dier.Soort));
                    Console.WriteLine("LEEFTIJD: " + (dier.Geboortedatum));
                    Console.WriteLine("- - - - - - - - - - - - - - - - -");
                    Console.WriteLine("VERBLIJF NAAM: " + (dier.VerblijfNaam) + " | VERBLIJF ID: " + dier.VerblijfID);
                    Console.WriteLine();
                }
           
            // footer
            Console.WriteLine();
            Console.WriteLine("druk op een toets om terug te gaan naar het menu ->");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

