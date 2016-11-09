using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rails4Trams
{
   public class Sector
    {
        public int id { get; set; }
        public bool Beschikbaar { get; set; }
        public bool Blokkade { get; set; }
        public Spoor spoor { get; private set; }
        public Tram tram { get; private set; }
        public int rowNumber { get; private set; }

        public Sector(int id,Tram tram,Spoor spoor,bool beschikbaar,bool blokkade, int rownumber)
        {
            this.rowNumber = rownumber;
            this.id = id;
            this.tram = tram;
            this.spoor = spoor;
            this.Blokkade = blokkade;
            this.Beschikbaar = beschikbaar;
        }
        public Sector(int id,Spoor spoor, bool beschikbaar, bool blokkade, int rownumber)
        {
            this.rowNumber = rownumber;
            this.id = id;
            this.spoor = spoor;
            this.Blokkade = blokkade;
            this.Beschikbaar = beschikbaar;
        }
        public Sector() { }
        public override string ToString()
        {
            return Convert.ToString(id) + " geblokkeerd: " + this.Blokkade;
        }
    }
}
