class BreathingActivity : Activity
{
    public BreathingActivity(string activityName, string activityDescription, int duration)
    : base(activityName, activityDescription, duration)
    {
        activityName = "Breathing";
        activityDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public void RunActvity()
    {
        Console.WriteLine("Breath in...");
        Console.WriteLine("Breath out...");
    }
}