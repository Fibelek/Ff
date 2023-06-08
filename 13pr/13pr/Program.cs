using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _13pr
{
    class Program
    {
        struct WatchRepair
        {
            public string Brand;
            public string Name;
            public string StartDate;
            public string StoprDate;
            public string Money;
        }
        class Base
        {
            private WatchRepair[] Repairs;
            public Base(int size)
            {
                Repairs = new WatchRepair[size];
            }
            public void ReadFile(string file)
            {
                string[] lines = File.ReadAllLines(file);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] data = lines[i].Split('.');

                    Repairs[i].Brand = data[0];
                    Repairs[i].Name = data[1];
                    Repairs[i].StartDate = data[2];
                    Repairs[i].StoprDate = data[3];
                    Repairs[i].Money = data[4];
                }
            }
            public void Menu()
            {
                Console.WriteLine("Все записи");
                for (int i = 0; i < Repairs.Length; i++)
                {
                    Console.WriteLine("{0}) Бренд: {1}, Мастер: {2}, Дата начала работ: {3}, Дата окончания ремонта: {4}, Стоимость {5}", i + 1, Repairs[i].Brand, Repairs[i].Name, Repairs[i].StartDate, Repairs[i].StoprDate, Repairs[i].Money);
                }
            }
            public void poisk(string poisks)
            {
                Console.WriteLine("Список записей, которые содержат \"{0}\"в записи", poisks);
                for (int i = 0; i < Repairs.Length; i++)
                {
                    if (Repairs[i].Brand == poisks | Repairs[i].Name == poisks | Repairs[i].StartDate == poisks | Repairs[i].StoprDate == poisks | Repairs[i].Money == poisks)
                    {
                        Console.WriteLine("{0}) Бренд: {1}, Мастер: {2}, Дата начала работ: {3}, Дата окончания ремонта: {4}, Стоимость {5}", i + 1, Repairs[i].Brand, Repairs[i].Name, Repairs[i].StartDate, Repairs[i].StoprDate, Repairs[i].Money);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Запись не найдена");
                        break;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Количество записей в базе");
            int size = int.Parse(Console.ReadLine());
            Base d = new Base(size);
            string file = @"Ремонт.txt";
            d.ReadFile(file);
            Console.Clear();
            int click = 0;
            while (click != 3)
            {
                Console.WriteLine("Выберите");
                Console.WriteLine("1: Все записи");
                Console.WriteLine("2: Поиск");
                Console.WriteLine("3: Выход");
                click = int.Parse(Console.ReadLine());
                switch (click)
                {
                    case 1:
                        d.Menu();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Задайте критерий для начала поиска");
                        string poisks = Console.ReadLine();
                        d.poisk(poisks);
                        break;
                }
                Console.Clear();

            }

        }
    }
}
