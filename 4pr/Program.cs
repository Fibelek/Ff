// Двумерные массивы.

Console.WriteLine("Введите размерность массива: ");
int n = int.Parse(Console.ReadLine()); // размерность матрицы
int[,] a = new int[n, n]; // исходная матрица

// вводим значения в матрицу через консольный ввод
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write("Введите значение для a[{0}, {1}]: ", i, j);
        a[i, j] = int.Parse(Console.ReadLine());
    }
}

// заменяем отрицательные элементы на 0, а положительные на 1
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (a[i, j] < 0)
        {
            a[i, j] = 0;
        }
        else
        {
            a[i, j] = 1;
        }
    }
}

// выводим нижнюю треугольную матрицу
for (int i = 0; i < n; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write(a[i, j] + " ");
    }
    Console.WriteLine();
}
