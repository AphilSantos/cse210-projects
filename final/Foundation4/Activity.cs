namespace Foundation4

{
    public abstract class Activity

    {
    private string _date = "03 Nov 2022";
    private string _activity;
    private double _distance;
    private double _speed;
    private double _pace;
    
    private int _lengthOfActivity = 30;     // minutes

    public void SetActivity(string activity)
    {
        _activity = activity;
    }

    public void SetDate(string date)
    {
        _date = date;
    }

    public void SetLengthOfActivity(int length)
    {
        _lengthOfActivity = length;
    }

    public virtual void CalculateDistance(double distance)
    {
        _distance = distance;
    }

    public void CalculateSpeed()
    {
        _speed = (_distance / _lengthOfActivity) * 60;
    }

    public void CalculatePace()
    {
        _pace = 60 / _speed;
    }
    
    
    public string GetSummary()
    {
        CalculateSpeed();
        CalculatePace();
        return $"{_date} {_activity} (30 min) - Distance {_distance} km, Speed {_speed} kph, Pace: {_pace} min per km";
    }

}
}