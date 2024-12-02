using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Kampala", "Central", "Uganda");
        Address address2 = new Address("456 Mount St", "Kisoro", "Southern", "Uganda");

        Customer customer1 = new Customer("Emily Emerson", address1);
        Customer customer2 = new Customer("Fremer Mimie", address2);

        Product product1 = new Product("Widget", "W123", 10.99m, 2);
        Product product2 = new Product("Gadget", "G456", 15.49m, 1);
        Product product3 = new Product("Clothes", "T789", 7.99m, 3);  

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order (customer2);
        order2.AddProduct(product3);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order1.CalculateToatalCost():C}");

        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order2.CalculateToatalCost():C}");
        
    }
}