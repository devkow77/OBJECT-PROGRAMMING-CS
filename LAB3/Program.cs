public class Program
{
    // Zad 1
    class Book
    {
        private string title;
        private string author;
        private int pageCount;

        public Book(string title, string author, int pageCount)
        {
            this.title = title;
            this.author = author;
            this.pageCount = pageCount;
        }

        public void printDetails()
        {
            Console.WriteLine($"Title: {title} | Author: {author} | PageCount: {pageCount}");
        }
    }

    // Zad 2
    class MathConstants {
        public const double PI = 3.14159;
    }

    // Zad 3
    class Person
    {
        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0) throw new ArgumentException("Wiek nie moze byc na minusie!");
                age = value;
            }
        }

        public Person(int age)
        {
            this.age = age;
        }
    }

    // Zad 4
    class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }
    }

    // Zad 5
    class BankAccount
    {
        private int saldo;

        public int Saldo
        {
            get { return saldo; }
        }

        public BankAccount()
        {
            this.saldo = 0;
        }

        public void AddMoney(int value)
        {
            saldo += value;
            ZmianaSalda.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler ZmianaSalda;
    }

    // Zad 6
    class Point
    {
        private int x { get; }
        private int y { get; }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.x + p2.x, p1.y + p2.y);
        }

        public override string ToString() => $"({this.x},{this.y})";
    }

    // Zad 7
    class StudentGrades
    {
        private int[] grades;

        public StudentGrades(int size)
        {
            grades = new int[size];
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= grades.Length) throw new IndexOutOfRangeException("Nieprawidlowy indeks!");
                return grades[index];
            }
            set
            {
                if (index < 0 || index >= grades.Length) throw new IndexOutOfRangeException("Nieprawidlowy indeks!");
                grades[index] = value;
            }
        }

        public void printGrades()
        {
            for(int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine($"Indeks {i}: Ocena = {grades[i]}");
            }
        }
    }

    // Zad 8
    class Car
    {
        private string brand;
        private string model;
        private int year;

        public Car(string brand, string model, int year)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
        }

        public override string ToString() => $"Marka: {brand} | Model: {model} | Rocznik: {year}";
    }

    // Zad 9
    class FileManager
    {
        private FileStream fileStream;
        private string filePath;

        public FileManager(string path)
        {
            this.filePath = path;
            this.fileStream = new FileStream(filePath, FileMode.OpenOrCreate);
            Console.WriteLine($"Plik '{filePath}' zostal otwarty");
        }

        ~FileManager()
        {
            CloseFile();
            Console.WriteLine($"Plik '{filePath}' zostal zamkniety!");
        }

        public void WriteData(string data)
        {
            if (fileStream != null)
            {
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(data);
                fileStream.Write(bytes, 0, bytes.Length);
                Console.WriteLine("Dane zostały zapisane do pliku.");
            }
        }

        public void CloseFile()
        {
            if(filePath != null)
            {
                fileStream.Close();
                fileStream = null;
            }
        }
    }

    // Zad 10
    class Library
    {
        public class Book
        {
            private string title;
            private string author;
            private int pageCount;

            public Book(string title, string author, int pageCount)
            {
                this.title = title;
                this.author = author;
                this.pageCount = pageCount;
            }

            public override string ToString() => $"Tytul: {title} | Autor: {author} | Ilosc stron: {pageCount}";
            
        }
    }

    // Zad 11
    public sealed class Settings // sealed nie pozwala na dziedziczenie przez inne klasy
    {
        private static Settings _instance;
        private static readonly object _lock = new object();

        public string Theme { get; set; }
        public int Volume { get; set; }

        private Settings()
        {
            Theme = "Light";
            Volume = 50;
        }

        public static Settings GetInstance()
        {
            if(_instance == null)
            {
                lock (_lock) // lock zapewnia ze tylko jeden watek moze naraz wejsc do seksji krytycznej
                {
                    if(_instance == null)
                    {
                        _instance = new Settings();
                    }
                }
            }

            return _instance;
        }

        public void ShowSettings()
        {
            Console.WriteLine($"Theme: {Theme}, Volume: {Volume}");
        }

    }

    // Zad 12
    public class InstanceCounter
    {
        private static int instanceCount = 0; // static - kazda instacja zawiera referencje do tej zmiennej a nie tworzy kopie

        public InstanceCounter()
        {
            instanceCount++;
        }

        public static int GetInstanceCount()
        {
            return instanceCount;
        }
    }

    // Zad 13

    public struct PersonStruct
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public PersonStruct(string name, int age, string email)
        {
            Name = name;
            Age = age;
            Email = email;
        }
    }

    public record PersonRecord(string Name, int Age, string Email);

    static public void Main()
    {
        // Zad 1 Test:
        //Book book = new Book("Opowiesci z Narni", "Aleksandry Fredro", 450);
        //book.printDetails();

        // Zad 2 Test:

        //Console.WriteLine($"Wartosc PI: {MathConstants.PI}");
        //MathConstants.PI = 3.14;
        //Console.WriteLine("Próba zmiany stałej zakończyła się niepowodzeniem, ponieważ const nie można modyfikować.");

        // Zad 3 Test:

        //Person person = new Person(18);
        //Console.WriteLine($"Person ma {person.Age} lat");
        //person.Age = -1;
        //Console.WriteLine($"Person po zmianie ma {person.Age} lat");

        // Zad 4 Test:

        //Calculator calc = new Calculator();
        //Console.WriteLine($"Suma 3 + 7 = {calc.Add(3, 7)}");
        //Console.WriteLine($"Suma 4.5 + 8.6 = {calc.Add(4.5, 8.6)}");
        //Console.WriteLine($"Mnozenie 5.5 * 2.5 = {calc.Multiply(5.5, 2.5)}");

        // Zad 5 Test:

        //BankAccount bank = new BankAccount();
        //bank.ZmianaSalda += ZmianaSalda;

        //bank.AddMoney(200);

        // Zad 6 Test:

        //Point a = new Point(2, 3);
        //Point b = new Point(5, 7);
        //Point c = a + b;

        //Console.WriteLine(c);

        // Zad 7 Test:

        //StudentGrades student = new StudentGrades(3);
        //student[0] = 5;
        //student[1] = 4;
        //student[2] = 3;
        //student.printGrades();

        // Zad 8 Test:

        //Car toyota = new Car("Toyota", "Rav 4", 2018);
        //Console.WriteLine(toyota.ToString());

        // Zad 9 Test:

        //CreateFile();

        // Zad 10 Test:

        //Library library = new Library();
        //Library.Book book = new Library.Book("Opowiesci z Narni", "Aleksandry Fredro", 350);
        //Console.WriteLine(book.ToString());

        // Zad 11 Test:

        //Settings settings1 = Settings.GetInstance();
        //Settings settings2 = Settings.GetInstance();

        //Console.WriteLine("Instancje sa takie same (settings1, settings2): " + ReferenceEquals(settings1, settings2));

        //settings1.Theme = "Dark";
        //settings1.Volume = 75;

        //settings2.ShowSettings();

        // Zad 12 Test:

        //InstanceCounter obj1 = new InstanceCounter();
        //Console.WriteLine("Instances: " + InstanceCounter.GetInstanceCount());

        //InstanceCounter obj2 = new InstanceCounter();
        //Console.WriteLine("Instances: " + InstanceCounter.GetInstanceCount());

        //InstanceCounter obj3 = new InstanceCounter();
        //Console.WriteLine("Instances: " + InstanceCounter.GetInstanceCount());

        // Zad 13 Test:

        //PersonStruct personStruct = new PersonStruct("Alice", 25, "alice@gmail.com");
        //PersonRecord personRecord = new PersonRecord("Bob", 30, "bob@gmail.com");
        //PersonRecord personRecord2 = personRecord with { Name = "Changed"};

        //Console.WriteLine($"Struct - Name: {personStruct.Name}, Age: {personStruct.Age}, Email: {personStruct.Email}");
        //Console.WriteLine($"Record - Name: {personRecord.Name}, Age: {personRecord.Age}, Email: {personRecord.Email}");
        //Console.WriteLine($"Record - Name: {personRecord2.Name}, Age: {personRecord2.Age}, Email: {personRecord2.Email}");
        
    }

    // Zad 5 Funkcja:
    static void ZmianaSalda(object sender, EventArgs e)
    {
        if(sender is BankAccount acc)
        {
            Console.WriteLine("Saldo konta bankowego zostalo zaktualizowane!");
            Console.WriteLine($"Stan konta wynosi {acc.Saldo} PLN");
        }
       
    }

    // Zad 9 Funkcja:
    static void CreateFile()
    {
        FileManager fileManager = new FileManager("test.txt");
        fileManager.WriteData("Przykladowe dane do pliku.");
    }
}