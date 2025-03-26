public class Customer
{
    private string _customerName;
    private string _customerAddress;
    private Address _address;
    public Customer(string customerName, string streetAddress, string city, string state, string country)
    {
        _customerName = customerName;
        _address = new Address(streetAddress, city, state, country);
        _customerAddress = _address.AdressString();
    }
    public string GetShippingLabel(){
        string shipLabel = _customerName + "\n"+ _customerAddress;
        return shipLabel;
    }
    public bool CustomerInUSA()
    {
        return _address.InUSA();
    }
}