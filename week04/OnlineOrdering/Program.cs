using System;

class Program
{
    static void Main(string[] args)
    {
        // ----- Order #1 (USA Customer) -----
        Address a1 = new Address("123 Apple St", "Dallas", "TX", "USA");
        Customer c1 = new Customer("John Doe", a1);
        Order order1 = new Order(c1);

        order1.AddProduct(new Product("Wireless Mouse", "A100", 15.99, 2));
        order1.AddProduct(new Product("Mechanical Keyboard", "A101", 49.99, 1));

        Console.WriteLine("---------------------------------------");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}");

        // ----- Order #2 (International Customer) -----
        Address a2 = new Address("45 Av. Reforma", "CDMX", "CDMX", "Mexico");
        Customer c2 = new Customer("Maria Lopez", a2);
        Order order2 = new Order(c2);

        order2.AddProduct(new Product("USB-C Cable", "B200", 9.99, 3));
        order2.AddProduct(new Product("Laptop Stand", "B201", 29.99, 1));
        order2.AddProduct(new Product("HD Webcam", "B202", 39.99, 1));

        Console.WriteLine("---------------------------------------");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}");
    }
}
