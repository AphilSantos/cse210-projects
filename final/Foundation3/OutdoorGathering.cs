public class OutdoorGathering: Event


{
    private string _weatherForecastStatement;


    public void SetWeatherForecastStatement (string forecast)

    {
        _weatherForecastStatement = forecast;
    }

    public override void FullDetails()
    {
       
        ListStandardDetails();
        Console.WriteLine($"Weather forecast: {_weatherForecastStatement}");
    }

}