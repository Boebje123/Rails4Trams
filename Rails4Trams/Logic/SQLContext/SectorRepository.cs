using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rails4Trams.Logic.SQLContext
{
    public class SectorRepository
    {
        private ISectorContext context;

        public SectorRepository(ISectorContext context)
        {
            this.context = context;
        }
        public List<Sector> ZoekVrijSector(Spoor spoor)
        {
            return context.ZoekVrijSector(spoor);
        }
        public void VerplaatsTram(Tram tram)
            {
            context.VerplaatsTram(tram);
            }
    
    }
}
