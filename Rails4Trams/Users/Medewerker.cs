using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rails4Trams
{
  public abstract class Medewerker
    {
        public enum typeMedewerker { Beheerder, WagenparkBeheerder, Technicus, Schoonmaker, Bestuurder }

        public int Id { get; set; }
        public string Naam { get; set; }
        public string Gebruikersnaam { get; set; }
        public string Wachtwoord { get; set; }
        public typeMedewerker TypeMedewerker { get; set; }

        public Medewerker(string naam,string gebruikersnaam,string wachtwoord, typeMedewerker type)
        {
            this.Naam = naam;
            this.Gebruikersnaam = gebruikersnaam;
            this.Wachtwoord = wachtwoord;
            this.TypeMedewerker = type;
        }
        public Medewerker(int id,string naam, string gebruikersnaam, string wachtwoord, typeMedewerker type)
        {
            this.Id = id;
            this.Naam = naam;
            this.Gebruikersnaam = gebruikersnaam;
            this.Wachtwoord = wachtwoord;
            this.TypeMedewerker = type;
        }

       
    }
}
