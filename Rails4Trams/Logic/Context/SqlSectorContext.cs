using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rails4Trams.Logic.Context
{
    public class SqlSectorContext : ISectorContext
    {
        TramRepository tramrepo = new TramRepository(new SqlTramContext());
        SpoorRepository spoorrepo = new SpoorRepository(new SqlSpoorContext());
        public List<Sector> ZoekVrijSector()
        {
            throw new NotImplementedException();
        }
        private Sector CreateSectorFromReader(SqlDataReader reader)
        {
            Tram t=tramrepo.GetTram(Convert.ToInt16(reader["tramid"]));

            Spoor s = spoorrepo.GetSpoor(Convert.ToInt16(reader["spoorid"]));
            return new Sector(Convert.ToInt32(reader["id"]),
                   t ,
                   s,
                    Convert.ToBoolean(reader["blokkade"]),
                    Convert.ToBoolean(reader["beschikbaar"])
                    );
        }
    }
}
