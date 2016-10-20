using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rails4Trams
{
    public class SqlMedewerkerContext : IMedewerkerContext
    {
        public List<Medewerker> GetAllUsers()
        {
            List<Medewerker> result = new List<Medewerker>();
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM Medewerker ORDER BY ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(CreateGebruikerFromReader(reader));
                        }
                    }
                }
            }
            return result;
        }

        public Medewerker GetGebruiker(string inlognaam)
        {
            throw new NotImplementedException();

        }

        public Medewerker Insert(Medewerker gebruiker)
        {
            throw new NotImplementedException();
        }

        public bool LogIn(string inlognaam, string wachtwoord)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "Select * FROM Medewerker WHERE Inlognaam = @inlognaam AND Wachtwoord = @wachtwoord";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("inlognaam", inlognaam);
                    command.Parameters.AddWithValue("Wachtwoord", wachtwoord);

                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.HasRows)
                    {
                        return true;
                    }
                    else return false;
                }
            }
        }

        public bool Update(Medewerker gebruiker)
        {
            throw new NotImplementedException();
        }
        private Medewerker CreateGebruikerFromReader(SqlDataReader reader)
        {
            int medewerkerType;
            medewerkerType = Convert.ToInt32(reader["id"]);
            switch (medewerkerType)
            {
                case 1:
                    return new Beheerder(Convert.ToInt32(reader["id"]),
                     Convert.ToString(reader["Voornaam"]),
                     Convert.ToString(reader["Achternaam"]),
                     Convert.ToString(reader["Inlognaam"]),
                     Convert.ToString(reader["Wachtwoord"]));
                case 2:
                    return new WagenparkBeheerder(Convert.ToInt32(reader["id"]),
                   Convert.ToString(reader["Voornaam"]),
                   Convert.ToString(reader["Achternaam"]),
                   Convert.ToString(reader["Inlognaam"]),
                   Convert.ToString(reader["Wachtwoord"]));
                case 3:
                    return new Technicus(Convert.ToInt32(reader["id"]),
                   Convert.ToString(reader["Voornaam"]),
                   Convert.ToString(reader["Achternaam"]),
                   Convert.ToString(reader["Inlognaam"]),
                   Convert.ToString(reader["Wachtwoord"]));
                case 4:
                    return new Schoonmaker(Convert.ToInt32(reader["id"]),
                   Convert.ToString(reader["Voornaam"]),
                   Convert.ToString(reader["Achternaam"]),
                   Convert.ToString(reader["Inlognaam"]),
                   Convert.ToString(reader["Wachtwoord"]));
                case 5:
                    return new Bestuurder(Convert.ToInt32(reader["id"]),
                   Convert.ToString(reader["Voornaam"]),
                   Convert.ToString(reader["Achternaam"]),
                   Convert.ToString(reader["Inlognaam"]),
                   Convert.ToString(reader["Wachtwoord"]));
            }

            return null;

        }
    }
}
