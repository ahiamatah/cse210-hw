using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        // Exceeding Requirements: Scripture loaded from a small library (randomly selected)

        // Sample scripture library
        Scripture[] scriptures = new Scripture[]
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(new Reference("2 Nephi", 2, 25), "Adam fell that men might be; and men are, that they might have joy.")
        };

        Random rnd = new Random();
        Scripture scripture = scriptures[rnd.Next(scriptures.Length)];

        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            scripture.Display();

            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3); // Hide 3 random words per step
        }

        Console.Clear();
        scripture.Display();
        Console.WriteLine("\nAll words are hidden. Program ended.");
    }
}