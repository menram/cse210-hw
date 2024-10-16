public class Address
{
    private string _street = "";
    private string _city = "";
    private string _state = "";
    private string _country = "";

    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUSA()
    {
        bool isInUSA = false;
        if (_country.ToUpper() == "USA") { isInUSA = true; }
        return isInUSA;
    }

    // A method that displays the Address details 
    public string GetDisplayText()
    {
        string Address = $"{_street}\n";
        Address += $"{_city}, {_state}\n";
        Address += $"{_country}\n";
        return Address;
    }

}