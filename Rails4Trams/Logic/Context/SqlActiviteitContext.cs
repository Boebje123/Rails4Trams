using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rails4Trams
{
    public class SqlActiviteitContext : IActiviteitContext
    {
        public Activiteit Insert(Activiteit activiteit)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "INSERT INTO activiteit (medewerkerid, Tramid, eindtijd, begintijd, activiteitid) VALUES (@Medewerkerid, @Tramid, @Eindtijd, @begintijd, @ActiviteitID)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("medewerkerid", activiteit.medewerker.Id);
                    command.Parameters.AddWithValue("Tramid", activiteit.Tram.id);
                    command.Parameters.AddWithValue("eindtijd", activiteit.EindDatum);
                    command.Parameters.AddWithValue("begintijd", activiteit.BeginDatum);
                    command.Parameters.AddWithValue("activiteitid", activiteit.ActiviteitiD);


                    try
                    {

                        command.ExecuteNonQuery();
                    }
                    catch { }


                }

                activiteit = new Activiteit(activiteit.BeginDatum, activiteit.EindDatum, activiteit.ActiviteitiD, activiteit.medewerker, activiteit.Tram);
            }


            return activiteit;
        }

        public List<Activiteit> VraagSchoonmaaklijstAan()
        {
            List<Activiteit> result = new List<Activiteit>();
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM activiteit ORDER BY ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(CreateActiviteitFromReader(reader));
                        }
                    }
                }
            }
            return result;
        }
        private Activiteit CreateActiviteitFromReader(SqlDataReader reader)
        {
            MedewerkerRepository m = new MedewerkerRepository(new SqlMedewerkerContext());
            Medewerker medewerker = m.GetGebruiker(Convert.ToInt32(reader["medewerkerid"]));
            TramRepository t = new TramRepository(new SqlTramContext());
            Tram tram = t.GetTram(Convert.ToInt32(reader["tramid"]));
            return new Activiteit(
                   Convert.ToInt32(reader["id"]),
                   Convert.ToDateTime(reader["begintijd"]),
                   Convert.ToDateTime(reader["eindtijd"]),                
                   Convert.ToInt32(reader["activiteitid"]),
                    medewerker,
                    tram
                    );
        }
    }
}
