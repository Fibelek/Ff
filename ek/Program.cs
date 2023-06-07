//Структурное программирование.

int n = 0, k = 0;
int sum = 0;
bool exit = false;

while (!exit)
{
    Console.WriteLine("Меню:");
    Console.WriteLine("1. Ввод данных");
    Console.WriteLine("2. Обработка");
    Console.WriteLine("3. Просмотр результатов");
    Console.WriteLine("4. Выход");

    Console.Write("Выберите пункт меню: ");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.Write("Введите n: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Введите k: ");
            k = int.Parse(Console.ReadLine());
            Console.Clear();
            break;
        case 2:
            sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += (int)Math.Pow(i, k);
            }
            Console.WriteLine("Сумма: " + sum);
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
            Console.Clear();
            break;
        case 3:
            Console.WriteLine("n = " + n);
            Console.WriteLine("k = " + k);
            Console.WriteLine("Сумма: " + sum);
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
            Console.Clear();
            break;
        case 4:
            exit = true;
            break;
        default:
            Console.WriteLine("Неверный пункт меню");
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
            Console.Clear();
            break;
    }
}










