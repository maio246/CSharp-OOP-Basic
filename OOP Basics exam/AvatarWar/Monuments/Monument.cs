public abstract class Monument
{
    public string monumentName;
    public int affinity;

    public string MonumentName
    {
        get { return this.monumentName; }
        set { this.monumentName = value; }
    }

    protected Monument(string name)
    {
        this.MonumentName = name;
    }
}

