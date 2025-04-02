using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorization Program!");

        Reference reference = new Reference("Nephi", 3, 7);
        Scripture scripture = new Scripture(reference, "I will go and do the things which the Lord hath commanded.");

        scripture.ShowScripture();
        while (!scripture.AllWordsHidden())
        {
            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit") break;

            Console.Clear();
            scripture.HideSomeWords();
            scripture.ShowScripture();
        }
        Console.WriteLine("Congratulations! You've memorized the scripture.");

    }
}