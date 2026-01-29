using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTerra_FrontEnd.DataAccessLayer;
using TechTerra_FrontEnd.MODEL.Data;
//Gino/Lars
namespace TechTerra_FrontEnd.MODEL.Menu.DeurMenu
{
    internal class DeurMenu
    {
           public void ShowList()
            {
                // DAL instantie aanmaken
                var dal = new DAL();

                List<Deur> deuren;
                // DAL aanroepen om dieren op te halen
                try
                {
                    deuren = dal.GetDeuren();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Fout bij ophalen van deuren: " + ex.Message);
                    Console.WriteLine();
                    Console.WriteLine("druk op een toets om terug te gaan naar het menu ->");
                    Console.ReadKey();
                    Console.Clear();
                    return;
                }
                // header
                Console.Clear();
                Console.Clear();
                Console.WriteLine("=== DEUREN INZIEN ===");

                // deuren weergeven
                foreach (var deur in deuren)
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("DEUR ID: " + deur.ID);
                if (deur.Open)
                {
                    Console.WriteLine("DEUR STATUS: OPEN");
                }
                else
                {
                    Console.WriteLine("DEUR STATUS: GESLOTEN");
                }
                if (deur.Alarm)
                {
                    Console.WriteLine("ALARM STATUS: AAN");
                }
                else
                {
                    Console.WriteLine("ALARM STATUS: UIT");
                }
                    Console.WriteLine($"MAXIMALE TIJD OPEN: {deur.MaxTijdOpen} seconden");
                    Console.WriteLine();
            }

        }
                     
    }
}

