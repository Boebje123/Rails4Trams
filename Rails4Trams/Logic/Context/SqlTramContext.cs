using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rails4Trams
{
    public class SqlTramContext : ITramContext
    {
        public List<Tram> GetAllTrams()
        {
            List<Tram> result = new List<Tram>();
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM tram ORDER BY ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(CreateTramFromReader(reader));
                        }
                    }
                }
            }
            return result;
        }

        public Tram GetTram(int id)
        {
            Tram ReturnTram = new Tram();
            using (SqlConnection connection = Database.Connection)
            {
                string query = "Select * FROM tram Where id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ReturnTram = (CreateTramFromReader(reader));

                        }
                    }
                }
            }
            return ReturnTram;
        }

        public List<Tram> GetTramsGroteDienst()
        {
            List<Tram> result = new List<Tram>();
            using (SqlConnection connection = Database.Connection)
            {
                string query = "select * from tram where id = (select a.TramID from activiteit a inner join soortactiviteit sa on a.activiteitid = sa.activiteitid where a.activiteitid = 3 and datediff(m, totaaltijdactiviteit, getdate()) > 6)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(CreateTramFromReader(reader));
                        }
                    }
                }
            }
            return result;
        }

        public List<Tram> GetTramsGroteSchoonmaak()
        {
            List<Tram> result = new List<Tram>();
            using (SqlConnection connection = Database.Connection)
            {
                string query = "select * from tram where id in (select a.TramID from activiteit a inner join soortactiviteit sa on a.activiteitid = sa.activiteitid where a.activiteitid = 1 and datediff(m, totaaltijdactiviteit, getdate()) > 6)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(CreateTramFromReader(reader));
                        }
                    }
                }
            }
            return result;
        }

        public List<Tram> GetTramsKleineDienst()
        {
            List<Tram> result = new List<Tram>();
            using (SqlConnection connection = Database.Connection)
            {
                string query = "select * from tram where id in (select a.TramID from activiteit a inner join soortactiviteit sa on a.activiteitid = sa.activiteitid where a.activiteitid = 4 and datediff(m, totaaltijdactiviteit, getdate()) > 3)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(CreateTramFromReader(reader));
                        }
                    }
                }
            }
            return result;
        }

        public List<Tram> GetTramsKleineSchoonmaak()
        {
            List<Tram> result = new List<Tram>();
            using (SqlConnection connection = Database.Connection)
            {
                string query = "select * from tram where id in (select a.TramID from activiteit a inner join soortactiviteit sa on a.activiteitid = sa.activiteitid where a.activiteitid = 2 and datediff(m, totaaltijdactiviteit, getdate()) > 3)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(CreateTramFromReader(reader));
                        }
                    }
                }
            }
            return result;
        }

        public Tram Insert(Tram tram)
        {
            throw new NotImplementedException();
        }

        public bool Update(Tram tram)
        {
            throw new NotImplementedException();
        }

        private Tram CreateTramFromReader(SqlDataReader reader)
        {
            int typeid = Convert.ToInt32(reader["Typeid"]);
            int statusid = Convert.ToInt32(reader["status"]);
            string type = "";
            string status ="";

            switch (typeid)
            {
                case 1:
                    type = "Combino";
                        break;
                case 2:
                    type = "11G";
                    break;
                case 3:
                    type = "Dubbel Kop Combino";
                    break;
                case 4:
                    type = "12G";
                    break;
                case 5:
                    type = "Opleidingstram";
                    break;
            }
            switch (statusid)
            {
                case 1:
                    status = "Defect";
                    break;
                case 2:
                    status = "Schoonmaak";
                    break;
                case 3:
                    status = "Dienst";
                    break;
                case 4:
                    status = "Remise";
                    break;     
            }
            return new Tram(Convert.ToInt32(reader["id"]),
                    type,
                    status,
                    Convert.ToInt32(reader["lengte"]),
                    Convert.ToBoolean(reader["Spoorgebonden"]));
        }
    }
}
