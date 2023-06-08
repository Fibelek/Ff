// Методы 

static int CountWordsEndingWithChar(string inputString, char endingChar)
{
    int count = 0;
    string[] words = inputString.Split(' ');

    foreach (string word in words)
    {
        if (word.EndsWith(endingChar.ToString()))
        {
            count++;
        }
    }

    return count;
}
Console.WriteLine("Введите слова");
string inputString = Console.ReadLine();
Console.WriteLine("Введите последний символ слова");
char endingChar = char.Parse(Console.ReadLine());

int count = CountWordsEndingWithChar(inputString, endingChar);

Console.WriteLine($"слов которые кончаются на эту буква '{endingChar}': {count}");

