using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order("Bob Smith", "13 Cherry Street", "Fargo", "NB", "USA");
        Order order2 = new Order("Jane Doe", "12 Peach Street", "Boise", "NM", "USA");
        Order order3 = new Order("John Jones", "15 Apple Street", "Quebec", "Montreal", "Canada");
         //public void AddProducts(string productName, int productID, int pricePerUnit, int quantitiy)
         order1.AddProducts("Vans Shoes", 2001, 70, 1 );
         order1.AddProducts("Compact Umbrella", 3033, 10, 2 );
         order1.AddProducts("Sunscreen", 2100, 15, 1 );

         Console.WriteLine("Order 1\nShipping Label:");
         Console.WriteLine(order1.ShippingLabel());
         Console.WriteLine("Packing Label:");
         Console.WriteLine(order1.PackingLabel());
         Console.WriteLine("Order 1 - Total Cost:");
         Console.WriteLine(order1.TotalCost());

         order2.AddProducts("Wellies", 8002, 80, 1);
         order2.AddProducts("Jacket", 9440, 65, 1);
         order2.AddProducts("Sleeping bag", 3100, 120, 2);

         Console.WriteLine("\nOrder 2\nShipping Label:");
         Console.WriteLine(order2.ShippingLabel());
         Console.WriteLine("Packing Label:");
         Console.WriteLine(order2.PackingLabel());
         Console.WriteLine("Order 2 - Total Cost:");
         Console.WriteLine(order2.TotalCost());

         order3.AddProducts("Swimsuit", 6022, 100, 2);
         order3.AddProducts("Beach hat", 2440, 20, 1);
         order3.AddProducts("Flip flops", 1170, 30, 1);

         Console.WriteLine("\nOrder 3\nShipping Label:");
         Console.WriteLine(order3.ShippingLabel());
         Console.WriteLine("Packing Label:");
         Console.WriteLine(order3.PackingLabel());
         Console.WriteLine("Order 3 - Total Cost:");
         Console.WriteLine(order3.TotalCost());
    }
}