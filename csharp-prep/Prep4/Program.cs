using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("LISTS");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int>numbers = new List<int>();

        int userNumbers = -1;

        while (userNumbers != 0)
        {
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();
            userNumbers = int.Parse(userInput);

            if (userNumbers != 0)
            {
                numbers.Add(userNumbers);
            }
        }

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The total of numbers added together is {sum}");

        float ave = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {ave}");

        int max = numbers[0];

        foreach (int num in numbers)

        {
            if (num > max)
            {
                max = num;
            }
        }

        Console.WriteLine($"The largest number is {max}");
    }
}