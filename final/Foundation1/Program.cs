using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");
        Video video = new Video("A Youtube Video", "A Youtube Author", 120);
        video.SetComment();
        video.DisplayVideo();
    }
}