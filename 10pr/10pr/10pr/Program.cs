using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10pr
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = -1;
            string line = "";
            while (n != 4)
            {
                PrintMenu();
                n = int.Parse(Console.ReadLine());
                if (n == 1)
                {
                    line = Task1();
                    Console.ReadKey();
                }
                else if (n == 2)
                {
                    Task2(line);
                }
                else if (n == 3)
                {
                    Task3(line);
                }
            }

        }
        static void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("Виберите пункт меню:");
            Console.WriteLine(" 1 - Ввод данных");
            Console.WriteLine(" 2 - Просмотр данных");
            Console.WriteLine(" 3 - Обработка");
            Console.WriteLine(" 4 - Выход");
        }
        static string Task1()
        {
            Console.Clear();
            Console.WriteLine("Введите новую строку");
            return Console.ReadLine();
        }
        static void Task2(string input)
        {
            Console.Clear();
            Console.WriteLine("Текущая строка");
            Console.WriteLine(input);
            Console.ReadKey();
        }
        static void Task3(string input)
        {
            Console.Clear();
            Console.WriteLine("Введите длину слова");
            int lenght = int.Parse(Console.ReadLine());
            int coiuntWord = 0;
            string[] words = input.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == lenght)
                    coiuntWord++;
            }
            Console.WriteLine("Найдено слов " +coiuntWord);
            Console.ReadKey();
        }
    }
}
