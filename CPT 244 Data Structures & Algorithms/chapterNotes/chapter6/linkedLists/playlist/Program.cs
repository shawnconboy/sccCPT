using System;

class Program
{
    static void Main()
    {
        // declare and initialize the list
        List<string> playlist = new List<string> { "Track 1", "Track 2", "Track 3" };

        playlist.Add("Track 4");
        playlist.Insert(0, "Intro");
        playlist.RemoveAt(2);
        playlist.Add("Track 2");

        playlist.Sort();

        foreach (var song in playlist)
        {
            Console.WriteLine(song);
        }
    }
}