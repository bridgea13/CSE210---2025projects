class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private int _zipCode;

    public Address(string streetAddress, string city, string state, int zipCode)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _zipCode = zipCode;
    }
    public void AdressString()
    {
        Console.WriteLine("Address:\n" + _streetAddress + "\n" + _city + "," + _state + "   " + _zipCode);
    }

}