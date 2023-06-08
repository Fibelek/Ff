using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1zd_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string a = Console.ReadLine();
            int b = a.Length;
            int c = 0, d = 0, e = 0;
            while (e < b)
            {
                if (a[e] == '1')
                {
                    c++;
                }
                else if (a[e] == '0')
                {
                    d++;
                }
                e++;
            }
            Console.WriteLine("Колличество единиц " + c);
            Console.WriteLine("Колличество нулей " + d);
            Console.ReadKey();
        }
    }
}
