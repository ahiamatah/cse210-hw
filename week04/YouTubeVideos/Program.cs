using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

         // Create some videos
        Video video1 = new Video("How to Cook Pasta", "ChefAnna", 300);
        video1.AddComment(new Comment("JohnDoe", "Great recipe!"));
        video1.AddComment(new Comment("Foodie123", "Thanks for sharing."));
        video1.AddComment(new Comment("CookingFan", "I loved this video!"));

        Video video2 = new Video("DIY Home Decor", "CraftySue", 450);
        video2.AddComment(new Comment("ArtLover", "So creative!"));
        video2.AddComment(new Comment("DIYGuy", "I will try this for sure."));
        video2.AddComment(new Comment("HandmadeGal", "Beautiful ideas!"));

        Video video3 = new Video("Workout Routine for Beginners", "FitCoach", 600);
        video3.AddComment(new Comment("GymRat", "Very helpful."));
        video3.AddComment(new Comment("Newbie", "Perfect for beginners."));
        video3.AddComment(new Comment("HealthGuru", "Keep up the good work!"));

        // Put videos into a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Iterate through each video and display info + comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine();  // Blank line between videos
        }
    }
}