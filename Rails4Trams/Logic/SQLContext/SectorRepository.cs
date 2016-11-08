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
        public void TramInrijden(Tram tram,Spoor spoor,Sector sector)
            {
            context.TramInrijden(tram,spoor,sector);
            }
        public void TramUitrijden(Sector sector)
        {
            context.TramUitrijden(sector);
        }
        public bool UpdateSector(Sector sector, int status)
        {
            return context.BlokkeerSector(sector, status);
        }
        public Sector GetSector(int id)
        {
            return context.GetSector(id);
        }

    }
}
