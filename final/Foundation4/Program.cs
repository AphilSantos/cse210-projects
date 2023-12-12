using System;

namespace Foundation4

{

class Program
{
    static void Main(string[] args)
    {
        List <Activity> list = new List<Activity> ();
        Running run = new Running ();
        run.SetDate("30 Nov 2022");
        run.SetLengthOfActivity(30);
        run.SetActivity();
        run.CalculateDistance(100);
        list.Add(run);

        Swimming swi = new Swimming ();
        swi.SetDate("2 Oct 2022");
        swi.SetActivity();
        swi.CalculateDistance(15);  // in laps
        swi.SetLengthOfActivity(30);
        list.Add(swi);

        StationaryBicycle cyc = new StationaryBicycle ();
        cyc.SetDate("2 Jan 2023");
        cyc.SetActivity();
        cyc.CalculateDistance(200);  // in km
        cyc.SetLengthOfActivity(30);
        list.Add(cyc);

        foreach (Activity a in list)
        {
            string summary = a.GetSummary();
            Console.WriteLine(summary);
        }
        
    }
}
}