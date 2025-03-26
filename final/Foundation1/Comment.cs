public class Comment
{
    private string _commentAuthor;
    private string _commentText;
    public Comment(string commentAuthor, string commentText){
        _commentAuthor = commentAuthor;
        _commentText = commentText;
    }
    public string DisplayComment(){
        string displayComment;
        displayComment = "Author: "+ _commentAuthor+" Text: "+ _commentText;
        return displayComment;
    }
}