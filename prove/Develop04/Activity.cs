class Activity
{
    private string _activityName;
    private string _activityDescription;
    private int _duration;
    private DateTime _endTime;
    public Activity(string activityName, string activityDescription, int duration)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
        _duration = duration;
    }
    public void DisplayActivity()
    {
        Console.WriteLine($"Welcome to the {_activityName} Activity");
    }
    public void DisplayDescription()
    {
        Console.WriteLine($"This activity {_activityDescription}");
    }
    public void DisplayEnding()
    {
        Console.WriteLine("Well Done!!!");
        Console.WriteLine($"You have completes another {_duration} seconds of the {_activityName} Activity.");
    }
    // public void RunCountDown()
    // {
        
    // }
    public void DisplaySpinner()
    {
        int counter = 0;
        string spinnerString = "+-";
        DateTime now = DateTime.Now;
        DateTime passing = now.AddSeconds(_duration);


        Console.WriteLine("Get Ready...");

        while(now < passing)
        {
            Thread.Sleep(100);
            now = DateTime.Now;
            Console.Write($"{spinnerString[counter%2]}");
            Console.Write("\b");
            Thread.Sleep(200);
        }
        Console.WriteLine("The fututre has arrived");


    }

    public void StartTime()
    {

    }

    public void ObtainDuration()
    {
        Console.Write("How long, in seconds, would you like for your session: ");
        _duration = int.Parse(Console.ReadLine());
    }

//     static void RunSpinner()
//     {
//         int counter = 0;
//         //string spinnerString = "+-";

//         string[] spinnerStrings = {":)", ":("};

//         while(counter < 10)
//         {
//             Console.Write($"{spinnerStrings[counter%2]}");
//             Console.Write("\b\b");
//             Thread.Sleep(200);
//             // Console.Write("-");
//             // Console.Write("\b");
//             //Thread.Sleep(200);
//             counter++;
//         }

//     }

//     static void BacktoTheFuture()
//     {
//         DateTime now = DateTime.Now;
//         DateTime future = now.AddSeconds(5);

//         Console.Write("Wating for the future");

//         while(now < future)
//         {
//             Thread.Sleep(100);
//             now = DateTime.Now;
//         }
//         Console.WriteLine("The fututre has arrived");
//     }
}