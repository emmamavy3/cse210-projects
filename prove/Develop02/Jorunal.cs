
class Journal
{
    private List<JournalEntry> _entries;

    public Journal()
    {
        _entries = new List<JournalEntry>();
    }

    public void AddEntry(JournalEntry entry)
    {
        _entries.Add(entry);
    }
    public void Display()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine(entry.DisplayEntry());
        }
    }

    public void SaveToFile(string journalName)
    {
        string filename = journalName + ".txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                outputFile.WriteLine(entry.FormatForFile());
            }
        }
    }

    public void loadEntries(string fileName = "journal.txt")
    {
        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                string[] parts = line.Split("#");
                if (parts.Length == 3)
                {
                    Console.WriteLine($"Date: {parts[0]} - Prompt: {parts[1]} - Entry: {parts[2]}");
                    JournalEntry entry = new JournalEntry(parts[0], parts[1], parts[2]);
                    _entries.Add(entry);
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}