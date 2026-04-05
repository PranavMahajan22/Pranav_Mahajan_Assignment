using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    // Employee ID property
    public int Id { get; set; }

    // Employee Name property
    public string Name { get; set; }

    // Employee Salary property
    public double Salary { get; set; }
}

class Question4_LINQ
{
    static void Main()
    {
        // Create and initialize a list of employees
        List<Employee> employees = new List<Employee>()
        {
            new Employee { Id = 1, Name = "Amit", Salary = 40000 },
            new Employee { Id = 2, Name = "Sneha", Salary = 60000 },
            new Employee { Id = 3, Name = "Rahul", Salary = 75000 }
        };

        // LINQ Query Syntax
        // Filter employees whose salary is greater than 50,000
        var result = from emp in employees
                     where emp.Salary > 50000
                     select emp;

        foreach (var emp in result)
        {
            Console.WriteLine($"{emp.Id} - {emp.Name} - {emp.Salary}");
        }
    }
}