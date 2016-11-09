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
        List<Sector> GetAllSectoren();
        void TramInrijden(Tram tram,Spoor spoor, Sector sector);
        void TramUitrijden(Sector sector);
        bool BlokkeerSector(Sector sector, int status);
        Sector GetSector(int id);
        Sector GetSector(Tram tram);
        bool CheckTram(Tram tram);
    }
}
