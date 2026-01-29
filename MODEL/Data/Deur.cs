using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Gino
namespace TechTerra_FrontEnd.MODEL.Data
{
    public class Deur
    {
        public int ID { get; set; }
        public bool Open { get; set; }
        public bool Alarm { get; set; }
        public int MaxTijdOpen { get; set; }
        public int VerblijfID { get; set; }
    }
}
