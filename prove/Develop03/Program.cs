
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        Console.Clear();
        scripture.Display();

        while (true)
        {
            Console.WriteLine("Press enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            Console.Clear();
            scripture.HideRandomWord();
            scripture.Display();

            if (scripture.IsFullyHidden())
            {
                break;
            }
        }
    }
}

class Scripture
{
    private string reference;
    private List<string> words;
    private List<bool> hidden;

    public Scripture(string reference, string text)
    {
        this.reference = reference;
        this.words = new List<string>(text.Split(' '));
        this.hidden = new List<bool>(new bool[this.words.Count]);
    }

    public void Display()
    {
        Console.WriteLine($"{reference}:");
        for (int i = 0; i < words.Count; i++)
        {
            if (hidden[i])
            {
                Console.Write("___");
            }
            else
            {
                Console.Write(words[i]);
            }

            Console.Write(" ");
        }
        Console.WriteLine();
    }

    public void HideRandomWord()
    {
        Random random = new Random();
        int index = random.Next(words.Count);
        hidden[index] = true;
    }

    public bool IsFullyHidden()
    {
        return hidden.TrueForAll(x => x);
    }
}
