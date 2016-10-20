using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rails4Trams.Users
{
  public  class Remise
    {
        public string Naam { get; set; }
        public string Locatie { get; set; }
        private List<Spoor> Sporen;

          public Remise(string naam,string locatie)
        {
            this.Naam = naam;
            this.Locatie = locatie;
            Sporen = new List<Spoor>();
        }
    }
}
