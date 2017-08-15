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
        this.firstName = firstName;
        this.secondName = secondName;
        this.age = age;
        this.salary = salary;
    }

    public string FirstName{ get { return this.firstName; } }

    public string SecondName { get { return this.secondName; } }

    public int Age { get { return this.age; } }

    public double Salary { get { return this.age; } }

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

