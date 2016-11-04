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
        private Spoor spoor;
        private Tram tram;

        
        public Sector(int id,Tram tram,Spoor spoor,bool beschikbaar,bool blokkade)
        {
            this.id = id;
            this.tram = tram;
            this.spoor = spoor;
            this.Blokkade = blokkade;
            this.Beschikbaar = beschikbaar;
        }

        public override string ToString()
        {
            return Convert.ToString(id);
        }
    }
}
