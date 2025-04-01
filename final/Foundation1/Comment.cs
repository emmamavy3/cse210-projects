class Comment
{
    private List<string> _comments;
    private string _commenterName;
    private string _commentText;

    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
        _comments = new List<string>();
    }
}