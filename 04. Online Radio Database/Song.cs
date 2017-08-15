using System;
using System.Linq;

public class Song
{
    private string artist;
    private string songName;
    private string songLength;
    private int minutes;
    private int seconds;

    public Song(string artist, string songName, string songLength)
    {
        this.Artist = artist;
        this.SongName = songName;
        this.SongLength = songLength;
    }

    public int getLength()
    {
        return (this.minutes * 60) + this.seconds;
    }

    private string Artist
    {
        get { return this.artist; }
        set
        {
            if (value.Length < 3 || value.Length > 20)
            {
                throw new ArgumentException(ExceptionMessages.InvalidArtistNameException);
            }
        }
    }

    private string SongName
    {
        get { return this.songName; }
        set
        {
            if (value.Length < 3 || value.Length > 20)
            {
                throw new ArgumentException(ExceptionMessages.InvalidSongNameException);
            }
        }
    }

    private string SongLength
    {
        get { return this.songLength; }
        set
        {
            var asd = value
                .Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            if (value.Length > 5)
            {
                throw new ArgumentException(ExceptionMessages.InvalidSongLengthException);
            }
            if (asd[0] < 0 || asd[0] >= 15)
            {
                throw new ArgumentException(ExceptionMessages.InvalidSongMinutesException);
            }
            if (asd[1] < 0 || asd[1] > 59)
            {
                throw new ArgumentException(ExceptionMessages.InvalidSongSecondsException);
            }
            this.Minutes = asd[0];
            this.Seconds = asd[1];

            this.songLength = value;
        }
    }

    private int Minutes
    {
        get { return this.minutes; }
        set { this.minutes = value; }
    }

    private int Seconds
    {
        get { return this.seconds; }
        set { this.seconds = value; }
    }
}
