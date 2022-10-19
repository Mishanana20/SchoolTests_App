using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace SqlConn
{
    class DBUtils
    {
        public static Task GetDBConnection()//параметры строки подключения к БД
        {
            string host = ConfigurationManager.AppSettings.Get("host");
            int port = Convert.ToInt32(ConfigurationManager.AppSettings.Get("port"));
            string server = ConfigurationManager.AppSettings.Get("server");
            string database = ConfigurationManager.AppSettings.Get("database");
            string username = ConfigurationManager.AppSettings.Get("username");
            string password = ConfigurationManager.AppSettings.Get("password");

            return DBMSSQLUtils.GetDBConnection(host, port, server, database, username, password);
        }
    }
}
