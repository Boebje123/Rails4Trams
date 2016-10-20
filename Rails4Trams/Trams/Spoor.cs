using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rails4Trams.Users
{
  public  class Spoor
    {
       public int Lengte { get; set; }
        public int Nummer { get; set; }
        public bool Gereserveerd { get; set; }
        private List<Sector> Sectoren;

        public Spoor(int lengte,int nummer,bool gereserveerd)
        {
            this.Lengte = lengte;
            this.Nummer = nummer;
            this.Gereserveerd = gereserveerd;
            this.Sectoren = new List<Sector>();
        }
        
    }
}
