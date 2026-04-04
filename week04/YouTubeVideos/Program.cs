using System;
using System.Collections.Generic;

public class Comment
{
    public string Name { get; set; }
    public string Text { get; set; }

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    private List<Comment> Comments;

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return Comments.Count;
    }

    public List<Comment> GetComments()
    {
        return Comments;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Learning C#", "TechGuru", 600);
        Video video2 = new Video("OOP Explained", "CodeMaster", 750);
        Video video3 = new Video("Abstraction Basics", "DevSimplified", 500);

        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "Loved the examples."));

        video2.AddComment(new Comment("David", "Now I understand OOP!"));
        video2.AddComment(new Comment("Eva", "Clear and concise."));
        video2.AddComment(new Comment("Frank", "Can you make more videos?"));

        video3.AddComment(new Comment("Grace", "Abstraction finally makes sense."));
        video3.AddComment(new Comment("Hank", "This helped a lot."));
        video3.AddComment(new Comment("Ivy", "Thanks for simplifying this topic."));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length (seconds): " + video.Length);
            Console.WriteLine("Number of comments: " + video.GetCommentCount());

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}