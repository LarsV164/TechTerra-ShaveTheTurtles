using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Lars
namespace TechTerra_FrontEnd.DataBase.Data
{
    public class Dier
    {
        // Eigenschappen
        public int ID { get; set; }
        public string Naam { get; set; }
        public string Soort { get; set; }
        public int VerblijfID { get; set; }
        public string VerblijfNaam { get; set; }
        public DateTime Geboortedatum { get; set; }
    }
}
