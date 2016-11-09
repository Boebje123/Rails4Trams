using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rails4Trams
{
  public  interface IActiviteitContext
    {
        Activiteit Insert(Activiteit activiteit);
        List<Activiteit> VraagSchoonmaaklijstAan();

        int CountTramsKleineDienst();
        int CountTramsGroteDienst();
        int CountTramsKleineSchoonmaak();
        int CountTramsGroteSchoonmaak();
    }
}
