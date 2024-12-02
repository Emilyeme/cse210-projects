public class Video
{
    public string Title {get; set;}
    public string Author {get;set;}
    public int Length {get;set;}

    public List<Comment> comments;

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        comments = new List<Comment>();

    }

    public void AddComment(Comment Comment)
    {
        comments.Add(Comment);
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author:{Author}");
        Console.WriteLine($"Length:{Length} seconds");
        Console.WriteLine($"Number of Comments:{GetNumberOfComments}");
        Console.WriteLine("Comments:");
        foreach (var comment in comments){
            Console.WriteLine($"- {comment.GetCommentDetails ()}");

            
        }
    }
}