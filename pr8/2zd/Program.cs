using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2zd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность ");
            int n = int.Parse(Console.ReadLine());

            int[,] mas = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Введите элемент ");
                    mas[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{mas[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.Write("****************");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    for (int k = j + 1; k < n; k++)
                    {
                        if (mas[i, j] > mas[i, k])
                        {
                            int temp = mas[i, j];
                            mas[i, j] = mas[i, k];
                            mas[i, k] = temp;
                        }
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mas[i, j] > 0)
                    {
                        Console.Write($"{mas[i, j]} ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
