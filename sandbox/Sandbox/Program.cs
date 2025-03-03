using System;

class Circle
{
    private double radius;

    public Circle(double r)
    {
        radius = r;
    }

    public double GetArea()
    {
        double area = Math.PI* radius * radius;
        return area;
    }

    public void DisplayCircleArea()
    {
        Console.WriteLine($"The area of the circle is : {GetArea()}");
    }

    public void SetRadius()
    {
        radius = r;
    }
}


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
        // Circle myCircle2 = new Circle(20);
        // myCircle2.DisplayCircleArea();

        for(int i = 0; i < 30; i++)
        {
            myCircle.SetRadius(i);
            double circleArea = myCircle.GetArea();
            Console.WriteLine($"{i}: Circle area is: {circleArea}");
            //myCircle.DisplayCircleArea;
        }
        
    }
}