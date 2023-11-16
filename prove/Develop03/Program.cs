
    using System;
    using System.Collections.Generic;


using ScriptureApp; 

class Program
{
    static void Main()
    {
        
        Scripture scripture = new Scripture("John", 3, 16, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        ClearConsoleSafely();
        Console.WriteLine(scripture);

        while (true)
        {
            Console.WriteLine("Press enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            ClearConsoleSafely();
            scripture.HideRandomWord();
            Console.WriteLine(scripture);

            if (scripture.IsFullyHidden())
            {
                Console.WriteLine("All words are hidden!");
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
