public class Reception :Event

{
    private string _emailForRSVP;

    public void SetEmail(string email)
    {
        _emailForRSVP = email;
    }




    public override void FullDetails()

    {
        
        ListStandardDetails();
        Console.WriteLine($"Email Message: {_emailForRSVP}");

    }

}