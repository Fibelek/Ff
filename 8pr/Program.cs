// Структуры

struct Medicine
{
    public string Name;
    public DateTime ManufactureDate;
    public DateTime ExpiryDate;
}

class Pharmacy
{
    static void Main(string[] args)
    {
        Console.Write("номер припората: ");
        int n = int.Parse(Console.ReadLine());

        Medicine[] medicines = new Medicine[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"введите детали {i + 1}:");
            Console.Write("название: ");
            medicines[i].Name = Console.ReadLine();
            Console.Write("Дата производства (dd/mm/yyyy): ");
            medicines[i].ManufactureDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.Write("Срок годности (dd/mm/yyyy): ");
            medicines[i].ExpiryDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        }

        Console.WriteLine("номера припарата:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Номер {i + 1}:");
            Console.WriteLine($"Название: {medicines[i].Name}");
            Console.WriteLine($"Дата производства: {medicines[i].ManufactureDate.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Срок годности: {medicines[i].ExpiryDate.ToString("dd/MM/yyyy")}");
            Console.WriteLine();
        }

        Console.Write("Введите название препората: ");
        string searchName = Console.ReadLine();

        bool found = false;
        for (int i = 0; i < n; i++)
        {
            if (medicines[i].Name.ToLower() == searchName.ToLower())
            {
                Console.WriteLine($"Номер {i + 1}:");
                Console.WriteLine($"Название препората: {medicines[i].Name}");
                Console.WriteLine($"Дата производства: {medicines[i].ManufactureDate.ToString("dd/MM/yyyy")}");
                Console.WriteLine($"Срок годности: {medicines[i].ExpiryDate.ToString("dd/MM/yyyy")}");
                Console.WriteLine();
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine($"Препорат с таким названием '{searchName}' не найден.");
        }
    }
}

