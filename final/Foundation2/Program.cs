using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        //Creates products for the orders
        Product Rice = new Product("Rice(1kg)", 152, 1, 5);
        Product StrawBerry = new Product("Fresh Strawberrys", 552, 0.98, 12);
        Product Pasta = new Product("Pasta", 54, 5, 2);
        Product Meat = new Product("Meat(1kg)", 27, 25, 1);
        Product Corn = new Product("Corn(1kg)", 84, 2.2, 1);
        
        //Creates the list of products
        List<Product> products1 = new List<Product>();
        List<Product> products2 = new List<Product>();

        //Creates the address and customer
        Address address1 = new Address("Main Street 2", "Orlando", "Florida", "EE. UU.");
        Customer customer1 = new Customer("Carla", address1);
        
        Address address2 = new Address("Calle de San Jose 21", "Playa Muro", "Mallorca", "Spain");
        Customer customer2= new Customer("Steven", address2);

        //Populates the list of products
        products1.Add(Rice);
        products1.Add(StrawBerry);
        products1.Add(Pasta);

        products2.Add(Corn);
        products2.Add(Meat);
        products2.Add(Pasta);
        products2.Add(Rice);

        Order order1 = new Order(products1, customer1);
        Order order2 = new Order(products2, customer2);

        Console.WriteLine("------------------------------------------------------");
        
        order1.shippingLable();
        order1.PackingLable();
        order1.totalPrice();
        Console.WriteLine();

        Console.WriteLine("------------------------------------------------------");

        order2.shippingLable();
        order2.PackingLable();
        order2.totalPrice();
        
        Console.WriteLine("------------------------------------------------------");
    }
}