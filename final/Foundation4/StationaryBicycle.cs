namespace Foundation4
{
    public class StationaryBicycle: Activity

{

    
    private string _activityVariable = "StationaryBicycle";
    

    public void SetActivity()
    {
        SetActivity(_activityVariable);
    }   

    public override void CalculateDistance(double distance)
    {
        base.CalculateDistance(distance);

    }
}
}