using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PDC_Lauren
{
    class SQLCommunication
    {
        public string serverName;
        public string databaseName;
        public string userName;
        public string password;
        public string cs;

        // sqlcommunication constructor
        // creates the connection string
        public SQLCommunication(string serverName, string databaseName, string userName, string password)
        {
            this.serverName = serverName;
            this.databaseName = databaseName;
            this.userName = userName;
            this.password = password;
            this.cs = "Data Source=" + this.serverName + ";" +
                "Initial Catalog=" + this.databaseName + ";" +
                "User ID=" + this.userName + ";" +
                "Password=" + this.password;
        }
    }
}
