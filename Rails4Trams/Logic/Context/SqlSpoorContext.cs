using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rails4Trams
{
    public class SqlSpoorContext : ISpoorContext
    {
        public List<Spoor> AllSporen()
        {
            List<Spoor> returnSporen = new List<Spoor>();
            using (SqlConnection connection = Database.Connection)
            {
                string query = "Select * FROM spoor order by id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            returnSporen.Add(CreateSpoorFromReader(reader));

                        }
                    }
                }
            }
            return returnSporen;
        }

        public Spoor GetSpoor(int id)
        {
            Spoor ReturnSpoor = new Spoor();
            using (SqlConnection connection = Database.Connection)
            {
                string query = "Select * FROM spoor Where id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ReturnSpoor = (CreateSpoorFromReader(reader));

                        }
                    }
                }
            }
            return ReturnSpoor;
        }

        public bool UpdateSpoor(Spoor spoor,int status)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "UPDATE spoor SET bezetting= @status  WHERE id= @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("id", spoor.id);
                    command.Parameters.AddWithValue("status", status);


                    if (Convert.ToInt32(command.ExecuteNonQuery()) > 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public List<Spoor> Zoekspoor()
        {
            List<Spoor> returnSporen = new List<Spoor>();
            using (SqlConnection connection = Database.Connection)
            {
                string query = "Select * FROM spoor Where bezetting =0";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            returnSporen.Add(CreateSpoorFromReader(reader));

                        }
                    }
                }
            }
            return returnSporen;

        }

        private Spoor CreateSpoorFromReader(SqlDataReader reader)
        {
            
            return new Spoor(Convert.ToInt32(reader["id"]),                           
                    Convert.ToString(reader["type"]),
                    Convert.ToBoolean(reader["bezetting"]),
                    Convert.ToInt16(reader["lengte"])
                    );
        }
    }
}
