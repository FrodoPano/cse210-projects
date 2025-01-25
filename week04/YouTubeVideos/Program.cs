using System;

class Program
{
    static void Main(string[] args)
    {
        var video1 = new Video("How to Cook Pasta", "Chef John", 600);
        var video2 = new Video("Top 10 Programming Tips", "CodeMaster", 420);
        var video3 = new Video("DIY Home Decor Ideas", "CraftyHands", 540);
        var video4 = new Video("Travel Vlog: Paris", "WanderLust", 780);

        // Add comments to videos
        video1.AddComment(new Comment("Alice", "This was so helpful!"));
        video1.AddComment(new Comment("Bob", "Great recipe, I tried it yesterday."));
        video1.AddComment(new Comment("Charlie", "What other dishes can you make?"));

        video2.AddComment(new Comment("DevGuy", "This is gold, thanks!"));
        video2.AddComment(new Comment("CodeGirl", "Loved the tips on debugging."));
        video2.AddComment(new Comment("PythonFan", "Can you make one on Python specifically?"));

        video3.AddComment(new Comment("Emma", "Such creative ideas!"));
        video3.AddComment(new Comment("Noah", "Perfect for my weekend project."));
        video3.AddComment(new Comment("Sophia", "Where did you get the materials?"));

        video4.AddComment(new Comment("Traveler99", "I miss Paris so much."));
        video4.AddComment(new Comment("Liam", "Great video, so inspiring!"));
        video4.AddComment(new Comment("Olivia", "Where did you stay in Paris?"));

        var videos = new List<Video> { video1, video2, video3, video4 };

        foreach (var video in videos)
        {
            Console.WriteLine(video.GetVideoInfo());
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"  - {comment.GetDisplayText()}");
            }
            Console.WriteLine("\n" + new string('-', 40) + "\n");
        }
    }
}