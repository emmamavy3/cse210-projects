using System;


class Program
{
    
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        // Job 1

        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2018;
        job1._endYear = 2022;
        
        // Job 2

        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;


        Resume myResume = new Resume();
        myResume._name = "Allison Rose";
        
        myResume.DisplayResume();
        job1.DisplayJobDetails();
        job2.DisplayJobDetails();
     }

}