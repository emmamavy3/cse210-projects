class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "Think of a time when you learned something new."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(int duration)
    : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    { 
        _duration = duration;
    }
    public void RunActivity()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine("\nReflect on the following prompt:");
        Console.Write($" {prompt} "); ;
        CountDown(15);
        Console.Clear();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin... ");
        DisplaySpinner(5);
        Console.Clear();

        foreach (string question in _questions)
        {
            Console.WriteLine("\n");
            Console.Write(question + " ");
            CountDown(10);
            Console.Clear();
        }
    }
}