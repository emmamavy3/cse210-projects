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

        
    }

}