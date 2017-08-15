﻿using System;

public class Box
{
    private double length;
    private double width;
    private double height;

    public Box(double length, double width, double height)
    {
        this.Length = length;
        this.Width = width;
        this.Height = height;
    }

    private double Length
    {
        set
        {
            if (value < 1)
            {
                throw new ArgumentException($"{nameof(Length)} cannot be zero or negative.");
            }
            this.length = value;
        }
    }

    private double Width
    {
        set
        {
            if (value < 1)
            {
                throw new ArgumentException($"{nameof(Width)} cannot be zero or negative.");
            }
            this.width = value;
        }
    }

    private double Height
    {
        set
        {
            if (value < 1)
            {
                throw new ArgumentException($"{nameof(Height)} cannot be zero or negative.");
            }
            this.height = value;
        }
    }
    public double Volume()
    {
        var result = this.length * this.width * this.height;
        return result;
    }

    public double LateralSurfaceArea()
    {
        return 2 * (this.length * this.height) + 2 * (this.width * this.height);
    }

    public double SurfaceArea()
    {
        return 2 * (this.length * this.width) +
               2 * (this.length * this.height) +
               2 * (this.width * this.height);
    }
}

