using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rails4Trams
{
   public interface ISectorContext
    {
        List<Sector> ZoekVrijSector(Spoor Spoor);
        void VerplaatsTram(Tram tram,Spoor spoor, Sector sector);
        bool BlokkeerSector(Sector sector, int status);
    }
}
