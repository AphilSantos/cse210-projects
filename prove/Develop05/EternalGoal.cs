using System;
using System.ComponentModel.DataAnnotations;

public  class EternalGoal : Goal
{
    public string goalType = "EternalGoal"; 
    public override void ManualLoad()
    {
        Console.Write("What is the name of your goal? ");
        goalName = Console.ReadLine();
        Console.Write("What is a short description of your goal? ");
        description = Console.ReadLine();
        Console.Write("What is the amount of points associated with the goal? ");
        pointsOfGoal = int.Parse(Console.ReadLine());
        isCompleted = false;

        theList =  goalType + goalName + "," + description + "," + pointsOfGoal;
    }
    public override void AutomaticLoad(string automaticAddToList)
    {   
        List<string> dataList = new List<string>(); 
        string[] splitValues = {"," , ":"};
        string[] splitData = automaticAddToList.Split(splitValues, StringSplitOptions.RemoveEmptyEntries);
        foreach (var word in splitData){
            dataList.Add(word);
        }
        goalName = splitData[1];
        description = splitData[2];
        pointsOfGoal = int.Parse(splitData[3]);

        theList = goalType + goalName + "," + description + "," + pointsOfGoal;
    }
    
    public override string ToShort()
    {
        return goalName;
    }

    public override string ToLong()
    {
        return  $"{checkMark} {goalName} ({description})";
    }

    public override string ToFile()
    {
        return $"{goalType}:{goalName},{description},{pointsOfGoal}\n";
    }


}