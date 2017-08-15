using System;

public class Person
{
    private string firstName;
    private string secondName;
    private int age;
    private double salary;


    public override string ToString()
    {
        return $"{this.firstName} {this.secondName} get {this.salary} leva";
    }

    public Person(string firstName, string secondName, int age, double salary)
    {
        this.FirstName = firstName;
        this.SecondName = secondName;
        this.Age = age;
        this.Salary = salary;
    }

    public string FirstName
    {
        get { return this.firstName; }
        set
        {

            if (value.Length < 3)
            {
                new ArgumentException("First name cannot be less than 3 symbols");
            }

            this.firstName = value;
        }
    }

    public string SecondName
    {
        get { return this.secondName; }
        set
        {
            if (value.Length < 3)
            {
                new ArgumentException("Last name cannot be less than 3 symbols");
            }
            this.secondName = value;
        }
    }

    public int Age
    {
        get { return this.age; }
        set
        {
            if (value < 1)
            {
                new ArgumentException("Age cannot be zero or negative integer");
            }
            this.age = value;
        }
    }

    public double Salary
    {
        get { return this.salary; }
        set
        {
            if (value < 460)
            {
                new ArgumentException("Salary cannot be less than 460 leva");
            }


        }
    }

    public void IncreaseSalary(double percent)
    {
        if (this.age < 30)
        {
            this.salary += this.salary * percent / 200;
        }
        else
        {
            this.salary += this.salary * percent / 100;

        }
    }
}

