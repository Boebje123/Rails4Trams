using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rails4Trams
{
    public class Tram
    {
       
        public int id { get;private set; }
  
        public int Lengte { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Rfid { get; set; }
        public bool LijnGebonden { get; set; }
        private List<Sector> Sectoren;
        private List<Lijn> Lijnen;
        public Tram(int id,string type,string status,int lengte, bool lijnGebonden,string rfid)
        {
            this.Rfid = rfid;
            this.id = id;
            this.Type = type;
            this.Status = status;
            this.Lengte = lengte;
            this.LijnGebonden = lijnGebonden;
            this.Sectoren = new List<Sector>();
        }
        public Tram(int id, string type, string status, int lengte, bool lijnGebonden, string rfid,List<Lijn> lijnen)
        {
            this.Rfid = rfid;
            this.id = id;
            this.Type = type;
            this.Status = status;
            this.Lengte = lengte;
            this.LijnGebonden = lijnGebonden;
            this.Sectoren = new List<Sector>();
            this.Lijnen = lijnen;
        }
        public Tram(int lengte,bool lijnGebonden)
        {      
            this.Lengte = lengte;
            this.LijnGebonden = lijnGebonden;
            this.Sectoren = new List<Sector>();
        }
        public Tram() { }

        public override string ToString()
        {
            return this.id + " " + this.Type + " " + this.Status;
        }
    }
}
