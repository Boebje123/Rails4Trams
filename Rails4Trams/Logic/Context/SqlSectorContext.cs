﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rails4Trams
{
    public class SqlSectorContext : ISectorContext
    {
        TramRepository tramrepo = new TramRepository(new SqlTramContext());
        SpoorRepository spoorrepo = new SpoorRepository(new SqlSpoorContext());
        public List<Sector> ZoekVrijSector(Spoor spoor)
        {
            List<Sector> returnSectoren = new List<Sector>();
            using (SqlConnection connection = Database.Connection)
            {
                string query = "Select * FROM sector Where spoorid = @spoorid and beschikbaarheid =0 and blokkade =0";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("spoorid", spoor.id);
     
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            returnSectoren.Add(CreateSectorFromReader(reader));

                        }
                    }
                }
            }
            return returnSectoren;
        }
        private Sector CreateSectorFromReader(SqlDataReader reader)
        {
            Tram t=tramrepo.GetTram(Convert.ToInt16(reader["tramid"]));

            Spoor s = spoorrepo.GetSpoor(Convert.ToInt16(reader["spoorid"]));
            return new Sector(Convert.ToInt32(reader["id"]),
                   t ,
                   s,
                    Convert.ToBoolean(reader["blokkade"]),
                    Convert.ToBoolean(reader["beschikbaarheid"])
                    );
        }

        public void VerplaatsTram(Tram tram,Spoor spoor,Sector sector)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "UPDATE sector SET spoorid= @spoorid,tramid =@tramid  WHERE id = @sectorid";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("sectorid",sector.id);
                    command.Parameters.AddWithValue("spoorid", spoor.id);
                    command.Parameters.AddWithValue("tramid", tram.id);


                    Convert.ToInt32(command.ExecuteNonQuery());
            
                }
            }

          
        }

        public bool BlokkeerSector(Sector sector, int status)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "UPDATE sector SET blokkade= @status  WHERE id= @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("id", sector.id);
                    command.Parameters.AddWithValue("status", status);


                    if (Convert.ToInt32(command.ExecuteNonQuery()) > 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}