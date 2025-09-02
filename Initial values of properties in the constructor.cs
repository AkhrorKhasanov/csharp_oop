using System;
class Student
{
    private string name;
    private int course;
    public Student(string name)
    {
        this.name = name;
        this.course = 1;
    }
    public string getName()
    {
        return this.name;
    }
    public int getCourse()
    {
        return this.course;
    }
    public void transferToNextCourse()
    {
        if (this.course < 4)
        {
            this.course++;
        }
    }
}