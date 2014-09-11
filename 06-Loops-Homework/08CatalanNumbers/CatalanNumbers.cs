using System;


class CatalanNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double result = 1;
        double div = 1;

        for (int i = n+1; i < (2*n)+1 ; i++)
        {
            result *= i;
        }
        for (int i = 1; i < n+2; i++)
        {
            div *= i;
        }
        Console.WriteLine(result/div);
    }
}

