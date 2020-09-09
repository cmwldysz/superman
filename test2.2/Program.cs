using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  ★★★          ★★★          ★★★     ");
            Console.WriteLine("★       ★     ★       ★     ★      ★    ");
            Console.WriteLine("★          ★★            ★★        ★    ");
            Console.Write("  ★");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("    情    人    节    快    乐！  ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ★");
            Console.WriteLine("    ★              ★               ★     ");
            Console.WriteLine("      ★          ★  ★           ★     ");
            Console.WriteLine("        ★      ★      ★      ★      ");
            Console.WriteLine("            ★               ★         ");
            Console.WriteLine("\n\n\n\n");


            char a = '\u2605';
            Console.WriteLine("  {0}{0}{0}        {0}{0}{0}        {0}{0}{0}  ", a);
            Console.WriteLine("{0}     {0}    {0}       {0}    {0}     {0}  ", a);
            Console.WriteLine("{0}       {0}{0}            {0}{0}      {0}  ", a);
            Console.WriteLine("  {0}   情  人  节  快  乐!       {0}  ", a);
            Console.WriteLine("    {0}            {0}          {0}  ", a);
            Console.WriteLine("      {0}      {0}    {0}      {0}  ", a);
            Console.WriteLine("        {0}  {0}        {0}  {0} ", a);
            Console.WriteLine("          {0}            {0}  ", a);
            Console.ReadKey();
        }
    }
}
