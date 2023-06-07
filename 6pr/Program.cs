// Работа с файлами

string filename = "C:\\Users\\fibel\\Documents\\Учеба\\ОАП\\Проги\\ek\\6pr\\bin\\Debug\\net6.0\\text.txt"; // имя файла с текстом
string text = File.ReadAllText(filename); // читаем текст из файла

// разбиваем текст на слова и считаем количество слов каждой длины
var wordCounts = text.Split(new char[] { ' ', 'n', 'r', 't' }, StringSplitOptions.RemoveEmptyEntries)
    .GroupBy(w => w.Length)
    .OrderBy(g => g.Key)
    .ToDictionary(g => g.Key, g => g.Count());

// выводим количество слов каждой длины
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Слов длины {0}: {1}", i, wordCounts.ContainsKey(i) ? wordCounts[i] : 0);
}
Console.WriteLine("Слов длины более 10: {0}", wordCounts.ContainsKey(11) ? wordCounts[11] : 0);

// выводим слова каждой длины
for (int i = 1; i <= 11; i++)
{
    if (wordCounts.ContainsKey(i))
    {
        Console.WriteLine("Слова длины {0}:", i);
        foreach (var word in text.Split(new char[] { ' ', 'n', 'r', 't' }, StringSplitOptions.RemoveEmptyEntries).Where(w => w.Length == i).OrderBy(w => w))
        {
            Console.WriteLine(word);
        }
    }
}
