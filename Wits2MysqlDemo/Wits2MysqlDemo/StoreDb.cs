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
            string connStr =  $"server={server};user={user};password={pswd};database={database};port={port}";            
            Console.WriteLine(connStr);
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

        public void InsertRecord(WitsParse witsParse,int number)
        {
        
            string str = $"insert into w{witsParse.charNoArr[0]}("; 
            for(int i = 0; i < number - 1;i++)
                str += $"w{witsParse.channelNoArr[i]},";
            str += $"w{witsParse.channelNoArr[number - 1]}) values(";
            for (int i = 0; i < number - 1; i++)
                str += $"{witsParse.valueArr[i]},";
            str += $"{witsParse.valueArr[number - 1]})";
        
        //    string sqlInsert = $"insert into w{witsParse.channelNoArr}()";
            Console.WriteLine(str);
           MySqlCommand cmd = new MySqlCommand(str, conn);
          cmd.ExecuteNonQuery();
        }

    }
}
