using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rails4Trams
{
    public class Database
    {
        private static readonly string connectionString = "Server=mssql.fhict.local;Database=dbi324877;User Id=dbi324877;Password=123456";


        /// <summary>
        /// Creates a new database connection and directly opens it. The caller
        /// is resposible for properly closing the connection.
        /// </summary>
        public static SqlConnection Connection
        {
            get
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
        }
    }
}
