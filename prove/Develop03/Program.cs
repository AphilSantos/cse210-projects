using System;
using System.Collections.Generic;


    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> scripture = new Dictionary<string, string>
            {
                { "reference", "John 3:16" },
                { "text", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life." }
            };

            List<string> words = scripture["text"].Split(' ').ToList();
            int totalWords = words.Count;

            Console.Clear();
            Console.WriteLine("{0}: {1}", scripture["reference"], scripture["text"]);
            Console.WriteLine("Press Enter or type quit:");

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "quit")
                {
                    break;
                }

                if (words.Count == 0)
                {
                    Console.WriteLine("You have memorized the scripture!");
                    break;
                }

                Console.Clear();
                int hiddenWords = totalWords - words.Count;
                int toHide = Math.Min(words.Count, 3);
                for (int i = 0; i < toHide; i++)
                {
                    int index = new Random().Next(words.Count);
                    words[index] = "_";
                }

                Console.WriteLine("{0}: ", scripture["reference"]);
                Console.WriteLine("{0} ({1}/{2} words memorized)", string.Join(" ", words), hiddenWords, totalWords);
                Console.WriteLine("Press Enter or type quit:");
            }
        }
    }

