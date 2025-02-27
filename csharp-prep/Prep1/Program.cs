using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        // assignment 1
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        Console.Write("What is your first name? ");
        string lastName = Console.ReadLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");

        // assignment 2
        string letter = "";
        string sign = "";

        Console.WriteLine("Enter your grade as a percentage: ");
        int grade = int.Parse(Console.ReadLine());
        if (grade >= 90)
        {
            if (grade >= 97)
            {
                sign = "an";
            }
            else if (grade < 93)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
            letter = "A";
            // Console.WriteLine("You got an A!!!");
        }
        else if (grade >= 80)
        {
            if (grade >= 87)
            {
                sign = "+";
            }
            else if (grade < 83)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
            letter = "B";
            //Console.WriteLine("You got a B!!!");
        }
        else if (grade >= 70)
        {            
            if (grade >= 77)
            {
                sign = "+";
            }
            else if (grade < 73)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
            letter = "C";
            //Console.WriteLine("You got a C!!");
        }
        else if (grade >= 60)
        {            
            if (grade >= 67)
            {
                sign = "+";
            }
            else if (grade < 63)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
            letter = "D";
            //Console.WriteLine("You got a D!");
        }
        else if (grade < 60)
        {
            sign = "";
            letter = "F";
            //Console.WriteLine("You got a F!");
        }

        Console.WriteLine($"Your grade: {sign}{letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congrats you passed");
        }
        else
        {
            Console.WriteLine("You failed. Be Better!");
        }
        
    // assignment 3
        string play = "";

        do
        {
            int guess = 0;
            int x = 0;

            Random randomNum = new Random();
            int magicNum = randomNum.Next(1, 100);

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