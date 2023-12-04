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

public  class ChecklistGoal : Goal
{
    public string goalType = "ChecklistGoal";
    public int completionAmount;
    public int timesDone;
    public int bonusPoints;
    public override void ManualLoad()
    {
        Console.Write("What is the name of your goal? ");
        goalName = Console.ReadLine();
        Console.Write("What is a short description of your goal? ");
        description = Console.ReadLine();
        Console.Write("What is the amount of points associated with the goal? ");
        pointsOfGoal = int.Parse(Console.ReadLine());
        Console.Write("How many bonus points do you get for finishing the goal? ");
        bonusPoints = int.Parse(Console.ReadLine());
        Console.Write("How many times do you want to do this goal? ");
        timesDone = int.Parse(Console.ReadLine());
        
        isCompleted = false;

        theList =  goalType + goalName + "," + description + "," + pointsOfGoal + "," + isCompleted;
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
        bonusPoints = int.Parse(splitData[4]);
        completionAmount = int.Parse(splitData[5]);
        timesDone = int.Parse(splitData[6]);

        theList = goalType + goalName + "," + description + "," + pointsOfGoal + "," + bonusPoints + "," + completionAmount + "," + timesDone;
    }
    
    public override string ToShort()
    {
        return goalName;
    }

    public override string ToLong()
    {
        return  $"{checkMark} {goalName} ({description}): {completionAmount}/{timesDone}";
    }

    public override string ToFile()
    {
        return $"{goalType}:{goalName},{description},{pointsOfGoal},{bonusPoints},{completionAmount},{timesDone}\n";
    }

    public override int recordEvent(){
        if (!isCompleted)
        {
            if (timesDone != completionAmount)
            {
                completionAmount++;
            }
            else{
            isCompleted = true;
            checkMark = "[X]";
            }
            return pointsOfGoal;
        }
        Console.WriteLine("\nYou've accomplished this goal already");
        return 0;
    
    }


}