using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9pr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string s = Console.ReadLine();
            int odin = s.Count(f => f == '1');
            int nol = s.Count(f => f == '0');
            Console.WriteLine("1={0},0={1}", odin, nol);
            Console.ReadKey();
        }
    }
}
