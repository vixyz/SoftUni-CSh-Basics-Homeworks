using System;

class CalcMoreFact
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());  //1<k<n<100
        double result = 1;
        for (int i = Math.Min(n, k) + 1; i <= Math.Max(n, k); i++)
        {
            result *= i;
        }
        for (int i = 1; i < Math.Abs(n - k)+1; i++)
        {
            result /= i;
        }
        Console.WriteLine(result);
    }
}
