using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTerra_FrontEnd.DataAccessLayer;
using TechTerra_FrontEnd.MODEL.Data;

namespace TechTerra_FrontEnd.MODEL.DeurMonitor
{
    internal class DeurMonitorService
    {
        public void DeurOpenMelding()
        {
            Console.WriteLine("=== MELDING ===");
            Console.WriteLine("\nER STAAN DEUR(EN) OPEN\n");

            var dal = new DAL();
            dal.GetOpenDeuren();
        }
    }
}
