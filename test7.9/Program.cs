using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7._9
{
    class Program
    {
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        public static double Multiply(int x, double y)
        {
            return x * y;
        }
        public static double Multiply(double x, double y)
        {
            return x * y;
        }
        public static int Multiply(int x, int y,int z)
        {
            return x * y *z;
        }
        public static double Multiply(int x, int y, double z)
        {
            return x * y * z;
        }
        public static double Multiply(int x, double y, double z)
        {
            return x * y * z;
        }
        public static double Multiply(double x, double y, double z)
        {
            return x * y*z;
        }
        static void Main(string[] args)
        {
            int x1 = 3;
            int y1 = 6;
            int z1 = 9;
            double x2 = 3.33;
            double y2 = 6.66;
            double z2 = 9.99;
            Console.WriteLine("两个整数相乘：{0}*{1}={2}", x1, y1, Multiply(x1, y1));
            Console.WriteLine("\n整数与浮点型数据相乘：{0}*{1}={2}", x1, y2, Multiply(x1, y2));
            Console.WriteLine("\n两个浮点型数据相乘：{0}*{1}={2}", x2, y2, Multiply(x2, y2));
            Console.WriteLine("\n三个整数相乘：{0}*{1}*{2}={3}", x1, y1, z1, Multiply(x1, y1, z1));
            Console.WriteLine("\n两个整数与一个浮点数相乘：{0}*{1}*{2}={3}", x1, y1, z2, Multiply(x1, y1, z2));
            Console.WriteLine("\n一个整数与两个浮点数相乘：{0}*{1}*{2}={3}", x1, y2, z2, Multiply(x1, y2, z2));
            Console.WriteLine("\n三个浮点数相乘：{0}*{1}*{2}={3}", x2, y2, z2, Multiply(x2, y2, z2));

            Console.ReadKey();
        }
    }
}
