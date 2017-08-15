using System;
using System.Collections.Generic;
using System.Linq;

public static class Company
{
    public static void Main()
    {
        var count = int.Parse(Console.ReadLine());

        var employees = new List<Employee>();
        for (int i = 0; i < count; i++)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var name = input[0];
            var salary = double.Parse(input[1]);
            var position = input[2];
            var department = input[3];

            var employee = new Employee(name, salary, position, department);

            int age;

            if (input.Length > 4)
            {

                if (int.TryParse(input[4], out age))
                {
                    employee.Age = age;
                }
                else
                {
                    employee.Email = input[4];
                }
            }

            if (input.Length > 5)
            {
                employee.Age = int.Parse(input[5]);
            }

            employees.Add(employee);
        }

        var result = employees
            .GroupBy(e => e.Department)
            .Select(gr => new
            {
                Name = gr.Key,
                AverageSalary = gr.Average(e => e.Salary),
                employees = gr

            })
            .OrderByDescending(em => em.AverageSalary)
            .FirstOrDefault();

        Console.WriteLine($"Highest Average Salar   y: {result.Name}");

        foreach (var employee in result.employees.OrderByDescending(e => e.Salary))
        {
            Console.WriteLine(employee.PrintEmployee());
        }
    }
}