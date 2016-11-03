using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rails4Trams
{
    public class SqlMedewerkerContext : IMedewerkerContext
    {
        public bool Delete(Medewerker medewerker)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "DELETE FROM medewerker WHERE id= @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("id", medewerker.Id);
                    try
                    {
                        if (Convert.ToInt32(command.ExecuteNonQuery()) == 1)
                        {
                            return true;
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            return false;

        }

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

            Medewerker ReturnGebruiker = new Medewerker();
            using (SqlConnection connection = Database.Connection)
            {
                string query = "Select * FROM Medewerker Where Inlognaam = @inlognaam";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("inlognaam", inlognaam);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ReturnGebruiker = (CreateGebruikerFromReader(reader));

                        }
                    }
                }
            }
            return ReturnGebruiker;

        }
        public Medewerker GetGebruiker(int id)
        {

            Medewerker ReturnGebruiker = new Medewerker();
            using (SqlConnection connection = Database.Connection)
            {
                string query = "Select * FROM Medewerker Where id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ReturnGebruiker = (CreateGebruikerFromReader(reader));

                        }
                    }
                }
            }
            return ReturnGebruiker;

        }
        public Medewerker Insert(Medewerker gebruiker,int functieid)
        {
            using (SqlConnection connection = Database.Connection)
            {
              
            
                string query = "INSERT INTO medewerker (functieid,voornaam, achternaam, inlognaam, wachtwoord) VALUES (@functieid,@voornaam,@achternaam,@gebruikersnaam,@wachtwoord)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("Functieid", functieid);
                    command.Parameters.AddWithValue("Voornaam", gebruiker.Voornaam);
                    command.Parameters.AddWithValue("Achternaam", gebruiker.Achternaam);
                    command.Parameters.AddWithValue("Gebruikersnaam", gebruiker.Gebruikersnaam);
                    command.Parameters.AddWithValue("Wachtwoord", gebruiker.Wachtwoord);
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                      MessageBox.Show(ex.Message);
                    }
                }
                switch(functieid)
                {
                    case 1:
                        gebruiker = new Beheerder(gebruiker.Voornaam, gebruiker.Achternaam, gebruiker.Gebruikersnaam, gebruiker.Wachtwoord);
                 break;
                    case 2:
                        gebruiker = new WagenparkBeheerder(gebruiker.Voornaam, gebruiker.Achternaam, gebruiker.Gebruikersnaam, gebruiker.Wachtwoord);
                        break;
                    case 3:
                        gebruiker = new Technicus(gebruiker.Voornaam, gebruiker.Achternaam, gebruiker.Gebruikersnaam, gebruiker.Wachtwoord);
                        break;
                    case 4:
                        gebruiker = new Schoonmaker(gebruiker.Voornaam, gebruiker.Achternaam, gebruiker.Gebruikersnaam, gebruiker.Wachtwoord);
                        break;
                    case 5:
                        gebruiker = new Bestuurder(gebruiker.Voornaam, gebruiker.Achternaam, gebruiker.Gebruikersnaam, gebruiker.Wachtwoord);
                        break; 
                }               
            }
            return gebruiker;
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
            medewerkerType = Convert.ToInt32(reader["functieid"]);
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
