class Reference
{
    private string _bookName;
    private int _chapter;
    private int[] _verse;

    public Reference(string bookName, int chapter, int verse)
    {
        _bookName = bookName;
        _chapter = chapter;
        _verse = new int[] { verse };
    }
    public Reference(string bookName, int chapter, int startVerse, int endVerse)
    {
        _bookName = bookName;
        _chapter = chapter;
        _verse = new int[] { startVerse, endVerse };
    }
    public void ShowReference()
    {
        Console.WriteLine($"{_bookName} {_chapter}:{string.Join(",", _verse)}");
    }
    public string GetReference()
    {
        return _bookName;
    }
    private string GetReferenceString()
    {
        return $"{_bookName} {_chapter}:{string.Join(",", _verse)}";
    }
}