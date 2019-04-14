using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wits2MysqlDemo
{
    class WitsParse
    {      
        public string[] charNoArr = new string[5];
        public string[] channelNoArr = new string[5];
        public float[] valueArr = new float[5];
        
        public void Parse(string recMsg) {
            string[] split = recMsg.Split(new string[] { "\r\n"},StringSplitOptions.RemoveEmptyEntries);
            int i = 0;
            foreach (string str in split)
            {
                //Console.WriteLine(str);
                if (str != "&&" && str != "!!")
                {
                    charNoArr[i] = str.Substring(0,2);
                    channelNoArr[i] = str.Substring(2,2);
                    valueArr[i] = float.Parse(str.Substring(4, str.Length - 4));
                     Console.WriteLine("charNo= {0},channelNo = {1},value = {2}  ", charNoArr[i],channelNoArr[i],valueArr[i]);

                    ++i;
                }
            }

        }
        
    }
}
