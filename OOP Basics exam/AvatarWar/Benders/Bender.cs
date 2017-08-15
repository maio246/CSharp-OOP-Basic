public abstract class Bender
{
    public string benderName;
    public int power;

    public int Power
    {
        get { return this.power; }
        set { this.power = value; }
    }

    protected Bender(string name, int power)
    {
        this.BenderName = name;
        this.Power = power;
    }

    public string BenderName
    {
        get { return this.benderName; }
        set { this.benderName = value; }
    }
}

