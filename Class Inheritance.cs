using System;
class User
{
    private string name;
    private int age;
    public string getName()
    {
        return this.name;
    }
    public void setName(string name)
    {
        this.name = name;
    }
    public int getAge()
    {
        return this.age;
    }
    public void setAge(int age)
    {
        this.age = age;
    }
}

class Employee : User
{
    private int salary;
    public int getSalary()
    {
        return this.salary;
    }
    public void setSalary(int salary)
    {
        this.salary = salary;
    }
}

class Program
{
    static void Main()
    {
        Employee employee = new Employee();

        employee.setSalary(1000);
        employee.setName("Axror");
        employee.setAge(28);

        Console.WriteLine(employee.getSalary());
        Console.WriteLine(employee.getName());
        Console.WriteLine(employee.getAge());
    }
}