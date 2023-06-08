using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2zd_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string a = Console.ReadLine();
            string[] mas = a.Split('\\');
            int b = mas.Count();
            if (b > 2)
                Console.WriteLine(mas[1]);
            else
                Console.WriteLine('\\');
            Console.ReadKey();
        }
    }
}
