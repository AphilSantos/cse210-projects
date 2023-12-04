using System;
using System.Security.Cryptography.X509Certificates;

class SaveLoad
{
    public int loadedPoints;
    public List<Goal> Load()
    {
        try
        {
            int counter = 0;
            // string points = "";
            Console.WriteLine("What is the file name? ");
            string userFileName = Console.ReadLine();
            userFileName = userFileName + ".txt";    

            string[] lines = System.IO.File.ReadAllLines(userFileName);
            List<Goal> loadedGoals = new List<Goal> { };
                foreach (string goal in lines)
            {
                if (counter == 0)
                {
                    //goal is score on the first run of the loop
                    loadedPoints = int.Parse(goal);
                }
                else
                {
                // Ex goal
                // SimpleGoal:Give a talk,Speak in Sacrament meeting when asked,100,True
                    if (goal.Length > 0)
                    {
                    // Split by :
                        string[] goalTypeAndData = goal.Split(":");
                        string goalType = goalTypeAndData[0];
                        string goalData = goalTypeAndData[1];
                    // ["SimpleGoal", "Give a talk,Speak in Sacrament meeting when asked,100,True"]
                        string[] goalAttributes = goalData.Split(",");
                    // Ex ewgoalAttributes
                    // ["Give a talk", "Speak in Sacrament meeting when asked" , "100" , "True"]

                        if (goalType == "SimpleGoal")
                        {
                            SimpleGoal newGoal = new SimpleGoal();
                            newGoal.goalName = goalAttributes[0];
                            newGoal.description = goalAttributes[1];
                            newGoal.pointsOfGoal = int.Parse(goalAttributes[2]);
                            newGoal.isCompleted = Convert.ToBoolean(goalAttributes[3]);
                            loadedGoals.Add(newGoal);
                        }
                        else if (goalType == "EternalGoal")
                        {
                            EternalGoal newGoal = new EternalGoal();
                            newGoal.goalName = goalAttributes[0];
                            newGoal.description = goalAttributes[1];
                            newGoal.pointsOfGoal = int.Parse(goalAttributes[2]);
                            loadedGoals.Add(newGoal);
                        }
                        else if (goalType == "ChecklistGoal")
                        {
                            ChecklistGoal newGoal = new ChecklistGoal();
                            newGoal.goalName = goalAttributes[0];
                            newGoal.description = goalAttributes[1];
                            newGoal.pointsOfGoal = int.Parse(goalAttributes[2]);
                            newGoal.bonusPoints = int.Parse(goalAttributes[3]);
                            newGoal.completionAmount = int.Parse(goalAttributes[4]);
                            newGoal.timesDone = int.Parse(goalAttributes[5]);
                            loadedGoals.Add(newGoal);
                        }
                        else if (goalType == "LongTermGoal") {
                        
                            LongTermGoal newGoal = new LongTermGoal();
                            newGoal.goalName = goalAttributes[0];
                            newGoal.description = goalAttributes[1];
                            newGoal.pointsOfGoal = int.Parse(goalAttributes[2]);
                            newGoal.isCompleted = Convert.ToBoolean(goalAttributes[3]);
                            newGoal.goalDate = goalAttributes[4];
                            loadedGoals.Add(newGoal);
                        }
                    }

                }
                counter += 1;
            }
            Console.WriteLine("\nGoals loaded successfully!");
            
            return loadedGoals;
        }
        catch (System.Exception)
        {
            
            Console.WriteLine("\nSomething went wrong, please try again.");
            return new List<Goal> { };
        }
    }


    public void Save(List<Goal> goalsToSave, string points)
    {

        try
        {
            Console.WriteLine("\nWhat is the file name? ");
            string userFileName = Console.ReadLine();
            userFileName = userFileName + ".txt";
            string goalsToSaveString = "";
            goalsToSaveString += $"{points}\n";
            foreach (Goal savedGoal in goalsToSave)
            {
                goalsToSaveString += savedGoal.ToFile();

            }
            using (StreamWriter outputFile = new StreamWriter(userFileName))


                outputFile.WriteLine(goalsToSaveString);
            Console.WriteLine("\nGoals saved successfully!");
        }
        catch (System.Exception)
        {

            Console.WriteLine("\nSomething went wrong, please try again.");
        }
    }
}