using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rails4Trams
{
   public class Lijn
    {
        public int id { get; set; }
        private List<Tram> trams;
        public Lijn(int id)
        {
            this.id = id;
        }
        public Lijn(int id,List<Tram>trams)
        {
            this.trams = trams;
            this.id = id;
        }
    }
}
