public class Employee
{
    private string name { get; set; }
    private double salary { get; set; }
    private string position { get; set; }
    private string department { get; set; }
    private string email { get; set; }
    private int age { get; set; }

    public Employee(string name, double salary, string position, string department)
    {
        this.name = name;
        this.salary = salary;
        this.position = position;
        this.department = department;
        this.age = -1;
        this.email = "n/a";
    }

    public int Age
    {
        set { this.age = value; }
    }

    public string Email
    {
        set { this.email = value; }
    }

    public string Department { get { return this.department; }}

    public double Salary { get { return this.salary; } }

    public string PrintEmployee()
    {
        return $"{this.name} {this.salary:f2} {this.email} {this.age}";
    }
}
