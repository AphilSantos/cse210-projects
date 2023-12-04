// Goal Tracker Program
// CSE 210
// The Earthworms 
// Contributers: Zach McLaughlin, Tarin James, Austin Jones
// A program that allows the user to create a goal and keep of their progress. 
// The program includes a point system to increase the engagement of the user.
// The user is able to create a simple, eternal, or checklist goal, and each track the goal differently.
// We exceeded expectations by creating a new goal called Long Term Goal, creates a goal with a 
// name, description, and date the user wants it completed by.

using System;
using System.ComponentModel.DataAnnotations;

public class LongTermGoal : Goal
{
    public string goalType = "LongTermGoal";
    public string goalDate;
    public override void ManualLoad()
    {
        Console.Write("What is the name of your goal? ");
        goalName = Console.ReadLine();
        Console.Write("What is a short description of your goal? ");
        description = Console.ReadLine();
        Console.Write("What is the amount of points associated with the goal? ");
        pointsOfGoal = int.Parse(Console.ReadLine());
        Console.Write("When would you like to complete this goal by? MM/DD/YYYY: ");
        goalDate = Console.ReadLine();
        isCompleted = false;

        theList = goalType + goalName + "," + description + "," + pointsOfGoal + "," + isCompleted + "," + goalDate;
    }

    public override void AutomaticLoad(string automaticAddToList)
    {
        List<string> dataList = new List<string>();
        string[] splitValues = { ",", ":" };
        string[] splitData = automaticAddToList.Split(splitValues, StringSplitOptions.RemoveEmptyEntries);
        foreach (var word in splitData)
        {
            dataList.Add(word);
        }
        goalName = splitData[1];
        description = splitData[2];
        pointsOfGoal = int.Parse(splitData[3]);
        isCompleted = bool.Parse(splitData[4]);

        theList = goalType + goalName + "," + description + "," + pointsOfGoal + "," + isCompleted;
    }

    public override string ToShort()
    {
        return goalName;
    }

    public override string ToLong()
    {
        return $"{checkMark} {goalName} ({description}) {goalDate}";
    }

    public override string ToFile()
    {
        return $"{goalType}:{goalName},{description},{pointsOfGoal},{isCompleted},{goalDate}\n";
    }

    public override int recordEvent()
    {
        if (!isCompleted)
        {
            isCompleted = true;
            checkMark = "[X]";
            return pointsOfGoal;
        }
        Console.WriteLine("\nYou've accomplished this goal already");
        return 0;
    }

}