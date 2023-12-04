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


    public virtual int recordEvent(){
        return pointsOfGoal;
    }
    public abstract string ToShort();
    public abstract string ToLong();
    public abstract string ToFile();

}