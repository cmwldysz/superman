using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.pring();
            Person person2 = new Person("李四",16);
            person2.pring();
            Console.ReadKey();
        }
    }
    //员工类
    class Person {
        public string name;
        public int age;
        public Person() {
            this.name = "张三";
            this.age = 18;
        }
        public Person(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public void pring() {
            Console.WriteLine("姓名：{0}\t性别：{1}",name,age);
        }
    }
}
