class Scripture
{
    private List<Word> _words;
    private Reference _reference;
    private static Random _random = new Random();

    // public Scripture(string name, int chapter, int verse, string text)
    // {
    //     _reference = new Reference(name, chapter, verse);
    //     _words = text.Split(' ').Select(word => new Word(word)).ToList();
    // }
    // public Scripture(string name, int chapter, int startVerse, int endVerse, string text)
    // {
    //     _reference = new Reference(name, chapter, startVerse, endVerse);
    //     _words = text.Split(' ').Select(word => new Word(word)).ToList();

    // }
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();

    }
    public bool HideSomeWords()
    {
        int wordsToHide = 3; // Hide 3 words at a time
        List<Word> visibleWords = _words.Where(word => !word.IsHidden()).ToList();


        for (int i = 0; i < wordsToHide && visibleWords.Count > 0; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].SetIsHidden(true);
            visibleWords.RemoveAt(index);
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
            Console.Write(word.GetHiddenWord() + " ");
        }
        Console.WriteLine();
    }
    


}