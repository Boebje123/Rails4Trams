using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rails4Trams
{
    public interface IMedewerkerContext
    {
        List<Medewerker> GetAllUsers();
        Medewerker Insert(Medewerker gebruiker);
        bool Update(Medewerker gebruiker);
        bool LogIn(string inlognaam, string wachtwoord);
        Medewerker GetGebruiker(string inlognaam);
        Medewerker GetGebruiker(int id);
    }
}
