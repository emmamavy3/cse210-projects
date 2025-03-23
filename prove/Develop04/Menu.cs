class Menu
{
    public int DisplayMenu()
    {
        Console.WriteLine("Menu Opions");
        Console.WriteLine("1. Start breathing actvity");
        Console.WriteLine("2. Start reflecting actvity");
        Console.WriteLine("3. Start listing actvity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a choice from the menu: ");

        int response = int.Parse(Console.ReadLine());
        return response;
    }
}