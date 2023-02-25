using System;
using System.Collections.Generic;
using System.Threading;

namespace ActivityProgram
{

    // SpinAnimation class
static class SpinAnimation
{
    private static readonly string[] SpinChars = { "/", "-", "\\", "|" };
    private static int spinIndex = 0;

    public static void Pause(int duration)
    {
        for (int i = 0; i < duration / 250; i++)
        {
            Console.Write($"\r{SpinChars[spinIndex]}");
            spinIndex = (spinIndex + 1) % SpinChars.Length;
            Thread.Sleep(250);
        }
        Console.Write("\r");
    }

    public static void Countdown(int duration)
    {
        for (int i = duration; i > 0; i--)
        {
            Console.Write($"\r{i}");
            Thread.Sleep(1000);
        }
        Console.Write("\r");
    }
}
    class Program
    {
        static bool WaitForInput(int seconds)
        {
            for (int i = seconds; i >= 1; i--)
            {
                if (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                    return true;
                }
                Console.Write("{0} ", i);
                Thread.Sleep(1000);
            }
            Console.WriteLine();
            return false;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose an activity:");
                Console.WriteLine("1. Breathing activity");
                Console.WriteLine("2. Reflection activity");
                Console.WriteLine("3. Listing activity");
                Console.WriteLine("4. Exit");

                string input = Console.ReadLine();
                Console.Clear();

                switch (input)
                {
                    case "1":
                        BreathingActivity breathingActivity = new BreathingActivity();
                        breathingActivity.Start();
                        break;
                    case "2":
                        ReflectionActivity reflectionActivity = new ReflectionActivity();
                        reflectionActivity.Start();
                        break;
                    case "3":
                        ListingActivity listingActivity = new ListingActivity();
                        listingActivity.Start();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }

                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }

    abstract class Activity
    {
        protected int duration;

        protected Activity()
        {
            Console.WriteLine("Starting {0} activity", GetType().Name.ToLower());
            Console.WriteLine(GetDescription());
            Console.WriteLine("Please enter the duration of the activity in seconds:");
            duration = int.Parse(Console.ReadLine());
        }

        protected abstract string GetDescription();

        protected void Pause(int seconds)
        {
            for (int i = seconds; i >= 1; i--)
            {
                Console.Write("{0} ", i);
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }

        public virtual void Start()
        {
            Console.WriteLine("Prepare to begin...");
            Pause(3);
        }
    }

    class BreathingActivity : Activity
    {
        protected override string GetDescription()
        {
            return "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        }

        public override void Start()
        {
            base.Start();

            for (int i = 0; i < duration; i += 4)
            {
                Console.WriteLine("Breathe in...");
                Pause(2);

                Console.WriteLine("Breathe out...");
                Pause(2);
            }

            Console.WriteLine("Great job! You completed the {0} activity for {1} seconds.", GetType().Name.ToLower(), duration);
            Pause(3);
        }
    }

    class ReflectionActivity : Activity
{

    static bool WaitForInput(int seconds)
        {
            for (int i = seconds; i >= 1; i--)
            {
                if (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                    return true;
                }
                Console.Write("{0} ", i);
                Thread.Sleep(1000);
            }
            Console.WriteLine();
            return false;
        }
    private readonly List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private readonly List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?"
    };

    protected override string GetDescription()
    {
        return "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public override void Start()
    {
        base.Start();

        Console.WriteLine("Think about the following prompt:");
        string prompt = prompts[new Random().Next(prompts.Count)];
        Console.WriteLine(prompt);
        Console.WriteLine("Take your time to reflect and then answer the following question:");

        int questionIndex = 0;

        while (true)
        {
            string question = questions[questionIndex % questions.Count];
            Console.WriteLine(question);

            SpinAnimation.Pause(2000);
            Console.WriteLine("...");

            if (!WaitForInput(duration - (questionIndex * 2)))
            {
                Console.WriteLine("Reflection Activity ended.");
                return;
            }

            questionIndex++;
        }
    }
}
// ListingActivity class

class ListingActivity : Activity
{
    static bool WaitForInput(int seconds)
        {
            for (int i = seconds; i >= 1; i--)
            {
                if (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                    return true;
                }
                Console.Write("{0} ", i);
                Thread.Sleep(1000);
            }
            Console.WriteLine();
            return false;
        }
    private readonly List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    protected override string GetDescription()
    {
        return "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public override void Start()
    {
        base.Start();

        Console.WriteLine("Think about the following prompt:");
        string prompt = prompts[new Random().Next(prompts.Count)];
        Console.WriteLine(prompt);
        Console.WriteLine("You have 10 seconds to start listing items:");
        SpinAnimation.Countdown(10);

        Console.WriteLine("Begin!");

        int itemCount = 0;

        while (true)
        {
            string item = Console.ReadLine();
            itemCount++;

            if (!WaitForInput(duration - (itemCount * 2)))
            {
                Console.WriteLine("Listing Activity ended.");
                return;
            }
        }
    }
}





}





