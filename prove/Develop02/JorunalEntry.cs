class JournalEntry
{
    private List<string> _prompts;
    private Random rand;
    DateTime _date;
    private string currentPrompt;
    private string userEntry;

    public JournalEntry()
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
        _date = DateTime.Now;
    }
    public JournalEntry(string date, string prompt, string entry)
    {
        _date = DateTime.Parse(date);
        currentPrompt = prompt;
        userEntry = entry;
    }
    public void GetPrompt()
    {
        int index = rand.Next(_prompts.Count);
        currentPrompt = _prompts[index];
        Console.WriteLine(currentPrompt);

    }

    public string GetEntry()
    {
        Console.WriteLine("Please enter your response: ");
        userEntry = Console.ReadLine();
        return userEntry;
    }
    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date.ToShortDateString()} - Prompt: {currentPrompt}");
        Console.WriteLine($"Entry: {userEntry}");
    }
    public string FormatForFile()
    {
        return $"{_date.ToShortDateString()}#{currentPrompt}#{userEntry}";
    }
    public static JournalEntry ParseFromFile(string line)
    {
        string[] parts = line.Split("#");
        return parts.Length == 3 ? new JournalEntry(parts[0], parts[1], parts[2]) : null;
    }
}