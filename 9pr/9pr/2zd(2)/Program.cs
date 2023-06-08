using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2zd_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите полное имя файла ");
            string s = Console.ReadLine();
            int index_y = 0;
            int index_x = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if ('\\' == s[i])
                {
                    index_x = i;
                    break;
                }
            }
            for (int i = index_x + 1; i < s.Length; i++)
            {
                if ('\\' == s[i])
                {
                    index_y = i;
                    break;
                }
            }
            for (int i = index_x + 1; i < index_y; i++)
            {
                Console.Write(s[i]);
            }
            Console.ReadKey();
        }
    }
}
