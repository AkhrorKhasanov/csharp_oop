using System;
using System.Collections.Generic;
class Arr
{
    private List<int> numbers = new List<int>();
    public Arr(List<int> nums)
    {
        this.numbers = nums;
    }
    public void add(int n)
    {
        this.numbers.Add(n);
    }
    public int getSum()
    {
        int c = 0;
        foreach (int ns in numbers)
        {
            c += ns;
        }
        return c;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine(new Arr(new List<int> { 1, 2, 3 }).getSum() + new Arr(new List<int> { 4, 5, 6 }).getSum());
    }
}