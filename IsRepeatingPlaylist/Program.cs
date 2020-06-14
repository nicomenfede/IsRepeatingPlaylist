using System;
using System.Collections.Generic;

public class Song
{
    private string name;
    public Song NextSong { get; set; }

    public Song(string name)
    {
        this.name = name;
    }

    public bool IsRepeatingPlaylist()
    {
        List<Song> songs = new List<Song>();
        songs.Add(this);
        var current = NextSong;

        while (!current.NextSong.Equals(null))
        {
            if (songs.Contains(current.NextSong))
                return true;

            songs.Add(current = current.NextSong);
        }

        return false;
    }

    public static void Main(string[] args)
    {
        Song first = new Song("Hello");
        Song second = new Song("Eye of the tiger");

        first.NextSong = second;
        second.NextSong = first;

        Console.WriteLine(first.IsRepeatingPlaylist());
    }
}
