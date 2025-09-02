using System;
using System.Collections.Generic;
class Arr
{
    private List<int> numbers = new List<int>();
    public Arr add(int num)
    {
        this.numbers.Add(num);
        return this;
    }
    public Arr push(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            this.numbers.Add(nums[i]);
        }
        return this;
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
        int res = (new Arr()).add(1).add(2).push(new int[] { 1, 2, 3 }).add(5).push(new int[] { 2, 3 }).add(10).getSum();
        Console.WriteLine(res);
    }
}