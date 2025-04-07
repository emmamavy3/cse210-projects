class Activity
{
    private string _activityName;
    private string _activityDescription;
    protected int _duration;
    private DateTime _endTime;

    public Activity(string activityName, string activityDescription)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName}");
        Console.WriteLine(_activityDescription);
        Console.WriteLine("Prepare to begin... ");
        DisplaySpinner(3);
    }
    public void DisplayEnding()
    {
        Console.WriteLine("Well Done!!!");
        Console.WriteLine($"You have completes another {_duration} seconds of the {_activityName} Activity.");
        DisplaySpinner(3);
    }
    public void DisplaySpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        _endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < _endTime)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(500);
            Console.Write("\b");
            i++;
        }

    }
    protected void CountDown(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
            if (seconds >= 10)
            {
                Console.Write("\b\b");
            }
            else if (seconds >= 1)
            {
                Console.Write("\b");
            }
            else if (seconds == 0)
            {
                Console.Write(" ");
            }
            Console.Write("\b");
            seconds--;
        }
    }

    public int ObtainDuration()
    {
        Console.Write("How long, in seconds, would you like for your session: ");
        _duration = int.Parse(Console.ReadLine());
        return _duration;
    }

}