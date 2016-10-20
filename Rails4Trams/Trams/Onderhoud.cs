using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rails4Trams.Users
{
   public class Onderhoud
    {
        public enum soortOnderhoud {KleineSchoonmaakBeurt,GroteSchoonmaakBeurt,KleineServiceBeurt,GroteServiceBeurt }
        public string Beschrijving { get; set; }
        public DateTime BeginDatum { get; set; }
        public DateTime EindDatum { get; set; }
        public soortOnderhoud Soortonderhoud { get; set; }

        private List<Tram> Trams;

        public Onderhoud(string beschrijving,DateTime beginDatum,DateTime eindDatum,soortOnderhoud soortonderhoud)
        {
            this.Beschrijving = beschrijving;
            this.BeginDatum = beginDatum;
            this.EindDatum = eindDatum;
            this.Soortonderhoud = soortonderhoud;
            this.Trams = new List<Tram>();
        }
    }
}
