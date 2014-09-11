using System;

class OddEvenSum
{
    static void Main()
    {

        int n, m;
        int sumA = 0;
        int sumB = 0;

        n = int.Parse(Console.ReadLine());


        for (int i = 0; i < n; i++)
        {
            m = int.Parse(Console.ReadLine());
            sumA += m;
            m = int.Parse(Console.ReadLine());
            sumB += m;
        }

        int diff = Math.Abs(sumA - sumB);

        if (sumA == sumB)
        {
            Console.WriteLine("Yes, sum={0}", sumA);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(diff));
        }
    }

}
