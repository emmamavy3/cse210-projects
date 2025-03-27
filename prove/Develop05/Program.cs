using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        Menu theMenu = new Menu();

        switch (theMenu.DisplayMenu())
        {
            case 1:
                switch (theMenu.DisplayCreateGoalMenu())
                {
                    case 1:
                        Console.WriteLine("You selected Simple Goal.");
                        break;
                    case 2:
                        Console.WriteLine("You selected Eternal Goal.");
                        break;
                    case 3:
                        Console.WriteLine("You selected Checklist Goal.");
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please try again.");
                        break;
                }
                break;
            case 2:
                Console.WriteLine("You selected 2.");
                break;
            case 3:
                Console.WriteLine("You selected 3.");
                break;
            case 4:
                Console.WriteLine("You selected 4.");
                break;
            case 5:
                Console.WriteLine("You selected 5.");
                break;
            case 6:
                Console.WriteLine("You selected 6.");
                break;
            default:
                Console.WriteLine("Invalid selection. Please try again.");
                break;
        }

    }
}