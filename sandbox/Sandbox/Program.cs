using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        // Console.WriteLine("Hello CSE 210");
        // Console.WriteLine("Please enter your name");
        // string name = Console.ReadLine();
        // Console.WriteLine($"{name}");

        //double x = 10;
        Circle myCircle = new Circle(10);
        myCircle.DisplayCircleArea();

        Cylinder myCylinder = new Cylinder(10, myCircle);
        double volume = myCylinder.GetVolume();
        Console.WriteLine($"My Cylinder's volume is: {volume}");

        // Circle myCircle2 = new Circle(20);
        // myCircle2.DisplayCircleArea();

        // for(int i = 0; i < 30; i++)
        // {
        //     myCircle.SetRadius(i);
        //     double circleArea = myCircle.GetArea();
        //     Console.WriteLine($"{i}: Circle area is: {circleArea}");
        //     //myCircle.DisplayCircleArea;
        // }
        
    }
}