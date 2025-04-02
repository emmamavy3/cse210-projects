class Scripture
{
    private List<Word> _words;
    private Reference _reference;

    public Scripture(string name, int chapter, int verse, string text)
    {
        _reference = new Reference(name, chapter, verse);
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }
    public Scripture(string name, int chapter, int startVerse, int endVerse, string text)
    {
        _reference = new Reference(name, chapter, startVerse, endVerse);
        _words = text.Split(' ').Select(word => new Word(word)).ToList();

    }
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();

    }
    public bool HideSomeWords()
    {
        Random random = new Random();
        int numberOfHiddenWords = NumberOfHiddenWords();
        for (int i = 0; i < numberOfHiddenWords; i++)
        {
            int index = random.Next(_words.Count);
            _words[index].SetIsHidden(true);
        }
        return true;
    }
    public bool AllWordsHidden()
    {
        return _words.All(word => word.IsHidden());
    }
    public void ShowScripture()
    {
        Console.WriteLine(_reference.GetReference());
        foreach (Word word in _words)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
    }
    public string GetScriptureReference()
    {
        return _reference.GetReference();
    }

    private int NumberOfHiddenWords()
    {
        int numberOfWords = _words.Count;
        return (int)(numberOfWords * 0.3);
    }
    private List<string> ConvertToWords()
    {
        List<string> words = new List<string>();
        foreach (string word in _words)
        {
            words.Add(word);
        }
        return words;
    }

}