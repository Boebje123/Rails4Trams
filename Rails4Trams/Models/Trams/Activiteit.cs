using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rails4Trams
{
   public class Activiteit
    {
   
        public string Beschrijving { get; set; }
        public DateTime BeginDatum { get; set; }
        public DateTime EindDatum { get; set; }
        public int ActiviteitiD { get; set; }
        public Medewerker medewerker { get; private set; }
        public Tram Tram { get; private set; }

        public Activiteit(DateTime beginDatum,DateTime eindDatum,int activiteitiD,Medewerker m,Tram t)
        {
            this.medewerker = m;
            this.Tram = t;  
            this.BeginDatum = beginDatum;
            this.EindDatum = eindDatum;
            this.ActiviteitiD = activiteitiD;
    
        }
    }
}
