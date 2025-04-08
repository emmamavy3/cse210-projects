class Content
{
    public List<Video> GetVideos()
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Tech Review 2024", "GadgetGeek", 300);
        video1.AddComment(new Comment("Alice", "Great review!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks."));
        video1.AddComment(new Comment("Charlie", "Can you do a follow-up?"));
        videos.Add(video1);

        Video video2 = new Video("Cooking Pasta", "ChefTime", 480);
        video2.AddComment(new Comment("Dana", "Yum! I'm hungry now."));
        video2.AddComment(new Comment("Eli", "Tried this and it was amazing."));
        video2.AddComment(new Comment("Fay", "More vegetarian recipes please!"));
        videos.Add(video2);

        Video video3 = new Video("Fitness at Home", "HealthFirst", 600);
        video3.AddComment(new Comment("George", "This got me sweating."));
        video3.AddComment(new Comment("Hannah", "Perfect for busy people."));
        video3.AddComment(new Comment("Ian", "Love the energy!"));
        videos.Add(video3);

        return videos;
    }
}
