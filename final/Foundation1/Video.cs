class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void SetComment()
    {
        Comment newComment = new Comment("Commenter Name", "Comment Text");
        _comments = new List<Comment>();
        _comments.Add(newComment);
    }
    public string GetComment()
    {
        return _comments[0].CommentText;
    }
    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}, Author: {_author}, Length: {_length} seconds");
        foreach (var comment in _comments)
        {
            Console.WriteLine($"Comment by {comment.CommenterName}: {comment.CommentText}");
        }
    }
    // public string GetTitle()
    // {
    //     _title = "A Youtube Video";
    //     return title;
    // }
    // public string GetAuthor()
    // {
    //     author = "A Youtube Author";
    //     return author;
    // }
    // public int GetLength()
    // {
    //     length = 120;
    //     return length;
    // }
    // public void SetTitle(string title)
    // {
    //     this.title = title;
    // }
    // public void SetAuthor(string author)
    // {
    //     this.author = author;
    // }
    // public void SetLength(int length)
    // {
    //     this.length = length;
    // }
    // public void DisplayVideo()
    // {
    //     Console.WriteLine($"Title: {title}, Author: {author}, Length: {length} seconds");
    // }

}   