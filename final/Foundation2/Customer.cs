namespace Foundation2
{
public class Customer

{
    private string _name;
    private Address _address;

    
    

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetAddress(string address)
    {
        _address = new Address();
        _address.setAddress(address);

    }

    public bool CheckInUSA()
    {
        return _address.AddressInUSA();
    }

    public void SetCustomer(Customer customer)
    {
        _name = customer._name;
        _address = customer._address;
    }

    public string GetName()
    {
        return _name;
    }
    public string GetAddress()
    {
        
        string fullAddress = _address.GetFullAddress();
        return fullAddress;
    }
}
}