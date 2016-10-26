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

        public Activiteit Insert(Activiteit activiteit,Medewerker m,Tram t)
        {
            return context.Insert(activiteit,m,t);
        }
    }
}
