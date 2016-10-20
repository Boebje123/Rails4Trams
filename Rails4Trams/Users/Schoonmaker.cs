using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rails4Trams
{
    public class Schoonmaker : Medewerker
    {
        public Schoonmaker(string naam, string gebruikersnaam, string wachtwoord, typeMedewerker type) : base(naam, gebruikersnaam, wachtwoord, type)
        {
        }

        public Schoonmaker(int id, string naam, string gebruikersnaam, string wachtwoord, typeMedewerker type) : base(id, naam, gebruikersnaam, wachtwoord, type)
        {
        }
    }
}
