public class Person
{
    private string firstName;
    private string secondName;
    private int age;

    public override string ToString()
    {
        return $"{this.firstName} {this.secondName} is a {this.age} years old";
    }

    public Person(string firstName, string secondName, int age)
    {
        this.firstName = firstName;
        this.secondName = secondName;
        this.age = age;
    }

    public string FirstName{ get { return this.firstName; } }

    public string SecondName { get { return this.secondName; } }

    public int Age { get { return this.age; } }
}

