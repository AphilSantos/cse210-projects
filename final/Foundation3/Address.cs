public class Address
{

    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public void SetAddress(string address)
    {
        string [] parts = address.Split(',');
        _streetAddress = parts[0];
        _city = parts[1];
        _stateOrProvince = parts [2];
        _country = parts [3];
    }

    public void DisplayAddressParticulars()
    {
        Console.WriteLine($"Event Address: {_streetAddress},{_city},{_stateOrProvince},{_country} ");
    }


}