using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation1 World!");
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Despacito", "Luis Fonsi", 227);
        video1.AddVideoComment(new Comment("Pedro", "Me gusta esta rola!"));
        video1.AddVideoComment(new Comment("Pancho", "No me gusta el rock!"));
        video1.AddVideoComment(new Comment("Juan", "Queremos rock!"));
        videos.Add(video1);

        Video video2 = new Video("Shape of You", "Ed Sheeran", 234);
        video2.AddVideoComment(new Comment("Peter", "I like this song!"));
        video2.AddVideoComment(new Comment("Frank", "I don't like rock!"));
        video2.AddVideoComment(new Comment("John", "We like rock!"));
        videos.Add(video2);

        Video video3 = new Video("Uptown Funk", "Mark Ronson", 235);
        video3.AddVideoComment(new Comment("Rick", "I don't care what you say, I like this song!"));
        video3.AddVideoComment(new Comment("Rico", "One of the best songs ever!"));
        video3.AddVideoComment(new Comment("Rich", "I don't like Mars!"));
        videos.Add(video3);

        foreach (Video v in videos)
        {
            Console.Write(v.GetDisplayText());
            Console.WriteLine();
        }
    }
}