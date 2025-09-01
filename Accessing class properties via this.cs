using System;
// class Employee
// {
//     public string Name { get; set; }
//     public int Age { get; set; }
//     public int Salary { get; set; }
//     public bool CheckAge()
//     {
//         if (this.Age > 18)
//         {
//             return true;
//         }
//         else
//         {
//             return false;
//         }
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Employee e1 = new Employee();
//         e1.Name = "Axror";
//         e1.Age = 28;
//         e1.Salary = 1000;

//         Employee e2 = new Employee();
//         e2.Name = "Mirkomil";
//         e2.Age = 27;
//         e2.Salary = 2000;

//         Console.WriteLine(e1.Salary + e2.Salary);
//     }
// }


// -------------------

// class User
// {
//     public string Name { get; set; }
//     public int Age { get; private set; }
//     public void SetAge(int age)
//     {
//         if (age >= 18)
//         {
//             this.Age = age;
//         }
//     }

// }

// class Program
// {
//     static void Main()
//     {
//         User u1 = new User();
//         u1.Name = "Axror";
//         u1.SetAge(28);
//         Console.WriteLine(u1.Age);
//         u1.SetAge(30);
//         Console.WriteLine(u1.Age);
//         u1.SetAge(15);
//         Console.WriteLine(u1.Age);

//     }
// }

// -------------------

// class Employee
// {
//     public string Name { get; set; }
//     public int Salary { get; set; }

//     public void DoubleSalary()
//     {
//         this.Salary = this.Salary * 2;
//     }
// }

// -------------------

class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }
    public int GetSquare()
    {
        return this.Width * this.Height;
    }
    public int GetPerimeter()
    {
        return 2 * (this.Width + this.Height);
    }
}