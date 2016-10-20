using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rails4Trams
{
    public class Beheerder : Medewerker
    {
        public Beheerder(string naam, string gebruikersnaam, string wachtwoord, typeMedewerker type) : base(naam, gebruikersnaam, wachtwoord, type)
        {
        }

        public Beheerder(int id, string naam, string gebruikersnaam, string wachtwoord, typeMedewerker type) : base(id, naam, gebruikersnaam, wachtwoord, type)
        {
        }
    }
}
