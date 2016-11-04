using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rails4Trams
{
 public   class SpoorRepository
    {
        private ISpoorContext context;
        public SpoorRepository(ISpoorContext context)
        {
            this.context = context;
        }

        public List<Spoor> ZoekSpoor(Tram tram)
        {
            return context.Zoekspoor(tram);
        }
        public Spoor GetSpoor(int id)
        {
            return context.GetSpoor(id);
        }
    }
}
