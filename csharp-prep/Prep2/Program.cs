using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade?: ");
        string grade = Console.ReadLine();
        int gradeOfUser = int.Parse(grade);

        if (gradeOfUser >= 90)
        {
            Console.WriteLine("A");
        }

        else if (gradeOfUser >= 80)
        {
            Console.WriteLine("B");
        }

        else if (gradeOfUser >= 70)
        {
            Console.WriteLine("C");
        }

        else if (gradeOfUser >= 60)
        {
            Console.WriteLine("D");
        }

        else if (gradeOfUser <= 60)
        {
            Console.WriteLine("F");
        }

        if (gradeOfUser >= 71)
        {
            Console.Write("Congratulations, you passed! ");
        }

        else 
        {
            Console.Write("You failed. Try again, YOU CAN DO IT!!");
        }

    }
}