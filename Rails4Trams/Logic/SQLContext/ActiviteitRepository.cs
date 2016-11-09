using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rails4Trams
{
  public  class ActiviteitRepository
    {
        private IActiviteitContext context;
        public ActiviteitRepository(IActiviteitContext context)
        {
            this.context = context;
        }

        public Activiteit Insert(Activiteit activiteit)
        {
            return context.Insert(activiteit);
        }
        public List<Activiteit> VraagSchoonmaaklijstAan()
        {
            return context.VraagSchoonmaaklijstAan();
        }
        public int CountTramsKleineDienst()
        {
            return context.CountTramsKleineDienst();
        }
        public int CountTramsGroteDienst()
        {
            return context.CountTramsGroteDienst();
        }
        public int CountTramsKleineSchoonmaak()
        {
            return context.CountTramsKleineSchoonmaak();
        }
        public int CountTramsGroteSchoonmaak()
        {
            return context.CountTramsGroteSchoonmaak();
        }
    }
}
