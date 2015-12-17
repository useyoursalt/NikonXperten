using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoNX
{
    public class Bruger
    {
        public int ID { get; set; }
        public string Navn { get; set; }
        public string Adgangskode { get; set; }
        public string Email { get; set; }
        public int Level { get; set; }
    }
}
