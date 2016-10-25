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
            return GetTramsKleineDienst();
        }
       public Tram Insert(Tram tram)
        {
            return tramContext.Insert(tram);
        }
       public bool Update(Tram tram)
        {
            return tramContext.Update(tram);
        }
      public  Tram GetTram(int id)
        {
            return tramContext.GetTram(id);
        }
    }
}
