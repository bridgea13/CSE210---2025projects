using System.Diagnostics.Contracts;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.Marshalling;

public class Order
{
    private List<Product> _products;
    private Customer _customer;
    public Order(string customerName, string streetAddress, string city, string state, string country)
    {
        _products = new List<Product>();
        _customer = new Customer(customerName, streetAddress, city, state, country);
    }
    public void AddProducts(string productName, int productID, int pricePerUnit, int quantitiy)
    {
        Product item = new Product(productName, productID, pricePerUnit, quantitiy);
        _products.Add(item);
    }
    public int TotalCost()
    {
        int tc = 0;
        if (_customer.CustomerInUSA())
        {
            tc += 5;
        }
        else
        {
            tc += 35;
        }
        for (int i = 0; i < _products.Count; i++)
        {
            tc += _products[i].TotalCost();
        }
        return tc;

    }

    public string PackingLabel()
    {
        string packLabel = "";
        for (int i = 0; i < _products.Count; i++)
        {
            packLabel += _products[i].PackingLabel();
        }
        return packLabel;

    }
    public string ShippingLabel()
    {
        return _customer.GetShippingLabel();
    }
}