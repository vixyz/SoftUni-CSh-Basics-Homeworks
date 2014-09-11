using System;

class CalculateFactoriels
{
    static void Main(string[] args)
    {
            
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine()); //1<k<n<100
        int result = 1;        
        for (int i = Math.Min(n,k) + 1 ; i <= Math.Max(n,k); i++) 
        {
            result *= i;
        }
        Console.WriteLine(result);
    }
}

