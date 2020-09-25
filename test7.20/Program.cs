using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7._20
{
    class Computer {
        public virtual void viewPhoto() {
            Console.WriteLine("通过鼠标点击打开照片");
        }
    }
    class Ipad : Computer {
        public override void viewPhoto()
        {
            Console.WriteLine("Ipad是通过手指点击触摸屏的方式打开照片");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Computer[] comp = new Computer[2];
            comp[0] = new Computer();
            comp[1] = new Ipad();
            comp[0].viewPhoto();
            comp[1].viewPhoto();
            Console.ReadKey();
        }
    }
}
