public class Customer
{
    private string _name = "";
    private Address _address;

    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LivesInUSA()
    {
        bool livesInUSA = false;
        livesInUSA = _address.IsInUSA();
        return livesInUSA;
    }

    // A method that displays the Customer details 
    public string GetDisplayText()
    {
        string Customer = $"{_name}\n";
        Customer += _address.GetDisplayText();
        return Customer;
    }

}