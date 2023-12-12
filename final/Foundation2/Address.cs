namespace Foundation2

{
public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    
    public Address()
    {
        _streetAddress = null;
        _city = null;
        _stateOrProvince = null;
        _country = null;
    }

    public void setAddress(string address)
    {
        string [] parts = address.Split(',');
        _streetAddress = parts[0];
        _city = parts[1];
        _stateOrProvince = parts [2];
        _country = parts [3];
    }

    public bool AddressInUSA()
    {
        if (_country == "USA" || _country == "United States")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetFullAddress()

    {
        string fullAddress = $"{_streetAddress}, {_city},{_stateOrProvince}, {_country}\n ";
        return fullAddress;
    }

}
}