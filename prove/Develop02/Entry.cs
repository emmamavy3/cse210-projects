using System.ComponentModel;

class Entry 
{
    private List<string> _prompts;
    private Random rand;

    public void GetPrompt()
    {
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
       rand = new Random();

    }

    public void GetEntry()
    {
        int index = rand.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);

        string entry = Console.ReadLine();
        Console.WriteLine(entry);
    }
}