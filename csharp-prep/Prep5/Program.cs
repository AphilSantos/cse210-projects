using System;

class Program
{
    static void Main(string[] args)
    {
        WelcomeMessage();

        string DisplayName = PromptUserName();

        int DisplayNumber = PromptUserNumber();

        int DisplaySquared = PromptUserNumberToSquare(DisplayNumber);

        Combine(DisplayName, DisplaySquared);
    }

    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your number? ");
        int userNumber = int.Parse(Console.ReadLine());

        return userNumber;
    }

    static int PromptUserNumberToSquare(int userNumber)
    {
        int square = userNumber * userNumber;

        return square;
    }

    static void Combine(string name, int square)
    {
        Console.WriteLine($"Your name is {name} and your squared number is {square}.");
    }
}