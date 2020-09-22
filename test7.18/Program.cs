using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7._18
{
    class person {
        public string selfIntroduction(string name) {
            return "我是" + name;
        }
    }
    class Learned : person {
        public new string selfIntroduction(string name)
        {
            return base.selfIntroduction(name)+"博士";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            person ps = new person();
            Console.WriteLine(ps.selfIntroduction("XXX"));
            Learned learned = new Learned();
            Console.WriteLine(learned.selfIntroduction("XXX"));
            Console.ReadKey();
        }
    }
}
