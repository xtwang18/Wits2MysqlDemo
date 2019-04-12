using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wits2MysqlDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Wits2MySql wits2MySql = new Wits2MySql();
            wits2MySql.Run();
            Console.ReadKey();
        }
    }
}
