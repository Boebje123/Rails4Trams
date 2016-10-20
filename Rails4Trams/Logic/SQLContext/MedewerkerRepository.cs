using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rails4Trams.Logic.SQLContext
{
    public class MedewerkerRepository
    {
        private IMedewerkerContext context;
        public MedewerkerRepository(IMedewerkerContext context)
        {
            this.context = context;
        }
        public List<Medewerker> GetAllUsers()
        {
            return context.GetAllUsers();
        }
        public Medewerker Insert(Medewerker gebruiker)
        {
            return context.Insert(gebruiker);
        }
        public bool Update(Medewerker gebruiker)
        {
            return context.Update(gebruiker);
        }
        public bool LogIn(string inlognaam, string wachtwoord)
        {
            return context.LogIn(inlognaam, wachtwoord);
        }
        public Medewerker GetGebruiker(string inlognaam)
        {
            return context.GetGebruiker(inlognaam);
        }
    }
}
