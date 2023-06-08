using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lines = File.ReadAllText("Dad.txt");
            int Start = 0;
            int count = 0;
            int last = 0;
            Console.WriteLine("Исходный текст " + lines);
            while (true)
            {
                int op = lines.IndexOf('(', Start);

                if (op == -1)
                {
                    break;
                }
                int close = lines.IndexOf(')', op);
                if (close == -1)
                {
                    break;
                }
                string text = lines.Substring(op, close - op + 1);
                Console.WriteLine(text);
                Start = close + 1;
                count++;
                last += text.Count(char.IsLetter);
            }
            Console.WriteLine("Количество частей в скобках " + count);
            Console.WriteLine("Количество букв " + last);
            Console.ReadKey();
        }
    }
}