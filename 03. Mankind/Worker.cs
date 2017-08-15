using System;
using System.Text;

public class Worker : Human
{
    private decimal weekSalary;
    private decimal hoursPerDay;
    private decimal salaryPerHour;

    public Worker(string firstName, string lastName, decimal weekSalary, decimal hoursPerDay) 
        : base (firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.HoursPerDay = hoursPerDay;
        this.salaryPerHour = weekSalary / (hoursPerDay * 5);
    }

    public decimal HoursPerDay
    {
        get { return this.hoursPerDay; }
        set
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");

            }
            this.hoursPerDay = value;
        }
    }

    public decimal WeekSalary
    {
        get { return this.weekSalary; }
        set
        {
            if (value <= 10)
            {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }
            this.weekSalary = value;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"First Name: {this.FirstName}");
        sb.AppendLine($"Last Name: {this.LastName}");
        sb.AppendLine($"Week Salary: {this.WeekSalary:f2}");
        sb.AppendLine($"Hours per day: {this.hoursPerDay:f2}");
        sb.AppendLine($"Salary per hour: {this.salaryPerHour:f2}");

        return sb.ToString();

    }
}

