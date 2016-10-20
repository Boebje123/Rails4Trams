using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rails4Trams
{
    public class Medewerker
    {




        public int Id { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Gebruikersnaam { get; set; }
        public string Wachtwoord { get; set; }


        public Medewerker(string voornaam, string achternaam, string gebruikersnaam, string wachtwoord)
        {
            this.Voornaam = voornaam;
            this.Achternaam = achternaam;
            this.Gebruikersnaam = gebruikersnaam;
            this.Wachtwoord = wachtwoord;

        }

        public Medewerker(int id, string voornaam, string achternaam, string gebruikersnaam, string wachtwoord)
        {
            this.Id = id;
            this.Voornaam = voornaam;
            this.Achternaam = achternaam;
            this.Gebruikersnaam = gebruikersnaam;
            this.Wachtwoord = wachtwoord;

        }
        public Medewerker()
        {

        }

    }
}
