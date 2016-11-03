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
    }
}
