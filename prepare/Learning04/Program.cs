using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment myAssignment = new Assignment("Trey Fisher", "Multiplication");
        Console.WriteLine(myAssignment.GetSummary());

        MathAssignment myMathAssignment = new MathAssignment("7.3", "8-9", "Roberto Rodriguez", "Fractions");
        Console.WriteLine($"{myMathAssignment.GetSummary()} \n{myMathAssignment.GetHomeworkList()}");

        WritingAssignment myWritingAssignment = new WritingAssignment("The Causes  of WWII", "Mary Waters", "European History");
        Console.WriteLine($"{myWritingAssignment.GetSummary()} \n{myWritingAssignment.GetWritingInformation()}");
    }
}