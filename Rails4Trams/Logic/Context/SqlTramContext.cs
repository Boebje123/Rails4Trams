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
            throw new NotImplementedException();
        }

        public List<Tram> GetTramsGroteSchoonmaak()
        {
            List<Tram> result = new List<Tram>();
            using (SqlConnection connection = Database.Connection)
            {
                string query = "select * FROM tram WHERE DATEDIFF(m, laatstegrotebeurt, GETDATE()) > 6";
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
            throw new NotImplementedException();
        }

        public List<Tram> GetTramsKleineSchoonmaak()
        {
            List<Tram> result = new List<Tram>();
            using (SqlConnection connection = Database.Connection)
            {
                string query = "select * FROM tram WHERE DATEDIFF(m, laatsteKleinebeurt, GETDATE()) > 3";
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
            return new Tram(Convert.ToInt32(reader["id"]),
                    Convert.ToString(reader["Type"]),
                    Convert.ToString(reader["status"]),
                    Convert.ToInt32(reader["lengte"]),
                    Convert.ToBoolean(reader["Beschikbaarheid"]));
        }
    }
}
