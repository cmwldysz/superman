using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace test14_4_2
{
    class Program
    {
        static Socket _ServerSocket;
        static void Main()
        {
            _ServerSocket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            int port = 8080;//端口  
            IPAddress IP = IPAddress.Parse("127.0.0.1");
            IPEndPoint iPEnd = new IPEndPoint(IP, port);
            _ServerSocket.Bind(iPEnd);
            _ServerSocket.Listen(10);
            Console.WriteLine("服务器启动成功，等待用户接入…");//输出消息  
            Thread listenThread = new Thread(ListenClientConnect);
            listenThread.IsBackground = true;
            listenThread.Start();
            Console.ReadKey();
        }
        static Socket clientSocket;
        static Dictionary<string, Socket> ascok = new Dictionary<string, Socket>();
        public static void ListenClientConnect() {
            while (true)
            {
                try
                {
                    clientSocket = _ServerSocket.Accept();
                    ascok.Add(clientSocket.RemoteEndPoint.ToString(), clientSocket);
                    Thread ReceiveThread = new Thread(RecelveMessage);
                    ReceiveThread.IsBackground = true;
                    ReceiveThread.Start(clientSocket);   
                }
                catch
                {
                    break;
                }
            }
        }
        private static byte[] _result = new byte[1024];
        public static void RecelveMessage(object clientSocket) {
            Socket myClientSocket = (Socket)clientSocket;
            while (true)
            {
                try
                {
                    int resultNumber = myClientSocket.Receive(_result);
                    if (resultNumber > 0)
                    {
                        //添加到消息列表当中
                        Console.WriteLine("有客户端接入，客户IP：" + myClientSocket.RemoteEndPoint.ToString());
                        Console.WriteLine("来自客户端的消息：" + Encoding.UTF8.GetString(_result, 0, resultNumber));//输出接收的消息 
                        myClientSocket.Send(Encoding.UTF8.GetBytes("我是服务器，欢迎光临！"));
                    }
                }
                catch
                {
                    break;
                }
            }
        }
    }
}
