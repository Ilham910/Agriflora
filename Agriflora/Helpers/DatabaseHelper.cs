using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agriflora.Helpers
{
    public class DatabaseHelper
    {
        private static string connString =
        "Host=localhost;" + // server PostgreSQL
        "Port=5432;" + // port default PostgreSQL
        "Database=Agriflora;" + // nama database
        "Username=postgres;" + // username
        "Password=NYAMAN910;";  // password

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connString);
        }
    }
}
