using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7._23
{
    interface ILanguage {
         void dialogue(string str);
    }
    class Chinese: ILanguage
    {
        public void dialogue(string str) {
            Console.WriteLine("您对中国友人说："+str);
         }
    }
    class American:ILanguage {
        public void dialogue(string str)
        {
            Console.WriteLine("您对美国友人说：" + str);
        }
    }
    class Program
    {
        /// <summary>
        /// 判断是否是中文
        /// </summary>
        /// <param name="str">话术</param>
        /// <returns></returns>
        public static bool IsChinese(string str) {
            bool flag = false;
            UnicodeEncoding a = new UnicodeEncoding();
            byte[] b = a.GetBytes(str);
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] != 0)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            return flag;
        }
        static void Main(string[] args)
        {
            ILanguage language;
            Console.WriteLine("请输入您要说的话：");
            string str = Console.ReadLine();
            if (IsChinese(str))
            {
                language = new Chinese();
                language.dialogue(str);
            }
            else
            {
                language = new American();
                language.dialogue(str);
            }
            Console.ReadKey();
        }
    }
}
