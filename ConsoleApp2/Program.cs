// Строки.

Console.Write("Введите строку S: ");
string s = Console.ReadLine();

Console.Write("Введите строку S1: ");
string s1 = Console.ReadLine();

Console.Write("Введите строку S2: ");
string s2 = Console.ReadLine();

// заменяем все вхождения строки S1 на строку S2 в строке S
s = s.Replace(s1, s2);

Console.WriteLine("Результат: " + s);
