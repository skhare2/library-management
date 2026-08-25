using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace NEALibrary
{
    public static class DatabaseConnection // The class is static so it does not need to be instantiated and can be used as a "utility class"
    {
        private static readonly string ConnectionString = "Data Source=YOUR_SERVER_NAME;Initial Catalog=Library;Integrated Security=True;TrustServerCertificate=True;";
        // Originally I tried to use constant but as referenced I learnt I needed to use readonly
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
            //return new SqlConnection("");
        }
    }
}
