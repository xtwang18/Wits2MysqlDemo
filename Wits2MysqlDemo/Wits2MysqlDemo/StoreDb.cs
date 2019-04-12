using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace Wits2MysqlDemo
{
    class StoreDb
    {
        public MySqlConnection conn;
        public string database;
        public StoreDb(string server, string user, string pswd, string database, int port)
        {
            this.database = database;
            string connStr = "server=" + server + "user=" + user + "database=" + database + "port=" + port;
            conn = new MySqlConnection(connStr);
        }

        public void Connect2db()
        {
            try
            {
                conn.Open();
                Console.WriteLine("Connected to database : {0}", this.database);
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Failed to connect database : {0}", e.ToString());
            }
        }

        public void InsertRecord()
        {

        }

    }
}
