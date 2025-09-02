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

class Student : User
{
    private int course;
    public int getCourse()
    {
        return this.course;
    }
    public void setCourse(int course)
    {
        this.course = course;
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

        Student student = new Student();

        student.setCourse(3);
        student.setName("Mirkomil");
        student.setAge(25);

        Console.WriteLine(student.getCourse());
        Console.WriteLine(student.getName());
        Console.WriteLine(student.getAge());
    }
}