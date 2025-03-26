public class Video
{
    private string _title;
    private string _author;
    private int _lengthSecconds;
    private List<Comment> _comments;

    public  Video(string title,  int lengthSecconds ,string author)
    {
        _title = title;
        _author = author;
        _lengthSecconds = lengthSecconds;
        _comments = new List<Comment>();
    }

    public void AddComment(string author, string commentText)
    {
        Comment comment = new Comment(author, commentText);
        _comments.Add(comment);
    }

    public int GetCommentTotal(){
        return _comments.Count;
    }

    public void DisplayAllVideos(){
        Console.WriteLine("Title: "+ _title);
        Console.WriteLine("Author: "+ _author);
        Console.WriteLine("Length (in seconds) "+_lengthSecconds);
        Console.WriteLine("Comment Count:"+ GetCommentTotal());
        for (int i = 0; i<_comments.Count; i++){
            int count = i +1;
            Console.WriteLine("Comment number "+ count + ": "+ _comments[i].DisplayComment());
        }
    }


}