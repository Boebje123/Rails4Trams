using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rails4Trams
{
   public class TramRepository
    {
        private ITramContext tramContext;

        public TramRepository(ITramContext tramcontext)
        {
            this.tramContext = tramcontext;
        }
        public  List<Tram> GetAllTrams()
        {
            return tramContext.GetAllTrams();
        }
       public List<Tram> GetTramsGroteSchoonmaak()
        {
           return tramContext.GetTramsGroteSchoonmaak();
        }
      public  List<Tram> GetTramsKleineSchoonmaak()
        {
          return  tramContext.GetTramsKleineSchoonmaak();
        }
      public  List<Tram> GetTramsGroteDienst()
        {
         return tramContext.GetTramsGroteDienst();
        }
       public List<Tram> GetTramsKleineDienst()
        {
            return tramContext.GetTramsKleineDienst();
        }
       public Tram Insert(Tram tram)
        {
            return tramContext.Insert(tram);
        }
       public bool Update(int id,int status)
        {
            return tramContext.Update(id,status);
        }
      public  Tram GetTram(int id)
        {
            return tramContext.GetTram(id);
        }
        public Tram GetTramWithRFID(string rfid)
        {
            return tramContext.GetTramWithRFID(rfid);
        }
        public List<Tram> GetTramsInSector(Spoor spoor)
        {
            return tramContext.GetTramsInSector(spoor);
        }
    }
}
