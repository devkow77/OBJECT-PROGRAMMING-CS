public class Program
{
    // Zad 1

    class Matematyka
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Add(int a, double b)
        {
            return a + b;
        }

        public double Add(double a, int b)
        {
            return a + b;
        }
    }

    // Zad 2

    public class Pojazd
    {
        public virtual void Jazda()
        {
            Console.WriteLine("Pojazd porusza się.");
        }
    }

    public class Samochod : Pojazd
    {
        public override void Jazda()
        {
            Console.WriteLine("Samochód jedzie po drodze.");
        }
    }

    public class Motocykl : Pojazd
    {
        public override void Jazda()
        {
            Console.WriteLine("Motocykl jedzie na dwóch kołach.");
        }
    }

    // Zad 3

    public class Zwierze
    {
        public virtual void WydajDzwiek()
        {
            Console.WriteLine("Zwierzę wydaje dźwięk.");
        }
        public void Jedz()
        {
            Console.WriteLine("Zwierzę je.");
        }
    }

    public class Pies : Zwierze
    {
        public override void WydajDzwiek()
        {
            Console.WriteLine("Pies szczeka: Hau hau!");
        }
    }

    public class Kot : Zwierze
    {
        public override void WydajDzwiek()
        {
            Console.WriteLine("Kot miauczy: Miau miau!");
        }
    }

    public class Sfinks : Kot
    {
        public override sealed void WydajDzwiek()
        {
            Console.WriteLine("Sfinks wydaje dźwięk: Mrrrrr!");
        }
    }

    public class Faraon : Sfinks
    {
        //public override void WydajDzwiek()
        //{
        //    Console.WriteLine("Faraon wydaje dźwięk."); // nie mozna sealed nadpisac
        //}
    }

    // Zad 4

    public abstract class Vehicle
    {
        public double Speed { get; set; }

        public abstract void Move();

        public void ShowInfo()
        {
            Console.WriteLine($"Speed: {Speed} km/h");
        }
    }

    public class Car : Vehicle
    {
        public double FuelConsumption { get; set; }
        public double FuelLevel { get; set; }  

        public override void Move()
        {
            if (FuelLevel > 0)
            {
                Console.WriteLine("The car is driving...");
                FuelLevel -= FuelConsumption * Speed / 100; 
                if (FuelLevel < 0) FuelLevel = 0;
            }
            else
            {
                Console.WriteLine("The car has no fuel to move.");
            }
        }
        public new void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Fuel Consumption: {FuelConsumption} L/100 km");
            Console.WriteLine($"Fuel Level: {FuelLevel} L");
        }
    }

    public class Bike : Vehicle
    {
        public bool HasBell { get; set; }

        public override void Move()
        {
            Console.WriteLine("The bike is moving...");
        }

        public new void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Has Bell: {HasBell}");
        }
    }

    // Zad 5

    public interface ITask
    {
        // Właściwość opisująca zadanie
        string Description { get; set; }

        // Właściwość określająca, czy zadanie zostało ukończone
        bool IsCompleted { get; set; }

        // Metoda, która zmienia stan IsCompleted na true
        void Complete();

        // Metoda do wyświetlania informacji o zadaniu
        void ShowInfo();
    }

    public class SimpleTask : ITask
    {
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

        public SimpleTask(string description)
        {
            Description = description;
            IsCompleted = false;
        }

        public void Complete()
        {
            IsCompleted = true;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Simple Task: {Description}");
            Console.WriteLine($"Completed: {IsCompleted}");
        }
    }

    public class UrgentTask : ITask
    {
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public int Priority { get; set; }

        public UrgentTask(string description, int priority)
        {
            Description = description;
            Priority = priority;
            IsCompleted = false;
        }

        public void Complete()
        {
            IsCompleted = true;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Urgent Task: {Description}");
            Console.WriteLine($"Priority: {Priority}");
            Console.WriteLine($"Completed: {IsCompleted}");
        }
    }



    static void Main()
    {
        // Zad 1 Test:

        //Matematyka math = new Matematyka();

        //int sumInt = math.Add(5, 3);             
        //double sumDouble = math.Add(5.5, 3.2);   
        //double sumIntDouble = math.Add(5, 3.5);  
        //double sumDoubleInt = math.Add(5.5, 3); 

        //Console.WriteLine($"Wynik dodawania int: {sumInt}");
        //Console.WriteLine($"Wynik dodawania double: {sumDouble}");
        //Console.WriteLine($"Wynik dodawania int i double: {sumIntDouble}");
        //Console.WriteLine($"Wynik dodawania double i int: {sumDoubleInt}");

        // Zad 2 Test:

        //Pojazd pojazd = new Pojazd();
        //Pojazd samochod = new Samochod();
        //Pojazd motocykl = new Motocykl();

        //pojazd.Jazda();     
        //samochod.Jazda();   
        //motocykl.Jazda();   

        // Zad 3 Test:

        //Zwierze zwierze = new Zwierze();
        //Zwierze pies = new Pies();
        //Zwierze kot = new Kot();
        //Zwierze sfinks = new Sfinks();

        //zwierze.WydajDzwiek();  
        //pies.WydajDzwiek();     
        //kot.WydajDzwiek();      
        //sfinks.WydajDzwiek();  

        //zwierze.Jedz();         
        //pies.Jedz();          
        //kot.Jedz();             
        //sfinks.Jedz();

        // Zad 4 Test:

        //Car car = new Car
        //{
        //    Speed = 80,
        //    FuelConsumption = 6.5,
        //    FuelLevel = 50
        //};

        //Bike bike = new Bike
        //{
        //    Speed = 15,
        //    HasBell = true
        //};

        //List<Vehicle> vehicles = new List<Vehicle> { car, bike };

        //foreach (var vehicle in vehicles)
        //{
        //    Console.WriteLine("\nVehicle Info:");
        //    vehicle.ShowInfo();
        //    vehicle.Move();
        //}

        // Zad 5 Test:

        //List<ITask> tasks = new List<ITask>();

        //SimpleTask task1 = new SimpleTask("Do the laundry");
        //UrgentTask task2 = new UrgentTask("Submit the report", 1);
        //SimpleTask task3 = new SimpleTask("Buy groceries");
        //UrgentTask task4 = new UrgentTask("Prepare presentation", 5);

        //tasks.Add(task1);
        //tasks.Add(task2);
        //tasks.Add(task3);
        //tasks.Add(task4);

        //task1.Complete();
        //task2.Complete();

        //Console.WriteLine("Task List:");
        //foreach (var task in tasks)
        //{
        //    task.ShowInfo();
        //    Console.WriteLine();
        //}
    }
}
