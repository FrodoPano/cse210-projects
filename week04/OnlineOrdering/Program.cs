using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Widget", "W123", 3.00m, 5);
        Product product2 = new Product("Gadget", "G456", 10.00m, 2);
        Product product3 = new Product("Thingamajig", "T789", 15.00m, 1);

        // Create Addresses
        Address address1 = new Address("123 Elm St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

        // Create Customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create Orders
        Order order1 = new Order(customer1, 5, 35);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2, 5, 35);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display order details
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetDisplayPacking());
        Console.WriteLine(order1.GetDisplayShipping());
        Console.WriteLine($"Total Price: ${order1.TotalPrice():F2}\n");

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetDisplayPacking());
        Console.WriteLine(order2.GetDisplayShipping());
        Console.WriteLine($"Total Price: ${order2.TotalPrice():F2}");
    }
}