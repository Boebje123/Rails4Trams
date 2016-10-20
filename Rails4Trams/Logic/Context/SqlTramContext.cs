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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
