public class Product
{
    private string _name = "";
    private string _productId = "";
    private decimal _price;
    private int _quantity;

    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public Product(string name, string productId, decimal price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public decimal GetTotalCost()
    {
        decimal totalCost;
        totalCost = _price * _quantity;
        return totalCost;
    }

    // A method that displays the Product details 
    public string GetDisplayText()
    {
        string Product = $"{_productId} - {_name}\n";
        return Product;
    }

}