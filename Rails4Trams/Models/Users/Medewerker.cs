using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rails4Trams
{
    public class Medewerker
    {




        private int Id { get; set; }
        public string Voornaam { get; set; }
        private string Achternaam { get; set; }
        private string Gebruikersnaam { get; set; }
        private string Wachtwoord { get; set; }


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
