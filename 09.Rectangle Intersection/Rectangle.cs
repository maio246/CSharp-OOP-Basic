using System.Collections.Generic;

public class Rectangle
{
    private string id;
    private double width;
    private double heigth;
    private double x;
    private double y;

    public Rectangle(string id, double width, double heigth, double x, double y)
    {
        this.id = id;
        this.width = width;
        this.heigth = heigth;
        this.x = x;
        this.y = y;
    }

    public string Id { get { return this.id; } }
    public double Width { get { return this.width; } }
    public double Heigth { get { return this.heigth; } }
    public double X { get { return this.x; } }
    public double Y{ get { return this.y; } }

    public bool IntersectsWith(Rectangle rectangle)
    {
        if (this.x <= rectangle.x + rectangle.width 
            && this.x + this.width >= rectangle.x 
            && this.y <= rectangle.y + rectangle.heigth 
            && this.y + this.heigth >= rectangle.y)
        {
            return true;
        }
        return false;
    }
}

