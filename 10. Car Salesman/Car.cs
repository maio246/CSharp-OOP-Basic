public class Car
{
    private string model;
    private string engine;
    private string weigth;
    private string color;

    public Car(string model, string engine)
    {
        this.model = model;
        this.engine = engine;
        this.weigth = "n/a";
        this.color = "n/a";
    }

    public string Model { get { return this.model; } }
    public string Engine { get { return this.engine; } }

    public string Weigth
    {
        get { return this.weigth; }
        set { this.weigth = value; }
    }

    public string Color
    {
        get { return this.color; }
        set { this.color = value; }
    }
    

}

