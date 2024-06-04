using System;
using System.Reflection.Emit;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public void totalPrice()
    {
        double total = 0;
        string strtotal = "";
        foreach (Product product in _products)
        {
            total = product.TotalPrice() + total;
        }
        if (_customer.usResidency() == true)
        {
            Console.WriteLine("Shipping cost: 5");
            total = total + 5;
            strtotal = total.ToString("0.00");
        }
        else if (_customer.usResidency() == false)
        {
            Console.WriteLine("Shipping cost: 35");
            total = total + 35;
            strtotal = total.ToString("0.00");
        }

        Console.WriteLine($"Total: {strtotal}");
    }

    public void PackingLable()
    {
        Console.WriteLine("Packing Lable: ");
        Console.WriteLine("");
        foreach (Product product in _products)
        {
            Console.WriteLine($"Product: {product.GetName()}, ID: {product.GetId()}");
        }
        Console.WriteLine("");
    }

    public void shippingLable()
    {
        Console.WriteLine("Shipping Lable: ");
        Console.WriteLine($"{_customer.getName()}");
        Console.WriteLine($"{_customer._address.GetCompleteAdress()}");
        Console.WriteLine();
    }
}