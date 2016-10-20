using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rails4Trams.Users
{
    public class Tram
    {
        public enum tramType {Combino,_11g,DubbelKopCombino,_12g,Opleidingstram }
        public enum status {Defect,Schoonmaak,Dienst,Remise }

        public tramType Tramtype { get; set; }
        public int Lengte { get; set; }
        public status Status { get; set; }
        public bool LijnGebonden { get; set; }
        private List<Sector> Sectoren; 

        public Tram(tramType tramtype,status status,int lengte,bool lijnGebonden)
        {
            this.Tramtype = tramtype;
            this.Status = status;
            this.Lengte = lengte;
            this.LijnGebonden = lijnGebonden;
            this.Sectoren = new List<Sector>();
        }
    }
}
