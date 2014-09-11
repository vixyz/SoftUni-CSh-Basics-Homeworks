using System;

class Program
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a != b && a != c && b != c)
        {
            if (a > b && b > c)
            {
                Console.WriteLine("{0} {1} {2}", a, b, c);
            }
            if (a > b && c > b)
            {
                Console.WriteLine("{0} {1} {2}", a, c, b);
            }
            if (b > a && a > c)
            {
                Console.WriteLine("{0} {1} {2}", b, a, c);
            }
            if (b > c && c > a)
            {
                Console.WriteLine("{0} {1} {2}", b, c, a);
            }
            if (c > a && a > b)
            {
                Console.WriteLine("{0} {1} {2}", c, a, b);
            }
            if (c > b && b > a)
            {
                Console.WriteLine("{0} {1} {2}", c, b, a);
            }
        }
        if (a == b || b == c || a == c)
        {
            if (a == b && a > c)
            {
                Console.WriteLine("{0} {1} {2}", a, b, c);
            }
            if (a == b && a < c)
            {
                Console.WriteLine("{0} {1} {2}", c, a, b);
            }
            if (a == c && a < b)
            {
                Console.WriteLine("{0} {1} {2}", b, a, c);
            }
            if (a == c && a > b)
            {
                Console.WriteLine("{0} {1} {2}", a, c, b);
            }
            if (b == c && b > a)
            {
                Console.WriteLine("{0} {1} {2}", c, b, a);
            }
            if (b == c && a > b)
            {
                Console.WriteLine("{0} {1} {2}", a, b, c);
            }
        }
    }
}




