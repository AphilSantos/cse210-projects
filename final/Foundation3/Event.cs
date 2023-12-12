
public abstract class Event

{
    private string _eventType;
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;


    public void SetEvent(string eventType, string eventTitle, string description, string date, string time, string address)
    {
        _eventType = eventType;
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = new Address ();
        _address.SetAddress(address);

    }

    public void ListStandardDetails()
    {
        
        Console.WriteLine($"Event Title: {_eventTitle}\nEvent Description: {_description}\nEvent Date: {_date}\nTime: {_time}");
        _address.DisplayAddressParticulars();
    }

    public void ShortDescription()
    {
        // Console.WriteLine("\nShort Message:");
        Console.WriteLine ($"Event Type: {_eventType}\nEvent Title: {_eventTitle}\nEvent Date: {_date}");
    }

    public abstract void FullDetails();
    



}