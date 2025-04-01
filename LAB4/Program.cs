using System;


class Program
{
    // Zad 1

    //class Employee
    //{
    //    public string Name { get; set; }
    //    public decimal Salary { get; set; }

    //    public Employee(string name, decimal salary)
    //    {
    //        Name = name;
    //        Salary = salary;
    //    }

    //    public void DisplayInfo()
    //    {
    //        Console.WriteLine($"Name: {Name}");
    //        Console.WriteLine($"Salary: {Salary:C}");  
    //    }
    //    public virtual decimal CalculateBonus()
    //    {
    //        return 0;
    //    }
    //}

    // Zad 2

    //class Employee
    //{
    //    public string Name { get; set; }
    //    public decimal Salary { get; set; }

    //    public Employee(string name, decimal salary)
    //    {
    //        Name = name;
    //        Salary = salary;
    //    }

    //    public virtual void DisplayInfo()
    //    {
    //        Console.WriteLine($"Name: {Name}");
    //        Console.WriteLine($"Salary: {Salary:C}");
    //    }

    //    public virtual decimal CalculateBonus()
    //    {
    //        return 0;
    //    }
    //}

    //class Manager : Employee
    //{
    //    public int TeamSize { get; set; }

    //    public Manager(string name, decimal salary, int teamSize)
    //        : base(name, salary)
    //    {
    //        TeamSize = teamSize;
    //    }

    //    public override void DisplayInfo()
    //    {
    //        base.DisplayInfo();  
    //        Console.WriteLine($"Team Size: {TeamSize}");
    //    }
    //    public override decimal CalculateBonus()
    //    {
    //        return Salary * 0.20m; 
    //    }
    //}

    //class Developer : Employee
    //{
    //    public string ProgrammingLanguage { get; set; }

    //    public Developer(string name, decimal salary, string programmingLanguage)
    //        : base(name, salary)
    //    {
    //        ProgrammingLanguage = programmingLanguage;
    //    }

    //    public override void DisplayInfo()
    //    {
    //        base.DisplayInfo();  
    //        Console.WriteLine($"Programming Language: {ProgrammingLanguage}");
    //    }

    //    public override decimal CalculateBonus()
    //    {
    //        return Salary * 0.10m; 
    //    }
    //}

    // Zad 3

    //abstract class Person
    //{
    //    public string Name { get; set; }

    //    public Person(string name)
    //    {
    //        Name = name;
    //    }

    //    public abstract void DisplayInfo();
    //}

    //class Employee : Person
    //{
    //    public decimal Salary { get; set; }

    //    public Employee(string name, decimal salary) : base(name)
    //    {
    //        Salary = salary;
    //    }

    //    public override void DisplayInfo()
    //    {
    //        Console.WriteLine($"Name: {Name}");
    //        Console.WriteLine($"Salary: {Salary:C}");
    //    }

    //    public virtual decimal CalculateBonus()
    //    {
    //        return 0;
    //    }
    //}

    //class Manager : Employee
    //{
    //    public int TeamSize { get; set; }

    //    public Manager(string name, decimal salary, int teamSize)
    //        : base(name, salary)
    //    {
    //        TeamSize = teamSize;
    //    }

    //    public override void DisplayInfo()
    //    {
    //        base.DisplayInfo();  
    //        Console.WriteLine($"Team Size: {TeamSize}");
    //    }
    //    public override decimal CalculateBonus()
    //    {
    //        return Salary * 0.20m;  
    //    }
    //}

    //class Developer : Employee
    //{
    //    public string ProgrammingLanguage { get; set; }

    //    public Developer(string name, decimal salary, string programmingLanguage)
    //        : base(name, salary)
    //    {
    //        ProgrammingLanguage = programmingLanguage;
    //    }

    //    public override void DisplayInfo()
    //    {
    //        base.DisplayInfo(); 
    //        Console.WriteLine($"Programming Language: {ProgrammingLanguage}");
    //    }
    //    public override decimal CalculateBonus()
    //    {
    //        return Salary * 0.10m; 
    //    }
    //}

    // Zad 4

    abstract class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public abstract void DisplayInfo();
    }

    class Employee : Person
    {
        public decimal Salary { get; set; }

        public Employee(string name, decimal salary) : base(name)
        {
            Salary = salary;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Salary: {Salary:C}");
        }

        public virtual decimal CalculateBonus()
        {
            return 0;
        }
    }

    class Manager : Employee
    {
        public int TeamSize { get; set; }

        public Manager(string name, decimal salary, int teamSize)
            : base(name, salary)
        {
            TeamSize = teamSize;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Team Size: {TeamSize}");
        }

        public override decimal CalculateBonus()
        {
            return Salary * 0.20m;
        }
    }

    class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }

        public Developer(string name, decimal salary, string programmingLanguage)
            : base(name, salary)
        {
            ProgrammingLanguage = programmingLanguage;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Programming Language: {ProgrammingLanguage}");
        }

        public override decimal CalculateBonus()
        {
            return Salary * 0.10m;
        }
    }


    public static void Main()
    {
        // Zad 1 Test:

        //Employee employee = new Employee("John Doe", 5000m);
        //employee.DisplayInfo();
        //Console.WriteLine($"Bonus: {employee.CalculateBonus():C}");

        // Zad 2 Test:

        //Manager manager = new Manager("Alice Smith", 9000m, 10);
        //Developer developer = new Developer("John Doe", 7000m, "C#");

        //Console.WriteLine("Manager Info:");
        //manager.DisplayInfo();
        //Console.WriteLine($"Bonus: {manager.CalculateBonus():C}");
        //Console.WriteLine();

        //Console.WriteLine("Developer Info:");
        //developer.DisplayInfo();
        //Console.WriteLine($"Bonus: {developer.CalculateBonus():C}");

        // Zad 3 Test:

        //Manager manager = new Manager("Alice Smith", 9000m, 10);
        //Developer developer = new Developer("John Doe", 7000m, "C#");

        //Console.WriteLine("Manager Info:");
        //manager.DisplayInfo();
        //Console.WriteLine($"Bonus: {manager.CalculateBonus():C}");
        //Console.WriteLine();

        //Console.WriteLine("Developer Info:");
        //developer.DisplayInfo();
        //Console.WriteLine($"Bonus: {developer.CalculateBonus():C}");

        // Zad 4 Test:

        Manager manager = new Manager("Alice Smith", 9000m, 10);
        Developer developer = new Developer("John Doe", 7000m, "C#");

        Console.WriteLine("Manager Info:");
        manager.DisplayInfo();
        Console.WriteLine($"Bonus: {manager.CalculateBonus():C}");
        Console.WriteLine();

        Console.WriteLine("Developer Info:");
        developer.DisplayInfo();
        Console.WriteLine($"Bonus: {developer.CalculateBonus():C}");
    }
}

