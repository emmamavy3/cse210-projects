using System.ComponentModel;

class Entry 
{
    private List<string> _prompts;
    private Random rand;
    DateTime theCurrentTime = DateTime.Now;
    private string currentPrompt;
    private string userEntry;

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
       theCurrentTime = DateTime.Now;

    }

    public void GetEntry()
    {
        int index = rand.Next(_prompts.Count);
        currentPrompt = _prompts[index];
        Console.WriteLine(currentPrompt);

        // string entry = Console.ReadLine();
        // Console.WriteLine(entry);
        userEntry = Console.ReadLine();
    }

    public string CreateFile()
    {

    }

    public void DisplayEntry()
    {
        string dateText = theCurrentTime.ToShortDateString();
    
        Console.WriteLine($"Date: {dateText} - Prompt: {currentPrompt} \n{userEntry}");

        

    }
}