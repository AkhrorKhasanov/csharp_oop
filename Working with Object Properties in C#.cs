using System;

class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Salary { get; set; }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee();
        emp.Name = "John";
        emp.Age = 25;
        emp.Salary = 1000;

        Employee emp2 = new Employee();
        emp2.Name = "Eric";
        emp2.Age = 26;
        emp2.Salary = 2000;

        Console.WriteLine($"Sum of the salaries: {emp.Salary + emp2.Salary}");
        Console.WriteLine($"Sum of the ages: {emp.Age + emp2.Age}");

    }
}