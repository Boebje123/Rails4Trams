using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rails4Trams
{
 public   class SpoorRepository
    {
        private ISpoorContext context;
        public SpoorRepository(ISpoorContext context)
        {
            this.context = context;
        }

        public List<Spoor> ZoekSpoor()
        {
            return context.Zoekspoor();
        }
        public Spoor GetSpoor(int id)
        {
            return context.GetSpoor(id);
        }
        public List<Spoor> GetAllSporen()
        {
            return context.AllSporen();
        }
        public bool UpdateSpoor(Spoor spoor,int status)
        {
            return context.UpdateSpoor(spoor,status);
        }
    }
}
