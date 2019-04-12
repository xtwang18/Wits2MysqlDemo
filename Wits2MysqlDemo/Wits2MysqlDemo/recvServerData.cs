using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace Wits2MysqlDemo
{
    class recvServerData
    {
        public IPAddress iP { get; set; }
        public IPEndPoint ipe { get; set; }
        public Socket clientSocket { get; set; }
        public recvServerData(string host,int port) {
            iP = IPAddress.Parse(host);
            ipe = new IPEndPoint(iP,port);
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }
        public void Connect2Server() {
            try
            {
                clientSocket.Connect(ipe);
                Console.WriteLine("Connected.");
            }
            catch (SocketException e) {
                Console.WriteLine("Fail Connect to Server -{0}",e.ToString());
            }
        }

        public void CloseConnection() {
            clientSocket.Close();
        }
        public string GetData() {

            return null;
        }       
    }
}
