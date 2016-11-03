using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rails4Trams
{
    public class WagenparkBeheerder : Medewerker
    {
        public WagenparkBeheerder(int id, string voornaam, string achternaam, string inlognaam, string wachtwoord) : base(id, voornaam, achternaam, inlognaam, wachtwoord) { }
        public WagenparkBeheerder(string voornaam, string achternaam, string inlognaam, string wachtwoord) : base(voornaam, achternaam, inlognaam, wachtwoord)
        {

        }

        public override string ToString()
        {
            return "WagenparkBeheerder " + Voornaam;
        }
    }
}
