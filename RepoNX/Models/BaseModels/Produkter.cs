using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoNX
{
   public class Produkter
    {
        public int ID { get; set; }
        public string Navn { get; set; }
        public string Beskrivelse { get; set; }
        public string Billede { get; set; }
        public int VareNR { get; set; }
        public string Leveringstid { get; set; }
        public string Producent { get; set; }
        public int LagerAntal { get; set; }
        public int KatID { get; set; }

    }
}

