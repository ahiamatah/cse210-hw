using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        // Create addresses
        Address address1 = new Address("123 Maple St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Oak Ave", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("John Smith", address1);
        Customer customer2 = new Customer("Alice Brown", address2);

        // Create orders for each customer
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "L123", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "M456", 25.50, 2));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Desk Chair", "C789", 150.00, 1));
        order2.AddProduct(new Product("Notebook", "N012", 5.99, 5));
        order2.AddProduct(new Product("Pen Set", "P345", 12.49, 1));

        // List of orders
        List<Order> orders = new List<Order> { order1, order2 };

        // Display order details
        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order.CalculateTotalCost():0.00}");
            Console.WriteLine(new string('-', 40));
        }
    }
}