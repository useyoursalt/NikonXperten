using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoNX.Models.BaseModels
{
  public  class Kontakt
    {
        public int ID { get; set; }
        public string Navn { get; set; }
        public string Adresse { get; set; }
        public string Bynavn { get; set; }
        public int PostNR { get; set;}
        public string Tider { get; set; }
        public string Email { get; set; }
        public string Billede { get; set; }
    }
}
