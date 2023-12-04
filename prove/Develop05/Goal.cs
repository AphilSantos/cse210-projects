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

public abstract class Goal
{
    public string goalName;
    public string description;
    public int pointsOfGoal;
    public bool isCompleted;

    public string checkMark = "[ ]";
    public string theList;


    //For the other classes, just add a statement for what you need
    public abstract void ManualLoad();
    public abstract void AutomaticLoad(string automaticAddToList);

    public void FileLoad()
    {
        if (isCompleted){
            checkMark = "[X]";
    }
    }

    public List<string> SaveToList(List<string> addToList){
        addToList.Add(theList);
        return addToList;

    }
    //For the other classes for complete, you just do an overide, and do the logic. Like if it is not done for the checklist, add a value to a completion count.

    public virtual int recordEvent(){
        return pointsOfGoal;
    }
    public abstract string ToShort();
    public abstract string ToLong();
    public abstract string ToFile();

}