using System.Data;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;

    }
    public string AdressString()
    {
        string label = _streetAddress + "\n"+ _city + ", "+ _state + "\n" + _country;
        return label;
    }
    public bool InUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}