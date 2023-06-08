using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2zd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] X = File.ReadAllLines(@"Mas.txt").Select(int.Parse).ToArray();
            int maxX = X.Max();
            int minX = X.Min();

            int M = maxX - minX;

            int sum = 0;
            foreach (int xi in X)
            {
                if (xi > M)
                {
                    sum += xi;
                }
            }
            Console.WriteLine("Сумма элементов " + sum);
            Console.ReadKey();
        }
    }
}
