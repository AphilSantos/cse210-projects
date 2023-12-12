public class Comment

{
    public string _name;
    public string _comments;

    // public List <string> _commentList;

    
    
    public void DisplayComment()
    {
        
            Console.WriteLine($"{_name}: {_comments}");
    }

}