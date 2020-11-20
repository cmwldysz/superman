using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace test14_4_1
{
    class Program
    {
        static Socket _CllentSocket;
        static void Main(string[] args)
        {
            string _serverIP = "127.0.0.1";
            string _serverPort = "8080";
            _CllentSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //将拿到的字符串转换成IP地址与端口
            IPAddress IP = IPAddress.Parse(_serverIP);
            int Port = Convert.ToInt32(_serverPort);
            //形成IP地址与端口号
            IPEndPoint IPEnd = new IPEndPoint(IP, Port);
            try
            {
                _CllentSocket.Connect(IPEnd);
                Console.WriteLine("连接服务器成功");
                _CllentSocket.Send(Encoding.UTF8.GetBytes(IP + " 你好服务器，我是客户端"));
            }
            catch (Exception)
            {
                Console.WriteLine("连接服务器失败");
            }
            //创建线程用以接收数据
            Thread GetMessageThread = new Thread(ReceiveMessage);
            GetMessageThread.IsBackground = true;
            GetMessageThread.Start();
            Console.ReadKey();
        }
        private static byte[] _result = new byte[1024];
        public static void ReceiveMessage()
        {
            while (true)
            {
                int recelivelength = _CllentSocket.Receive(_result);
                //判断长度内容
                if (recelivelength > 0)
                {
                    Console.WriteLine("来自服务器的消息：" + Encoding.UTF8.GetString(_result, 0, recelivelength));//输出接收的服务器消息
                }
            }
        }
     }
}
