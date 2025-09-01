using System;
// class User
// {
//     public string Name { get; set; }
//     public int Age { get; private set; }
//     public void SetAge(int age)
//     {
//         if (this.IsAgeCorrect(age))
//         {
//             this.Age = age;
//         }
//     }
//     public void AddAge(int years)
//     {
//         int NewAge = this.Age + years;
//         if (IsAgeCorrect(NewAge))
//         {
//             this.Age = NewAge;
//         }
//     }
//     private bool IsAgeCorrect(int age)
//     {
//         if (age >= 18 && age <= 60)
//         {
//             return true;
//         }
//         else
//         {
//             return false;
//         }
//     }
// }

// -----------------

class Student
{
    public string Name { get; set; }
    public int Course { get; set; }
    public void TransferToNextCourse()
    {
        int NewCourse = this.Course + 1;
        if (IsCourseCorrect(NewCourse))
        {
            this.Course = NewCourse;
        }
    }
    private bool IsCourseCorrect(int course)
    {
        if (course > 0 && course < 5)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}