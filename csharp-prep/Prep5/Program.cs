using System;

class Program
{
    // static void Main(string[] args)
    // {
    //     Console.WriteLine("Hello Prep5 World!");
    // }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string Name = Console.ReadLine();
        return Name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int Number = int.Parse (Console.ReadLine());
        return Number;
    }
    static int SquareNumber(int Number)
    {
        int square = Number* Number;
        return square;
    }

    static void DisplayResults(int square, string Name)
    {
        Console.WriteLine($"{Name}, the square of your number is {square}");
    }

    static void Main(string[] args)
    {
        string UserName = PromptUserName();
        int UserNumber = PromptUserNumber();
        int SquaredNumber = SquareNumber(UserNumber);

        DisplayResults(SquaredNumber, UserName);
    }
    
}