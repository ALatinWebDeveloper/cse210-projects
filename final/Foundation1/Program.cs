using System;

class Program
{
    static void Main(string[] args)
    {
        List<Comment> commentList = new List<Comment>();

        Comment commentVideo1= new Comment("Juan", "I loved the intro");
        Comment commentVideo2= new Comment("Jake_15", "Whait why not just go around?");
        Comment commentVideo3= new Comment("CastleRed", "I've seen this before and it still surprises me...");
        Comment commentVideo4= new Comment("Anonimus", "Got to share this");

        commentList.Add(commentVideo1);
        commentList.Add(commentVideo2);
        commentList.Add(commentVideo3);
        commentList.Add(commentVideo4);

        Video video1= new Video("Tutorial: How to dig a hole", "Dazai_Dazai", 1600, commentList);
        Video video2= new Video("Digging digging hole through the planet", "Paulest Paul", 532, commentList);
        Video video3= new Video("Is the planet flat? I'll test it digging a hole", "Dazai_Dazai", 1005, commentList);
        Video video4= new Video("Not digging a hole today... :c", "Dazai_Dazai", 3254, commentList);

        List<Video> videos= new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        Console.Clear();

        foreach (Video video in videos)
        {
            Console.WriteLine($"Author: {video.DisplayAuthor()}, Title: {video.DisplayTitle()}, Length: {video.DisplayLength()}, Number of comments: {commentList.Count()}");
            Console.WriteLine();
            video.DisplayComment();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}