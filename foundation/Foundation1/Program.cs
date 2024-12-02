using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Understanding Abstraction", "Alex Christensen", 300);
        video1.AddComment(new Comment("Emily", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "I learned a lot."));

        Video video2 = new Video("Encapsulation in C#", "Alex Christensen", 450);
        video2.AddComment(new Comment("Steve", "Nice video!"));
        video2.AddComment(new Comment("Eve", "Could you explain more about encapsulation?"));

        Video video3 = new Video("Polymorphism Explained", "Alex Christensen", 600);
        video3.AddComment(new Comment("Frank", "Interesting topic."));
        video3.AddComment(new Comment("Grace", "Looking forward to more videos!"));
        video3.AddComment(new Comment("Leon", "Good job!"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

         foreach (var video in videos)
        {
            video.DisplayVideoDetails();
        }
        
    }
}