using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rails4Trams
{
    public class Schoonmaker : Medewerker
    {
        public Schoonmaker(int id, string voornaam, string achternaam, string inlognaam, string wachtwoord) : base(id, voornaam, achternaam, inlognaam, wachtwoord)
        {
        }

        public override string ToString()
        {
            return "Schoonmaker " + Voornaam;
        }
    }
}
