using System;

class Program
{
    static void Main(string[] args)
    {
        Content newContent = new Content();
        List<Video> videos = newContent.GetVideos();
        foreach (Video video in videos)
        {
            video.DisplayVideo();
        }
    }
}