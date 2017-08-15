using System;
using System.Reflection;

public static class PersonClass
{
    public static void Main()
    {
        Type personType = typeof(Person);
        FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
        Console.WriteLine(fields.Length);

    }
}


