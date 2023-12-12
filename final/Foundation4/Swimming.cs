namespace Foundation4

{
    public class Swimming:Activity

{
    private string _activityVariable = "Swimming";
    

    public void SetActivity()
    {
        SetActivity(_activityVariable);
    }   
    
    public override void CalculateDistance(double distance)
    {
        double dist = distance * 50 /1000;
        base.CalculateDistance(dist);

    }
}
}