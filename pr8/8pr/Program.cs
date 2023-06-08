using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8pr
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
            int b;
            for (int i = 1; i < n; i++)
            {
                a = mas[i];
                b = i;
                while ((b > 0) && (a < mas[b - 1]))
                {
                    mas[b] = mas[b - 1];
                    b--;
                }
                mas[b] = a;
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
