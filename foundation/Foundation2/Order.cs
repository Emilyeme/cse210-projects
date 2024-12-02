using System.Collections.Generic;

public class Order
{
    private List<Product> products;
    private Customer customer;
    private const decimal UgandaShippingCost = 7.00m;
    private const decimal InternationalShippingCost = 75.00m;

    public Order(Customer customer)
    {
        products = new List<Product>();
        this.customer =customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public decimal CalculateToatalCost()
    {
        decimal total = 0;
        foreach (var product in products)
        {
            total += product.TotalCost();
        }
        total += customer.LivesInUganda() ? UgandaShippingCost : InternationalShippingCost;
        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach(var product in products)
        {
          label +=($"Packing Label:{product.GetName()} (ID: {product.GetProductId()})\n ");
          
        }
         return label;  
    }

    public string GetShippingLabel()
    {
        return ($"Shipping Label:\n{customer.GetName()}\n {customer.GetAddress().GetFullAddress()}");
    }
}