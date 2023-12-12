using System;

class Program
{
    static void Main(string[] args)
    {
        
        Lecture event1 = new Lecture();
        event1.SetEvent("Lecture", "Advancements in Robotics - Q1 2024","US inflation falls sharply. How shall we interpret this?","4 April, 2024","2:30-4:00pm", "Pennisula Hotel, 2/F, Kingston Road, Germany");
        event1.SetSpeaker("Dr. Emily Zhao");
        event1.SetCapacity(200);

        Reception event2 = new Reception();
        event2.SetEvent("Reception","Wedding:Carol and Jimmy Carter", "It is getting competitive","2 August, 2024", "2:00-4:00pm", "4 Cornwell Street, Kowloon Tong, Kowloon, Hong Kong");
        event2.SetEmail("Excited to see you. Please respond by 24 July for confirmation. RVSP");

        OutdoorGathering event3 = new OutdoorGathering();
        event3.SetEvent("Outdoor Gathering", "Peak Assembly", "Review the cultural heritage", "3 October, 2024", "10:00-12:00pm", "4 Peak Road, The Peak, Central, Hong Kong");
        event3.SetWeatherForecastStatement("A spike in heat could produce some of the highest temperatures of the summer so far in the Northeast toward the end of next week, AccuWeather forecasters say.");

        // events are created by chatGPT

        List <Event> elist = new List <Event> ();
        elist.Add(event1);
        elist.Add(event2);
        elist.Add(event3);
        
        foreach (Event vent in elist)
        {
            Console.WriteLine("\nShort Message:");
            vent.ShortDescription();
            Console.WriteLine("\nStardard Message:");
            vent.ListStandardDetails();
            Console.WriteLine("\nFull Message:");
            vent.FullDetails();
            Console.WriteLine();
    
        }
        
    }
}