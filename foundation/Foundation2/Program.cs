using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation2 World!");
        List<Order> orders = new List<Order>();
        Customer customer1 = new Customer("Pedro Armendariz", new Address("123 Main St", "Las Vegas", "NV", "USA"));
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Biofreeze", "0001", Convert.ToDecimal(10.00), 2));
        order1.AddProduct(new Product("Vitamins", "0002", Convert.ToDecimal(15.00), 1));
        order1.AddProduct(new Product("Hydrogen Peroxide", "0003", Convert.ToDecimal(6.00), 3));
        orders.Add(order1);

        Customer customer2 = new Customer("Roberto Jimenez", new Address("321 Lake Mead St", "North Las Vegas", "NV", "USA"));
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Rubbing Alcohol", "0004", Convert.ToDecimal(7.00), 1));
        order2.AddProduct(new Product("Cotton Swabs", "0005", Convert.ToDecimal(5.00), 2));
        order2.AddProduct(new Product("Band Aids", "0006", Convert.ToDecimal(3.00), 1));
        orders.Add(order2);

        //  packing label, the shipping label, and the total price of the order
        foreach (Order o in orders)
        {
            Console.WriteLine("ORDER PACKING LABEL");
            Console.WriteLine("=====================");
            Console.Write(o.GetPackingLabel());
            Console.WriteLine();
            Console.WriteLine("ORDER SHIPPING LABEL");
            Console.WriteLine("=====================");
            Console.Write(o.GetShippingLabel());
            Console.WriteLine();
            Console.WriteLine("ORDER TOTAL PRICE");
            Console.WriteLine("=====================");
            Console.WriteLine(o.GetTotalPrice().ToString("C"));
            Console.WriteLine("_____________________");
            Console.WriteLine();
        }

    }
}