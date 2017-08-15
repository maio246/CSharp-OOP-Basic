using System.Collections.Generic;

public class SongsDatabase
{
    private List<Song> songs;

    public SongsDatabase()
    {
        this.songs = new List<Song>();
    }
    public void Add(Song song)
    {
        songs.Add(song);
    }

    public int Count()
    {
        return songs.Count;
    }

    public long PlaylistTotalTime()
    {
        var time = 0;

        foreach (var song in songs)
        {
            time += song.getLength();
        }

        return time;
    }

}
