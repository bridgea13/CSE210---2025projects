using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videoList = new List<Video>();
        Video _video1 = new Video("Bob the builder", 140, "Bob Jones");
        Video _video2 = new Video("Bluey's first Christmas", 200, "Tom Thumb");
        Video _video3 = new Video("Elena of Avalor", 1500, "Walt Disney");
        Video _video4 = new Video("Duck Tales", 10, "Scrooge McDuck");
        _video1.AddComment("Flash Zootopia", "Great afternoon with my kids!");
        _video1.AddComment("Pinocchio Gipeto", "Learned lots of new things!");
        _video1.AddComment("Potato Head", "Great afternoon!");
        _video2.AddComment("Darkwing Duck", "I cried the first time I saw this.");
        _video2.AddComment("Bruce Shark", " A tasty encounter.");
        _video2.AddComment("Sully Monster", "A scary treat.");
        _video3.AddComment("Wall-E", "A wonderful video.");
        _video2.AddComment("Remy Rat", " A wonderful holiday for the whole family!");
        _video3.AddComment("Chip Ranger", "Great time!");
        _video3.AddComment("Dale Ranger", "Fun time with my brother!");
        _video4.AddComment("Madd Hatter", "Great time!");
        _video4.AddComment("Captain Hook", "I loved this video!");
        _video4.AddComment("Flounder Mermaid", "I'm glad I saw this!");
        _video4.AddComment("Bing Bong", "I'm glad its over.");
        _videoList.Add(_video1);
        _videoList.Add(_video2);
        _videoList.Add(_video3);
        _videoList.Add(_video4);
        for (int i = 0; i < _videoList.Count; i++)
        {
            _videoList[i].DisplayAllVideos();
        }



    }
}