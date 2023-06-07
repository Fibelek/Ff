// Методы сортировки

int n = 5; // размерность матрицы
double[,] A = new double[n, n]; // создаем матрицу

// заполняем матрицу случайными вещественными числами
Random rand = new Random();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        A[i, j] = rand.NextDouble() * 10;
    }
}

Console.WriteLine("Исходная матрица:");
PrintMatrix(A); // выводим исходную матрицу

// сортируем элементы, расположенные под главной диагональю методом «пузырька»
for (int i = 0; i < n - 1; i++)
{
    for (int j = 0; j < n - i - 1; j++)
    {
        if (A[j + 1, j] < A[j, j + 1])
        {
            double temp = A[j + 1, j];
            A[j + 1, j] = A[j, j + 1];
            A[j, j + 1] = temp;
        }
    }
}

Console.WriteLine("Отсортированная последовательность элементов, расположенных под главной диагональю:");
PrintDiagonalElements(A); // выводим отсортированную последовательность элементов
    
    static void PrintMatrix(double[,] A)
{
    int n = A.GetLength(0);
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{A[i, j],8:F2} ");
        }
        Console.WriteLine();
    }
}

static void PrintDiagonalElements(double[,] A)
{
    int n = A.GetLength(0);
    for (int i = 1; i < n; i++)
    {
        for (int j = 0; j < i; j++)
        {
            Console.Write($"{A[i, j],8:F2} ");
        }
    }
    Console.WriteLine();
}
