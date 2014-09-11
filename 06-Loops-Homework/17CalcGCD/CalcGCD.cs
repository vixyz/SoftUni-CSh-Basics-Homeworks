using System;
using System.Linq;


class CalcGCD
{
    static void Main()
    {

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        
        if (a < b)
        {
            int c = a;
            a = b;
            b = c;
        }
        int add = a % b;
        while (add != 0)
        {        
            a = b;
            b = add;
            add = a % b;
        }
        Console.WriteLine(b);

    }
}