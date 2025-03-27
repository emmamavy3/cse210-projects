using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = [1,2,3,4,5,6,7,8,9,10];

        List<int> evenNumbers = numbers.Where((x) => x % 2 == 0).ToList();
        foreach(int x in evenNumbers)
        {
            Console.WriteLine(x);
        }

        Console.WriteLine("Hello Sandbox World!");

        // Console.WriteLine("Hello CSE 210");
        // Console.WriteLine("Please enter your name");
        // string name = Console.ReadLine();
        // Console.WriteLine($"{name}");

        //double x = 10;
        // Circle myCircle = new Circle(10);
        // myCircle.DisplayCircleArea();

        // Cylinder myCylinder = new Cylinder(10, myCircle);
        // double volume = myCylinder.GetVolume();
        // Console.WriteLine($"My Cylinder's volume is: {volume}");

        // Circle myCircle2 = new Circle(20);
        // myCircle2.DisplayCircleArea();

        // for(int i = 0; i < 30; i++)
        // {
        //     myCircle.SetRadius(i);
        //     double circleArea = myCircle.GetArea();
        //     Console.WriteLine($"{i}: Circle area is: {circleArea}");
        //     //myCircle.DisplayCircleArea;
        // }
        RunSpinner();
        BacktoTheFuture();
        
    }

    static void RunSpinner()
    {
        int counter = 0;
        //string spinnerString = "+-";

        string[] spinnerStrings = {":)", ":("};

        while(counter < 10)
        {
            Console.Write($"{spinnerStrings[counter%2]}");
            Console.Write("\b\b");
            Thread.Sleep(200);
            // Console.Write("-");
            // Console.Write("\b");
            //Thread.Sleep(200);
            counter++;
        }

    }

    static void BacktoTheFuture()
    {
        DateTime now = DateTime.Now;
        DateTime future = now.AddSeconds(5);

        Console.Write("Wating for the future");

        while(now < future)
        {
            Thread.Sleep(100);
            now = DateTime.Now;
        }
        Console.WriteLine("The fututre has arrived");
    }


}