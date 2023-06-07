using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace практика.Connection
{
    class DataBase
    {
        string connection = string.Empty;

        static string server = "(localdb)\\MSSQLLocalDB";
        static string db = "agency";

        public string ServerName { get; set; }
        public string DataBaseName { get; set; }
        /// <summary>
        /// Содержит строку подключения к локальной базе данных
        /// </summary>
        public static string ConnectionString { get; } = $"Server={server};Database={db};Trusted_Connection=True;Integrated Security=true;Column Encryption Setting=enabled";

        /// <summary>
        /// Создает строку подключения к базе данных
        /// </summary>
        /// <param name="server">Имя сервера</param>
        /// <param name="database">Имя базы данных</param>
        /// <returns>Строка подключения string</returns>
        public string Connect(string server, string database)
        {
            ServerName = server;
            DataBaseName = database;
            connection = $"Server={ServerName};Database={DataBaseName};Trusted_Connection=True;Integrated Security=true;Column Encryption Setting=enabled";
            return connection;
        }
    }
}
