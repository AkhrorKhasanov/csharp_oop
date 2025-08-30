using System;

class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public decimal Salary { get; set; }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee();
        emp.Name = "John";
        emp.Age = 25;
        emp.Salary = 1000.25m;

        Console.WriteLine($"Name: {emp.Name}");
        Console.WriteLine($"Age: {emp.Age}");
        Console.WriteLine($"Salary: {emp.Salary}");
    }
}