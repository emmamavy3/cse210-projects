using System;

class Program
{
    static void Main(string[] args)
    {
        Entry myEntry = new Entry();
        myEntry.GetPrompt();
        myEntry.GetEntry();
        myEntry.DisplayEntry();

    }

    static void Menu()
    {
        Console.WriteLine("Please select one of the following");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do");
        int response = int.Parse(Console.ReadLine());

        switch(response)
        {
            case 1:
                Entry myEntry = new Entry();
                myEntry.GetPrompt();
                myEntry.GetEntry();
            break;

            case 2:
                myEntry.DisplayEntry();
            break;

            case 3:
                

        }

        // if (num == 1)
        // {
        //     Entry myEntry = new Entry();
        //     myEntry.GetPrompt();
        //     myEntry.GetEntry();
        //     myEntry.DisplayEntry();
        // }
        // else if (num == 2)
        // {

        // }
        // else if (num == 3)
        // {

        // }
        // else if (num == 4)
        // {

        // }
        // else if (num == 5)
        // {
        //     Console.WriteLine("");
        // }
    }
}