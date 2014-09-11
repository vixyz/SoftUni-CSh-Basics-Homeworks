using System;

class FibonacciNumbers
{

    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Fib(n));
    }


    private static int Fib(int n)
    {
        int a = 0;
        int b = 1;
        int c = 1;

        for (int i = 0; i < n; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }
        return c;
    }

}
