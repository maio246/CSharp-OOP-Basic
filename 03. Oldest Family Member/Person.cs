﻿public class Person
{
    private string name;
    private int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public int Age
    {
        get { return age; }
        set { this.age = age; }
    }

    public string Name
    {
        get { return name; }
        set { this.name = name; }
    }
}

