using System;

class Program
{
    static void Main(string[] args)
    {
        int response;
        Journal myJournal = new Journal();
        do
        {
            response = Menu(myJournal);
        } while (response != 5);
    }

    static int Menu(Journal myJournal)
    {
        Console.WriteLine("Please select one of the following");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do");
        int response = int.Parse(Console.ReadLine());

        switch (response)
        {
            case 1:
                JournalEntry newEntry = new JournalEntry();
                newEntry.GetPrompt();
                newEntry.GetEntry();
                myJournal.AddEntry(newEntry);
                break;
            case 2:
                myJournal.Display();
                break;
            case 3:
                Console.WriteLine("Please enter the file name to load: ");
                myJournal.loadEntries(Console.ReadLine());
                break;
            case 4:
                Console.WriteLine("Please create a file name: ");
                myJournal.SaveToFile(Console.ReadLine());
                break;
            case 5:
                Console.WriteLine("Goodbye!");
                break;
            default:
                Console.WriteLine("Invalid selection. Please try again.");
                break;
        }
        return response;

    }
}