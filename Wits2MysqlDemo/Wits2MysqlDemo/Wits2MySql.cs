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
        public void Run() {
            //1.连接到wits服务器
            recvData = new recvServerData("192.168.1.215",6699);
            recvData.Connect2Server();
            //2.连接到MySql数据库
            storeDb = new StoreDb("localhost","root","","WitsDataChart8",3306);
            //3.获取一条wits message
            //4.解析wits消息
            //5.存储到数据库表中
            //6.关闭连接
            recvData.CloseConnection();
        }
    }
}
