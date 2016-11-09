using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rails4Trams
{
    public interface ITramContext
    {
        List<Tram> GetAllTrams();
        List<Tram> GetTramsGroteSchoonmaak();
        List<Tram> GetTramsKleineSchoonmaak();
        List<Tram> GetTramsGroteDienst();
        List<Tram> GetTramsKleineDienst();
  


        Tram Insert(Tram tram);
        bool Update(int id, int status);
        List<Tram> GetTramsInSector(Spoor Spoor);
        Tram GetTram(int id);
        Tram GetTramWithRFID(string rfid);
    }
}
