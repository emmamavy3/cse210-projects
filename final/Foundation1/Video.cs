class Video
{
    private string title;
    private string author;
    private int length;

    public Video(string title, string author, int length)
    {
        this.title = title;
        this.author = author;
        this.length = length;
    }
    public string GetTitle()
    {
        title = "A Youtube Video";
        return title;
    }
    public string GetAuthor()
    {
        author = "A Youtube Author";
        return author;
    }
    public int GetLength()
    {
        length = 120;
        return length;
    }
    public void SetTitle(string title)
    {
        this.title = title;
    }
    public void SetAuthor(string author)
    {
        this.author = author;
    }
    public void SetLength(int length)
    {
        this.length = length;
    }
    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {title}, Author: {author}, Length: {length} seconds");
    }

}   