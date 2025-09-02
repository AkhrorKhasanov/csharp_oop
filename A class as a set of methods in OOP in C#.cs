using System;
class ArraySumHelper
{
    public double getAvg1(int[] arr)
    {
        return this.getSum(arr, 1);
    }
    public double getAvg2(int[] arr)
    {
        return this.calcSqrt(this.getSum(arr, 2), 2);
    }
    public double getAvg3(int[] arr)
    {
        return this.calcSqrt(this.getSum(arr, 3), 3);
    }
    public double getAvg4(int[] arr)
    {
        return this.calcSqrt(this.getSum(arr, 4), 4);
    }
    private double getSum(int[] arr, int n)
    {

        double c = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            c += Math.Pow(arr[i], n);
        }
        return c;
    }
    private double calcSqrt(double n, int p)
    {
        return Math.Pow(n, 1.0 / p);
    }
}

class Program
{
    static void Main()
    {
        ArraySumHelper arraySumHelper = new ArraySumHelper();
        Console.WriteLine(arraySumHelper.getAvg1(new int[] { 1, 2, 3 }));
        Console.WriteLine(arraySumHelper.getAvg2(new int[] { 1, 2, 3 }));
        Console.WriteLine(arraySumHelper.getAvg3(new int[] { 1, 2, 3 }));
        Console.WriteLine(arraySumHelper.getAvg4(new int[] { 1, 2, 3 }));
    }
}