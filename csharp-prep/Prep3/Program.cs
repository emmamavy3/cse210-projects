using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        // assignment 3
        string play = "";

        do
        {
            Random randomNum = new Random();
            int magicNum = randomNum.Next(1, 100);

            int guess = 0;
            int x = 0;

            do
            {
                Console.Write("What is your guess: ");
                guess = int.Parse(Console.ReadLine());
                int counter = x++;
                if (magicNum > guess)
                {
                    Console.WriteLine("Higher");
                } 
                else if (magicNum < guess)
                {
                    Console.WriteLine("Lower");
                }
                else if (magicNum == guess)
                {
                    Console.WriteLine("Correct");
                }
            } while (guess != magicNum);
            Console.WriteLine($"You made {x} guesses.");
            Console.WriteLine("Would you like to play again? ");
            play = Console.ReadLine();
        } while (play != "no");
    }
}