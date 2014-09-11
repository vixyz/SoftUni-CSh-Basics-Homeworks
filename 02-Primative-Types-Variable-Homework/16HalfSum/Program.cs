using System;

class HalfSum
{
    static void Main()
    {

        int n, m, sumA, sumB = 0;
        n = int.Parse(Console.ReadLine());


        for (int i = 0; i < n; i++)
        {
            m = int.Parse(Console.ReadLine());

            sumA = sumA + m;

        }

        Console.WriteLine("Hi" + sumA);


    }
}

