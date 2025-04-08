using System;

class Program
{
    static void Main(string[] args)
    {
        // Address + Customer 1
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Alice Smith", address1);

        // Order 1
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Wireless Mouse", "WM001", 25, 2));
        order1.AddProduct(new Product("USB-C Cable", "UC123", 9, 3));

        // Address + Customer 2
        Address address2 = new Address("45 Elm Rd", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Bob Chen", address2);

        // Order 2
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Bluetooth Speaker", "BS987", 49, 1));
        order2.AddProduct(new Product("Phone Stand", "PS222", 14, 2));

        // Display Order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalPrice():0.00}\n");

        // Display Order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalPrice():0.00}");
    }
}