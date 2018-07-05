using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PDC
{
    class SQLCommunication
    {
        public static string serverName;
        public static string databaseName;
        public static string userName;
        public static string password;
        public static string tableName;
        public static string cs;

        // sqlcommunication constructor
        // creates the connection string
        public SQLCommunication(string serverName, string databaseName, string userName, string password)
        {
            SQLCommunication.serverName = serverName;
            SQLCommunication.databaseName = databaseName;
            SQLCommunication.userName = userName;
            SQLCommunication.password = password;
            SQLCommunication.cs = "Data Source=" + SQLCommunication.serverName + ";" +
                "Initial Catalog=" + SQLCommunication.databaseName + ";" +
                "User ID=" + SQLCommunication.userName + ";" +
                "Password=" + SQLCommunication.password;
        }
    }
}
