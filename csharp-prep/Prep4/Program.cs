using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello Prep4 World!");
        int num= 0;
        var numbers = new List<int>();
        int avg = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console. Write("Enter number: ");
            num = int.Parse(Console.ReadLine());
            numbers.Add(num);
        } while (num != 0);
        
        int sum = numbers.Sum();
        Console.WriteLine($"The Sum is: {sum}");
        foreach (int number in numbers)
        {
            avg = sum / numbers.Count();
        }
        Console.WriteLine($"The average is: {avg}");
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");
    }
}