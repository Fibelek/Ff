// Динамические списки

class Painting
{
    public string Name;
    public string Artist;
    public decimal Price;
    public Painting Next;
}

class Gallery
{
    private Painting Head;

    public void AddPainting()
    {
        Console.Write("Введите название картины: ");
        string name = Console.ReadLine();
        Console.Write("Введите имя художника: ");
        string artist = Console.ReadLine();
        Console.Write("Введите цену: ");
        decimal price = decimal.Parse(Console.ReadLine());
        Painting painting = new Painting
        {
            Name = name,
            Artist = artist,
            Price = price
        };
        painting.Next = Head;
        Head = painting;
    }

    public void ViewPaintings()
    {
        Console.WriteLine("Название картины Художник Цена");
        Painting painting = Head;
        while (painting != null)
        {
            Console.WriteLine($"{painting.Name} {painting.Artist} {painting.Price}");
            painting = painting.Next;
        }
    }

    public void SearchByCriteria()
    {
        Console.Write("Введите критерий поиска (1 - название картины, 2 - художник, 3 - цена): ");
        int criteria = int.Parse(Console.ReadLine());
        switch (criteria)
        {
            case 1:
                Console.Write("Введите название картины: ");
                string name = Console.ReadLine();
                Painting painting = Head;
                while (painting != null)
                {
                    if (painting.Name == name)
                    {
                        Console.WriteLine($"{painting.Name} {painting.Artist} {painting.Price}");
                    }
                    painting = painting.Next;
                }
                break;
            case 2:
                Console.Write("Введите имя художника: ");
                string artist = Console.ReadLine();
                painting = Head;
                while (painting != null)
                {
                    if (painting.Artist == artist)
                    {
                        Console.WriteLine($"{painting.Name} {painting.Artist} {painting.Price}");
                    }
                    painting = painting.Next;
                }
                break;
            case 3:
                Console.Write("Введите цену: ");
                decimal price = decimal.Parse(Console.ReadLine());
                painting = Head;
                while (painting != null)
                {
                    if (painting.Price == price)
                    {
                        Console.WriteLine($"{painting.Name} {painting.Artist} {painting.Price}");
                    }
                    painting = painting.Next;
                }
                break;
            default:
                Console.WriteLine("Некорректный критерий поиска.");
                break;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Gallery gallery = new Gallery();
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Добавить картину");
            Console.WriteLine("2. Просмотреть картину");
            Console.WriteLine("3. Поиск по галерее");
            Console.WriteLine("4. Выход");
            Console.Write("Выберите действие: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    gallery.AddPainting();
                    break;
                case 2:
                    gallery.ViewPaintings();
                    break;
                case 3:
                    gallery.SearchByCriteria();
                    break;
                case 4:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Некорректный выбор.");
                    break;
            }
        }
    }
}
