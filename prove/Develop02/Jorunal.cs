
class Journal
{
    private List<string> _entries;

    public Journal()
    {
        _entries = [];
    }

    public void AddEntry(Entry userEntry)
    {
        _entries.Add(userEntry);
    }

    public void ReadFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("#");

            string date = parts[0];
            string currentPrompt = parts[1];
            string entryText = parts[3];

            Entry entry = new Entry( date, currentPrompt, userEntry)
        }
    }
}