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
            Console.WriteLine("Размерность массива");
            int n = int.Parse(Console.ReadLine());
            int[] mas = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите элемент{i}");
                mas[i] = int.Parse(Console.ReadLine());
            }
            int a;
            for (int i = 0; i < n; i++)
            {
                a = i;
                for (int j = i; j < n; j++)
                {
                    if (mas[j] < mas[a])
                    {
                        a = j;
                    }
                }
                if (mas[a] == mas[i])
                    continue;
                int b = mas[i];
                mas[i] = mas[a];
                mas[a] = b;
            }
            Console.WriteLine("Результат");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mas[i]);
            }
            Console.ReadKey();
        }
    }
}
