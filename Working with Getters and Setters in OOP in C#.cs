using System;
class Employee
{
    private string name;
    private int age;
    private int salary;
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
        if (this.isAgeCorrect(age))
        {
            this.age = age;
        }
    }
    public int getSalary()
    {
        return $"{this.salary}$";
    }
    public void setSalary(int salary)
    {
        this.salary = salary;
    }
    private bool isAgeCorrect(int age)
    {
        if (age >= 1 && age <= 100)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}