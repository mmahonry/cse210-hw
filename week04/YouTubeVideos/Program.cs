using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video v1 = new Video("Learning C# Classes", "TechAcademy", 540);
        v1.AddComment(new Comment("Ana", "Very helpful explanation!"));
        v1.AddComment(new Comment("Carlos", "Thanks, this made it so easy."));
        v1.AddComment(new Comment("Luis", "I finally understand objects!"));
        videos.Add(v1);

        // Video 2
        Video v2 = new Video("Top 10 Travel Destinations", "TravelWorld", 780);
        v2.AddComment(new Comment("Maria", "I want to visit all of these!"));
        v2.AddComment(new Comment("John", "Great video and music."));
        v2.AddComment(new Comment("Elena", "Amazing edits!"));
        videos.Add(v2);

        // Video 3
        Video v3 = new Video("Healthy Recipes for Busy People", "FoodieLife", 600);
        v3.AddComment(new Comment("Robert", "I tried the 2nd recipe—so good!"));
        v3.AddComment(new Comment("Jess", "Please make more videos like this."));
        v3.AddComment(new Comment("Tom", "Simple and easy to follow."));
        videos.Add(v3);

        // Display all
        foreach (Video vid in videos)
        {
            vid.DisplayVideoInfo();
        }
    }
}