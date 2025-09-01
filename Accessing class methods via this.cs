using System;
class User
{
    public string Name { get; set; }
    public int Age { get; private set; }
    public bool IsAgeCorrect(int age)
    {
        if (age >= 18 && age <= 60)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void SetAge(int age)
    {
        if (this.IsAgeCorrect(age))
        {
            this.Age = age;
        }
    }
    public void AddAge(int years)
    {
        int NewAge = this.Age + years;
        if (this.IsAgeCorrect(NewAge))
        {
            this.Age = NewAge;
        }
    }
    public void SubAge(int years)
    {
        int NewAge = this.Age - years;
        if (this.IsAgeCorrect(NewAge))
        {
            this.Age = NewAge;
        }
    }
}

class Program
{
    static void Main()
    {
        User user = new User();
        user.SetAge(30);
        Console.WriteLine(user.Age);
        user.SetAge(10);
        Console.WriteLine(user.Age);
        user.AddAge(10);
        Console.WriteLine(user.Age);
        user.AddAge(80);
        Console.WriteLine(user.Age);
        user.SubAge(15);
        Console.WriteLine(user.Age);
        user.SubAge(20);
        Console.WriteLine(user.Age);
    }
}