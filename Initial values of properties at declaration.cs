using System;
using System.Collections.Generic;
class Arr
{
    private List<int> numbers = new List<int>();
    public void add(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            this.numbers.Add(nums[i]);
        }
    }
    public int getSum()
    {
        int c = 0;
        foreach (int num in numbers)
        {
            c += num;
        }
        return c;
    }
    public double getAvg()
    {
        return this.getSum() / (1.0 * numbers.Count);
    }
}

class Program
{
    static void Main()
    {
        Arr arr = new Arr();
        arr.add(new int[] {1, 2, 3});
        arr.add(new int[] {4, 5, 6});

        Console.WriteLine(arr.getAvg());
    }
}