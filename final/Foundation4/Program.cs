using System;

class Program
{
    static void Main(string[] args)
    {
        Running run = new Running("03 Nov 2002 ", 30, 3);
        Cycling cycle = new Cycling("01 Nov 2022", 45, 15);
        Swimming swim = new Swimming("02 Nov 2022", 60, 20);

        List<Activity> activities = new List<Activity> { run, cycle, swim };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}