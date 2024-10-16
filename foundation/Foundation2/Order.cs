public class Order
{
    private Customer _customer;
    private List<Product> _products;

    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal GetTotalPrice()
    {
        decimal totalPrice = 0;
        foreach (Product p in _products)
        {
            totalPrice += p.GetTotalCost();
        }
        totalPrice += GetShippingCost();
        return totalPrice;
    }

    private decimal GetShippingCost()
    {
        decimal shippingCost;
        if (_customer.LivesInUSA())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        return shippingCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product p in _products)
        {
            packingLabel += p.GetDisplayText();
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return _customer.GetDisplayText();
    }

}