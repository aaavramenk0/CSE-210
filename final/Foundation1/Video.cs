public class Video
{
    public Video() {

    }

    public string _author; // Fireship
    public string _title;
    public string _likes;
    public string _length;
    public string _url;
    
    
    public void AddComment(string author, string text) {
        comments.Add($"{author} : {text}");
    }

    // string - строка
    // int - целое число ( 1, 2, 3, 4 ...)
    // double - дробное число (1.2; 1.5; 5.94)
    // void - не возвращает ничего

    // откуда есть доступ (public, private, protected, virtual) | какой тип данных возвращает (string, int, double, void) | имя функции 
    public string GetVideoInfo() {
        return $"\n'{_title}' by '{_author}' has {comments.Count} comments and {_likes} likes. Length is {_length}. URL: {_url}";
    }
    
    public List<string> comments = new List<string>();
    public void GetComments() {
        Console.WriteLine("Comments: ");
        foreach (string comment in comments)
        {
            Console.WriteLine(" > " + comment);
        }
    }
}