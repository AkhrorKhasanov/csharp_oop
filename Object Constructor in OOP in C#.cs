using System;
class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Salary { get; set; }
    public Employee(string name, int age, int salary)
    {
        this.Name = name;
        this.Age = age;
        this.Salary = salary;
    }

}

class Program
{
    static void Main()
    {
        Employee e1 = new Employee("Axror", 28, 1000);
        Employee e2 = new Employee("Mirkomil", 27, 2000);

        Console.WriteLine(e1.Salary + e2.Salary);
    }
}