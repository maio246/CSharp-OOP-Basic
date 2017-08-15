using System;
using System.Collections.Generic;

public class Person
{
    private string name;
    private decimal money;
    private List<string> bag;

    public Person(string name, decimal money)
    {
        this.Name = name;
        this.Money = money;
        this.bag = new List<string>();
    }

    public string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannot be empty");
            }
            this.name = value;
        }
    }

    public decimal Money
    {
        get { return this.money; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            this.money = value;
        }
    }

    public List<string> Bag
    {
        get => bag;
        set => bag = value;
    }

    public void AddToCart(Product product)
    {
        if (this.money >= product.Cost)
        {
            bag.Add(product.Name);
            this.money = this.money - product.Cost;
        }
        else
        {
            throw new ArgumentException($"{this.name} can't afford {product.Name}");
        }
    }
}

