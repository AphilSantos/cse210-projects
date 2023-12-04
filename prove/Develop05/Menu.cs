using System.Text.RegularExpressions;

public class Menu
{
    
    List<Goal> goalList = new List<Goal> { };
    bool Done = false;
    int UserChoice;
    SaveLoad saveLoader = new SaveLoad();
    int totalPoints = 0;

    private void DisplayMenu()
    {
        Console.WriteLine($"\nYou have {totalPoints} points\n");

        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");
        Console.Write("Select a choice from the menu: ");
    }

    public void runMenu()
    {
        while (!Done)
        {
            DisplayMenu();
            UserChoice = Convert.ToInt32(Console.ReadLine());
            switch (UserChoice)
            {
                // 1. Create New Goal
                case 1:
                    ClearConsoleSafely();
                    Console.WriteLine("Choose goal type:");
                    Console.WriteLine("  1. Simple Goal");
                    Console.WriteLine("  2. Eternal Goal");
                    Console.WriteLine("  3. Checklist Goal");
                    Console.WriteLine("  4. Long Term Goal");
                    Console.Write("Which type of goal would you like to create? ");
                    int goalTypeChoice = Convert.ToInt32(Console.ReadLine());
                    Goal newGoal;

                    switch (goalTypeChoice)
                    {
                        case 1:
                            newGoal = new SimpleGoal();
                            newGoal.ManualLoad();
                            break;
                        case 2:
                            newGoal = new EternalGoal();
                            newGoal.ManualLoad();
                            break;
                        case 3:
                            newGoal = new ChecklistGoal();
                            newGoal.ManualLoad();
                            break;
                        
                        case 4:
                            newGoal = new LongTermGoal();
                            newGoal.ManualLoad();

                            break;

                        default:
                            Console.WriteLine("\nInvalid goal type choice.");
                            continue;
                    }

                    goalList.Add(newGoal);
                    break;

                // 2. List Goals
                case 2:
                    ClearConsoleSafely();
                    Console.WriteLine("List of Goals:");
                    foreach (var goal in goalList)
                    {
                        Console.WriteLine(goal.ToLong());
                    }
                    Console.WriteLine("\nPress enter to continue: ");
                    Console.ReadLine();
                    ClearConsoleSafely();
                    break;


                case 3:
                    saveLoader.Save(goalList, totalPoints.ToString());
                    break;

                // 4. Load Goals
                case 4:
                    goalList = saveLoader.Load();
                    totalPoints = saveLoader.loadedPoints;
                    break;
                // 5. Record Event
                case 5:
                    Console.WriteLine("\nThe goals are: ");

                    for (int i = 0; i < goalList.Count; i++)
                    {
                        Goal goal = goalList[i];
                        Console.WriteLine($"{i + 1}. {goal.ToShort()}");
                    }

                    Console.Write("\nWhich goal did you accomplish? ");
                    int accomplishedGoal = int.Parse(Console.ReadLine()) - 1;

                    if (goalList.Count >= accomplishedGoal)
                    {
                        Goal goalToModify = goalList[accomplishedGoal];
                        int pointsToAdd = goalToModify.recordEvent();
                        totalPoints += pointsToAdd;
                        if (pointsToAdd > 0)
                        {
                            Console.WriteLine($"\nCongratulations! You have earned {pointsToAdd} points.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid value");
                    }
                    break;
                // 6. Quit
                case 6:
                    Done = true;
                    break;

                default:
                    ClearConsoleSafely();
                    Console.WriteLine("\nInvalid input, please try again.");
                    Console.Write("\nPress enter to continue: ");
                    Console.ReadLine();
                    ClearConsoleSafely();
                    break;
            }
        }

        
    }

    private static void ClearConsoleSafely()
    {
        try
        {
            if (Environment.UserInteractive && !Console.IsOutputRedirected)
            {
                Console.Clear();
            }
        }
        catch (IOException)
        {
            Console.WriteLine("Error occurred while clearing the console.");
        }
    }
}