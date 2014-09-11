using System;

class CalcSomethingLong
{
    static void Main()
    {
        Console.WriteLine("Enter value for n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for x:");
        int x = int.Parse(Console.ReadLine());
        int fac = 1;
        double sum = 0;
        for (int i = 1; i < n+1; i++)
        {
            fac *= i;
            sum += fac / (Math.Pow(x, i));                
        }
        sum++;
        Console.WriteLine("S = {0:0.00000}", sum);
    }
}
