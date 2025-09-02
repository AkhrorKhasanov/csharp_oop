using System;
using System.Collections.Generic;
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

class Programmer : Employee
{
    private List<string> langs = new List<string>();
    public void getLangs()
    {
        foreach (string lang in this.langs)
        {
            Console.WriteLine(lang);
        }
    }
    public void setLang(string lang)
    {
        this.langs.Add(lang);
    }
}

class Driver : Employee
{
    private int experience;
    private string category;
    public int getExperience()
    {
        return this.experience;
    }
    public void setExperience(int experience)
    {
        this.experience = experience;
    }
    public string getCategory()
    {
        return this.category;
    }
    public void setCategory(string category)
    {
        this.category = category;
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

        Programmer programmer = new Programmer();
        programmer.setLang("Uzbek");
        programmer.setLang("English");
        programmer.setLang("Russian");

        programmer.getLangs();

        Driver driver = new Driver();
        driver.setExperience(5);
        driver.setCategory("A");

        Console.WriteLine(driver.getExperience());
        Console.WriteLine(driver.getCategory());
    }
}