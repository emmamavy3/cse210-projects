using System;
class Program
{
    static void Main(string[] args)
    {
        Menu viewMenu = new Menu();
        bool isRunning = true;
        Activity activity = new Activity("DefaultActivityName", "DefaultActivityDescription");
        // int duration = activity.ObtainDuration();

        while (isRunning)
        {
            int choice = viewMenu.DisplayMenu();

            switch (choice)
            {
                case 1:
                    int duration = activity.ObtainDuration();
                    BreathingActivity breathing = new BreathingActivity(duration);
                    breathing.DisplayStartingMessage();
                    Console.Clear();
                    breathing.RunActivity();
                    Console.Clear();
                    breathing.DisplayEnding();
                    break;
                case 2:
                    duration = activity.ObtainDuration();
                    ReflectionActivity reflection = new ReflectionActivity(duration);
                    reflection.DisplayStartingMessage();
                    reflection.RunActivity();
                    reflection.DisplayEnding();
                    break;
                case 3:
                    duration = activity.ObtainDuration();
                    ListingActivity listing = new ListingActivity(duration);
                    listing.DisplayStartingMessage();
                    listing.RunActivity();
                    listing.DisplayEnding();
                    break;
                case 4:
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }
}