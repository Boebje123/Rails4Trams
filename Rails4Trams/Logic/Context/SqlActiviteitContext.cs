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
        public Activiteit Insert(Activiteit activiteit,Medewerker m, Tram t)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "INSERT INTO activiteit (medewerkerid, Tramid, eindtijd, begintijd, activiteitid) VALUES (@Medewerkerid, @Tramid, @Eindtijd, @begintijd, @ActiviteitID)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("medewerkerid", activiteit.medewerker.Id);
                    command.Parameters.AddWithValue("Tramid",t.id);
                    command.Parameters.AddWithValue("eindtijd", activiteit.EindDatum);
                    command.Parameters.AddWithValue("begintijd", activiteit.BeginDatum);
                    command.Parameters.AddWithValue("activiteitid", activiteit.ActiviteitiD);


                    try
                    {

                        command.ExecuteNonQuery();
                    }
                    catch { }


                }

                activiteit = new Activiteit(activiteit.BeginDatum, activiteit.EindDatum, activiteit.ActiviteitiD,m,t);
            }


            return activiteit;
        }
    }
}
