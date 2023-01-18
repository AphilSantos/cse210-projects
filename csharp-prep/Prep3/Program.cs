using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        int num = random.Next(1, 11);

        Console.WriteLine(num);

        Console.WriteLine("Guess the magic number");

        int userInput = -1;

        while (userInput != num)
        {
            Console.Write("Please guess a number between 1 through 10: ");
            userInput = int.Parse(Console.ReadLine());

            if (num > userInput)
            {
                Console.WriteLine("Try again");
                Console.WriteLine("Higher");
            }

            else if (num < userInput)
            {
                Console.WriteLine("Try again");
                Console.WriteLine("Lower");
            }
            
            else if (num == userInput)
            
            {
                Console.WriteLine("You guessed it!");
            }
        }


    }
}