using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rails4Trams.Users
{
   public class Sector
    {
        public int Nummer { get; set; }
        public int Lengte { get; set; }
        public bool Beschikbaar { get; set; }

        public Sector(int nummer,int lengte,bool beschikbaar)
        {
            this.Nummer = nummer;
            this.Lengte = lengte;
            this.Beschikbaar = beschikbaar;
        }
    }
}
