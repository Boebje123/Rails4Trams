using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rails4Trams
{
  public  class Spoor
    {
       public int Lengte { get; set; }
        public int Nummer { get; set; }
        public bool Gereserveerd { get; set; }
        private Sector Sector;

        public Spoor(int lengte,int nummer,bool gereserveerd)
        {
            this.Lengte = lengte;
            this.Nummer = nummer;
            this.Gereserveerd = gereserveerd;
            
        }
        
    }
}
