using System;
class Employee
{
    private string name;
    private string surname;
    private int salary;
    public Employee(string name, string surname, int salary)
    {
        this.name = name;
        this.surname = surname;
        this.salary = salary;
    }
    public string getName()
    {
        return this.name;
    }
    public string getSurname()
    {
        return this.surname;
    }
    public int getSalary()
    {
        return this.salary;
    }
    public void setSalary(int salary)
    {
        this.salary = salary;
    }
}