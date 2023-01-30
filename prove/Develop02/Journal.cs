using System;
using System.IO; 

// The name of this class is Journal
public class Journal
{
    // Variable for the class
    public string _fileName;

    // Make a compund list to hold the date, prompt, and response for EACH entry
    // This will also display the entries and to save/load the file
    // Also make the list public so that is it accessible and won't have a protection level
    public List<Entry> _entries = new List<Entry>();

    // Method to display the journal
    // Call Display.Entry(); from the Entry.cs file
    public void DisplayJournal()
    {   
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
            
        }
    }

    // Method to save the file as csv
    public void SaveFile()
    {
        Console.WriteLine("What would you like to name this file? ");
        _fileName = Console.ReadLine();
        _fileName = Console.ReadLine() + ".csv";
        using (StreamWriter outputFile = new StreamWriter(_fileName))
            {
                outputFile.WriteLine("Date,Prompt Question,User Response");
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry._date},{entry._promptQuestion},{entry._userResponse}");
                }
            }
    }

    // Method to load the file
    public void LoadFile()
    {
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        foreach (string line in lines)
        {
            Entry theEntry = new Entry();
            string[] parts = line.Split("-");

            theEntry._date = parts[0];
            theEntry._promptQuestion = parts[1];
            theEntry._userResponse = parts[2];

            _entries.Add(theEntry);
        }
        DisplayJournal();
    }

}