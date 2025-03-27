class Menu
{
    public int DisplayMenu()
    {
        Console.WriteLine("Menu Opions");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select a choice from the menu: ");
        int response = int.Parse(Console.ReadLine());
        return response;
    }
    public int DisplayCreateGoalMenu()
    {
        Console.WriteLine("The type of goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create? ");
        Console.Write("Select a choice from the menu: ");
        int goalType = int.Parse(Console.ReadLine());
        return goalType;
    }
}