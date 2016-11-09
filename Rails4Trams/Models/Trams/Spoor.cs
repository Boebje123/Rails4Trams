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
        public int id { get; set; }
        public bool Bezetting { get; set; }
        public string Type { get; set; }

        public Spoor(int id,string type,bool bezetting,int lengte)
        {
            this.id = id;
            this.Lengte = lengte;
            this.Type = type;
            this.Bezetting = bezetting;
          
        }
        public Spoor() { }

        public override string ToString()
        {
            return Convert.ToString(this.id) + " geblokkeerd: "+this.Bezetting;
        }
    }
}
