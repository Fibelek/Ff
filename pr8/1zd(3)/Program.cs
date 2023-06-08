using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1zd_3_
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
                for (int j = i + 1; j < n; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        a = mas[i];
                        mas[i] = mas[j];
                        mas[j] = a;
                    }
                }
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
