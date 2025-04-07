class BreathingActivity : Activity
{
    public BreathingActivity(int duration)
    : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        _duration = duration;
    }
    public void RunActivity()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breath in...");
            CountDown(4);
            Console.WriteLine("Breath out...");
            CountDown(4);
        }
        Console.Clear();
    }
}