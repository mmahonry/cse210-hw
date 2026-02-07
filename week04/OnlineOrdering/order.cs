using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetSubtotal()
    {
        double sum = 0;
        foreach (Product p in _products)
        {
            sum += p.GetTotalCost();
        }
        return sum;
    }

    public double GetShippingCost()
    {
        return _customer.LivesInUSA() ? 5 : 35;
    }

    public double GetTotalPrice()
    {
        return GetSubtotal() + GetShippingCost();
    }

    public string GetPackingLabel()
    {
        string result = "PACKING LABEL:\n";

        foreach (Product p in _products)
        {
            result += $"- {p.GetPackingLine()}\n";
        }

        return result;
    }

    public string GetShippingLabel()
    {
        string result = "SHIPPING LABEL:\n";
        result += _customer.GetName() + "\n";
        result += _customer.GetAddress().GetFullAddress();
        return result;
    }
}