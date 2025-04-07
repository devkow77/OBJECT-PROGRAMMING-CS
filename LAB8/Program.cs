public class Program
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class Order
    {
        public int CustomerId { get; set; }
        public string Product { get; set; }
    }

    static public void Main()
    {
        // zad 1

        /* List<string> names = new List<string> { "Anna", "Kasia", "Bartek", "Andrzej", "Krystyna" };
        var result = from name in names
                     where name.Length > 3 && name[0].Equals('A') 
                     select name;
 
        foreach (string name in result)
        {
            Console.WriteLine(name);
        } */

        // zad 2

        List<int> numbers = Enumerable.Range(1, 100).ToList();
        var result2 = from number in numbers
                      where number % 3 == 0 && number % 5 == 0
                      select number;

        foreach (int number in result2)
        {
            Console.WriteLine(number);
        }

        // zad 3

        List<Product> products = new List<Product> {
           new Product { Name = "Laptop", Price = 3000 },
           new Product { Name = "Smartphone", Price = 2000 },
           new Product { Name = "Tablet", Price = 1500 }
        };

        var result3 = from product in products
                      where product.Price > 1500
                      orderby product.Price descending
                      select product;

        foreach (Product product in result3)
        {
            Console.WriteLine(product.Name);
        }

        // zad 4

        List<string> names = new List<string> { "Ola", "Tomek", "Basia", "Jan", "Krzysztof", "Ela" };

        var result4 = from name in names
                      select name;

        var groupedResult4 = result4.GroupBy(name => name.Length);

        foreach (var groupedResult in groupedResult4)
        {
            Console.Write($"{groupedResult.Key} ");
            foreach (var name in groupedResult)
            {
                Console.Write($"{name} ");
            }
            Console.WriteLine();
        }

        // zad 5

        List<Customer> customers = new List<Customer> {
           new Customer { Id = 1, Name = "Adam" },
           new Customer { Id = 2, Name = "Ewa" }
        };

        List<Order> orders = new List<Order> {
           new Order { CustomerId = 1, Product = "Laptop" },
           new Order { CustomerId = 1, Product = "Mouse" },
           new Order { CustomerId = 2, Product = "Tablet" }
        };

        var query = from customer in customers
                    join order in orders on customer.Id equals order.CustomerId
                    select new { customer.Name, order.Product };

        foreach (var item in query)
        {
            Console.WriteLine($"{item.Name} ordered {item.Product}");
        }
    }
}