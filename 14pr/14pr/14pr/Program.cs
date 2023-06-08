using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Program
    {
        public class List
        {
            public string Brand { get; set; }
            public string Name { get; set; }
            public string Data { get; set; }
            public string DataOut { get; set; }
            public string Money { get; set; }
            public List Loi { get; set; }
            public List(string brand, string name, string data, string dataout, string money)
            {
                Brand = brand;
                Name = name;
                Data = data;
                DataOut = dataout;
                Money = money;
            }
            public List(string Brand)
            {
                this.Brand = Brand;
            }
        }
        public class SL
        {
            public List a { get; private set; }
            public List b { get; private set; }
            public void print()
            {
                List list = a;
                while (list != null)
                {
                    Console.WriteLine($"{list.Brand} {list.Name} {list.Data} {list.DataOut} {list.Money}");
                    if (list == list.Loi)
                    {
                        return;
                    }
                    list = list.Loi;
                }
            }
            public void poisk(string poisks)
            {
                List list = a;
                int count = 0;
                int k = 0;
                while (list != null)
                {
                    if (list.Brand == poisks)
                    {
                        count++;
                    }
                    k++;
                    list = list.Loi;
                }
                Console.WriteLine($"Количесво записей: {count} найдено по вашему критерию поиска" + "ee позиция {0}", k);
            }
            public void Vop(int pos, List list)
            {
                if (pos < 1)
                {
                    return;
                }
                List c = a;
                List p = null;
                int m = 0;

                while (++m != pos)
                {
                    p = c;
                    if (c.Loi == null)
                    {
                        c.Loi = list;
                        b = list;
                        return;
                    }
                    c = c.Loi;

                }
                list.Loi = c;
                if (p == null)
                {
                    a = list;
                }
                else
                {
                    p.Loi = list;
                }
            }
            public void del(int pos)
            {
                if (pos < 1)
                {
                    return;
                }
                List c = a;
                List p = null;
                int n = 0;
                while (c != null)
                {
                    if (++n == pos)
                    {
                        if (p == null)
                        {
                            a = c.Loi;
                        }
                        else
                        {
                            p.Loi = c.Loi;
                        }
                        if (c.Loi == null)
                        {
                            b = c;

                        }
                        break;
                    }
                    p = c;
                    c = c.Loi;
                }
                Console.WriteLine("Запись удалена");

            }
            public void Dob(List list)
            {
                if (a == null)
                {
                    a = list;
                }
                if (b == null)
                {
                    b = list;
                }
                b.Loi = list;
                b = list;
            }

        }
        static void Main(string[] args)
        {
            SL list = new SL();
            int count;
            string file = File.ReadAllText(@"Ремонт.txt");
            string[] rec = file.Split('.');
            count = rec.Length;
            for (int i = 0; i != count / 5; i++)
            {
                int n = i * 5;
                List ne = new List(rec[n++], rec[n++], rec[n++], rec[n++], rec[n++]);
                list.Dob(ne);
            }
            int click = 0;
            while (click != 5)
            {
                Console.WriteLine("Выберите действие: ");
                Console.WriteLine("1 - Вывести весь список");
                Console.WriteLine("2 - Поиск");
                Console.WriteLine("3 - Удаление записи");
                Console.WriteLine("4 - Вставка");
                Console.WriteLine("5 - Выход");
                click = int.Parse(Console.ReadLine());
                switch (click)
                {
                    case 1:
                        {
                            list.print();
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Введите критерий для начала поиска: ");
                            string poisks = Console.ReadLine();
                            list.poisk(poisks);
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Позиция записи которую вы хотите удалить: ");
                            int pos = int.Parse(Console.ReadLine());
                            list.del(pos); Console.ReadKey();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Введите позицию на место которой вы хотите вставить запись: ");
                            int pos = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите саму строку которую вы хотите вставить: ");
                            string poisks = Console.ReadLine();
                            list.Vop(pos, new List(poisks));
                            break;

                        }

                }
                Console.Clear();
            }
        }

    }

}
