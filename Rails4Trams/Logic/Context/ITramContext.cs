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
        Tram Insert(Tram tram);
        bool Update(Tram tram);
        Tram GetTram(int id);
    }
}
