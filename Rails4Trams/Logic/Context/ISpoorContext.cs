using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rails4Trams
{
   public interface ISpoorContext
    {
        List<Spoor> Zoekspoor();
        List<Spoor> Zoekinrijdspoor();
        List<Spoor> AllSporen();
        bool UpdateSpoor(Spoor spoor,int status);
        Spoor GetSpoor(int id);
    }
}
