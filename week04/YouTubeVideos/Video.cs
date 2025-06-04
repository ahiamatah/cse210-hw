class Video
{
    public string Title { get; private set; }
    public string Author { get; private set; }
    public int LengthInSeconds { get; private set; }
    private List<Comment> comments;

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        comments = new List<Comment>();
    }

    // Adds a comment to the video
    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    // Returns number of comments
    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    // Returns all comments
    public List<Comment> GetComments()
    {
        return comments;
    }
}