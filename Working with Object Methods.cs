using System;
// class User
// {
//     public string Name { get; set; }
//     public int Age { get; set; }
//     public string Show()
//     {
//         return "!!!";
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         User user = new User();
//         user.Name = "Axror";
//         user.Age = 28;

//         Console.WriteLine(user.Show());
//     }
// }


// ------------------

class User
{
    public string Name { get; set; }
    public int Age { get; set; }

    public string Show(string str)
    {
        return str + "!!!";
    }
}

class Program
{
    static void Main()
    {
        User user = new User();

        user.Name = "Mirkomil";
        user.Age = 27;

        Console.WriteLine(user.Show("Asliddin"));
    }
}