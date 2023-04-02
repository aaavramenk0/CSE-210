public class Video
{
    public Video() {

    }

    public string _author;
    public string _title;
    public string _likes;
    public string _length;
    public string _url;
    public List<string> comments = new List<string>();
    
    public void AddComment(string author, string text) {
        comments.Add($"{author} : {text}");
    }

    public string GetVideoInfo() {
        return $"\n'{_title}' 'by {_author}' has {comments.Count} comments and {_likes} likes. Length is {_length}. URL: {_url}";
    }

    public void GetComments() {
        Console.WriteLine("Comments: ");
        foreach (string comment in comments)
        {
            Console.WriteLine(" > " + comment);
        }
    }
}