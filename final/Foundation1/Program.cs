using System;

class Program
{
    // namespace videodemo
    
    
    #pragma warning restore format
    static void Main(string[] args)
    {
                
        Video v1 = new Video ();
        v1._title = "Desa and Friends";
        v1._author = "Aaron Santos";
        v1._length = 200;

        Comment comment1 = new Comment();
        comment1._name = "Fire123";
        comment1._comments = "Excellent. ";
        v1._comments.Add(comment1);

        Comment comment2 = new Comment();
        comment2._name = "WinterIsComing";
        comment2._comments = "Could be better.";
        v1._comments.Add(comment2);

        Comment comment3 = new Comment();
        comment3._name = "Aaron S";
        comment3._comments = "Excellent. ";
        v1._comments.Add(comment3);   


        Video v2 = new Video ();
        v2._title = "It's all about Us ";
        v2._author = "Aaron Santos";
        v2._length = 100;

        Comment comment4 = new Comment();
        comment4._name = "Wonderpets";
        comment4._comments = "Excellent. ";
        v2._comments.Add(comment4);

        Comment comment5 = new Comment();
        comment5._name = "Tagalog is life";
        comment5._comments = "Nakakapanibago.";
        v2._comments.Add(comment5);

        Comment comment6 = new Comment();
        comment6._name = "March comes in like a lion";
        comment6._comments = "Just forget it!. ";
        v2._comments.Add(comment6);


        Video v3 = new Video ();
        v3._title = "A Marriage Proposal";
        v3._author = "Aaron S";
        v3._length = 400;

        Comment comment7 = new Comment();
        comment7._name = "Desalove";
        comment7._comments = "Excellent. ";
        v3._comments.Add(comment7);

        Comment comment8 = new Comment();
        comment8._name = "DesaSays";
        comment8._comments = "Yes, I do.";
        v3._comments.Add(comment8);

        Comment comment9 = new Comment();
        comment9._name = "WeCanBe123";
        comment9._comments = "Where is that place? ";
        v3._comments.Add(comment9);

        // put them in a list
        List <Video> l1 = new List<Video> ();
        l1.Add(v1);
        l1.Add(v2);
        l1.Add(v3);

        foreach (Video v in l1)
        {
            v.VideoDisplay();
            

        }
    }
    
}