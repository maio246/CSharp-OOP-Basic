using System;
using System.Collections.Generic;
using System.Linq;

public static class RadioData
{
    public static void Main()
    {

        var songPlaylist = new SongsDatabase();

        var songsNumb = long.Parse(Console.ReadLine());

        for (int i = 0; i < songsNumb; i++)
        {
            var tokens = Console.ReadLine().Split(new []{';'}, StringSplitOptions.RemoveEmptyEntries);

            if (tokens.Length == 3)
            {

                var artist = tokens[0];
                var songName = tokens[1];
                var length = tokens[2];
                try
                {
                    var song = new Song(artist, songName, length);
                    songPlaylist.Add(song);
                    Console.WriteLine("Song added.");
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        Console.WriteLine($"Songs added: {songPlaylist.Count()}");
        var playlistLength = songPlaylist.PlaylistTotalTime();

        long hours = playlistLength / 60 / 60;
        long minutes = (playlistLength / 60) - (hours * 60);
        long seconds = playlistLength % 60;

        Console.WriteLine($"Playlist length: {hours}h {minutes}m {seconds}s");

    }


}
