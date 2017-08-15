﻿public abstract class Food
{
    private int quantity;

    protected Food(int quantity)
    {
        this.quantity = quantity;
    }

    public int Quantity
    {
        get { return this.quantity; }
        set { this.quantity = value; }
    }
}

