using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12pr
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix(3, 5);
            matrix.zapmat();
            int minProductColumn = matrix.zd1();
            Console.WriteLine($"Колона минимума {minProductColumn}");
            Console.ReadKey();
        }
        class Matrix
        {
            private int[,] matrix;

            public Matrix(int rows, int cols)
            {
                matrix = new int[rows, cols];
            }

            public void zapmat()
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write($"Введите значение ({i},{j}): ");
                        int value = int.Parse(Console.ReadLine());
                        matrix[i, j] = value;
                    }
                }
            }

            public int zd1()
            {
                int minProduct = int.MaxValue;
                int minProductColumn = -1;

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int product = 1;
                    bool Elements = true;

                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        int element = matrix[i, j];

                        if (Math.Abs(element) > 10)
                        {
                            Elements = false;
                            break;
                        }

                        product *= element;
                    }

                    if (Elements && product < minProduct)
                    {
                        minProduct = product;
                        minProductColumn = j;
                    }
                }

                return minProductColumn;
            }
        }
    }
}



