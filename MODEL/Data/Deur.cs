using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechTerra_FrontEnd.MODEL.Data
{
    internal class Deur
    {
        public string ID { get; set; }
        public bool Open { get; set; }
        public bool Alarm { get; set; }
        public int MaxTijdOpen { get; set; }
    }
}
