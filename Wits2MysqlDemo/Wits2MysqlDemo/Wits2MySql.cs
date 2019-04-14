using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wits2MysqlDemo
{
    class Wits2MySql
    {
        public recvServerData recvData;
        public StoreDb storeDb;
        public WitsParse witsParse = new WitsParse();
        public void Run()
        {
            //1.连接到wits服务器
            recvData = new recvServerData("127.0.0.1", 6699);
            recvData.Connect2Server();
            //2.连接到MySql数据库
            storeDb = new StoreDb("localhost", "root", "root", "witsdata01", 3306);
            storeDb.Connect2db();
            while (true)
            {
                try
                {
                    //3.获取一条wits message
                    recvData.GetData();
                    Console.WriteLine(recvData.recMsg);
                    //4.解析wits消息
                    witsParse.Parse(recvData.recMsg);
                    //5.存储到数据库表中
                    storeDb.InsertRecord(witsParse, 5);
                }
                catch (Exception e)
                {
                    //6.关闭连接
                    recvData.CloseConnection();
                }
            }

        }
    }
}
