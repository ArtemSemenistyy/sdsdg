namespace ConsoleApp1;

internal class Program
{
    enum AlcCategory
    {
        a,
        b,
        c, 
        d
    }

    struct Drink
    {
        public string name;
        public float alc;
    }

    struct Student
    {
        /// <summary>
        /// Sosal?
        /// </summary>
        public string name;
        public string lastName;
        public uint id;
        public (int, Drink) volume;
        public AlcCategory category;
    }

    public static void Main(string[] args)
    {
        // Console.WriteLine($"int - {int.MaxValue} - {int.MinValue}");
        // Console.WriteLine($"uint - {uint.MaxValue} - {uint.MinValue}");
        // Console.WriteLine($"float - {float.MaxValue} - {float.MinValue}");
        // Console.WriteLine($"double - {double.MaxValue} - {double.MinValue}");
        // Console.WriteLine($"decimal - {decimal.MaxValue} - {decimal.MinValue}");
        // Console.WriteLine($"short - {short.MaxValue} - {short.MinValue}");
        // Console.WriteLine($"ushort - {ushort.MaxValue} - {ushort.MinValue}");
        // Console.WriteLine($"long - {long.MaxValue} - {long.MinValue}");
        // Console.WriteLine($"ulong - {ulong.MaxValue} - {ulong.MinValue}");
        // Console.WriteLine($"char - {char.MaxValue} - {char.MinValue}");
        // Console.WriteLine($"byte - {byte.MaxValue} - {byte.MinValue}");
        // Console.WriteLine($"sbyte - {sbyte.MaxValue} - {sbyte.MinValue}");
        // Console.WriteLine();
        //
        // Console.Write("Введите имя: ");
        // string name = Console.ReadLine();
        // Console.Write("Введите город: ");
        // string city = Console.ReadLine();
        // Console.Write("Введите возраст: ");
        // byte age = byte.Parse(Console.ReadLine());
        // Console.Write("Введите пинкод: ");
        // ushort pincode = ushort.Parse(Console.ReadLine());
        //
        // Console.WriteLine($"Имя: {name}");
        // Console.WriteLine($"Город: {city}");
        // Console.WriteLine($"Возраст: {age}");
        // Console.WriteLine($"Пинкод: {pincode}");
        // Console.WriteLine();
        //
        // Console.Write("Введите строку: ");
        // string input = Console.ReadLine();
        // string result = "";
        //
        // foreach (char letter in input)
        // {
        //     if (char.IsUpper(letter))
        //     {
        //         result += char.ToLower(letter);
        //     } else if (char.IsLower(letter))
        //     {
        //         result += char.ToUpper(letter);
        //     }
        //     else
        //     {
        //         result += letter;
        //     }
        // }
        //
        // Console.WriteLine(result);
        // Console.WriteLine();
        //
        // double normPrice = 10;
        // double salePrice = 10;
        // double holidayPrice = 500;
        //
        // Console.WriteLine(Math.Floor(holidayPrice / (normPrice * (salePrice / 100))));
        // Console.WriteLine();
        
        
        
        Drink drink1 = new Drink();
        Drink drink2 = new Drink();
        Drink drink3 = new Drink();
        drink1.name = "Пиво";
        drink1.alc = 5.5f;
        drink2.name = "Вино";
        drink2.alc = 12f;
        drink3.name = "Водка";
        drink3.alc = 40f;

        Student[] students = new Student[5];

        for (int i = 0; i < students.Length; i++)
        {
            students[i] = new Student();
        }

        students[0].name = "1";
        students[0].lastName = "1";
        students[0].id = 1;
        students[0].volume = (100, drink3);
        students[0].category = AlcCategory.b;
        students[1].name = "2";
        students[1].lastName = "2";
        students[1].id = 2;
        students[1].volume = (750, drink1);
        students[1].category = AlcCategory.c;
        students[2].name = "3";
        students[2].lastName = "3";
        students[2].id = 3;
        students[2].volume = (0, drink2);
        students[2].category = AlcCategory.d;
        students[3].name = "4";
        students[3].lastName = "4";
        students[3].id = 4;
        students[3].volume = (200, drink2);
        students[3].category = AlcCategory.b;
        students[4].name = "5";
        students[4].lastName = "5";
        students[4].id = 5;
        students[4].volume = (200, drink3);
        students[4].category = AlcCategory.a;

        int totalVolume = 0;
        float totalAlc = 0;
        
        for (int i = 0; i < students.Length; i++)
        {
            totalVolume += students[i].volume.Item1;
            totalAlc += students[i].volume.Item1 * (students[i].volume.Item2.alc / 100);
        }

        Console.WriteLine($"Общий объем выпитого: {totalVolume}");
        Console.WriteLine($"Общий объем алкоголя: {totalAlc}");

        for (int i = 0; i < students.Length; i++)
        {
            float volume = (float)students[i].volume.Item1 / totalVolume * 100;
            float alc = students[i].volume.Item1 * (students[i].volume.Item2.alc / 100) / totalAlc * 100;
            Console.WriteLine($"{students[i].lastName} {students[i].name} выпил {volume}% жидкости от общего количества " +
                              $"и {alc}% алкоголя от общего количества");
        }
    }
}