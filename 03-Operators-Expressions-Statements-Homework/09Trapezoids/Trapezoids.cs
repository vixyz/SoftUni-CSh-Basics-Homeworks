using System;

    class Trapezoids
    {
        static void Main()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("h = ");
            int h = int.Parse(Console.ReadLine());
            int trapArea = (a + b) * h / 2;
            Console.WriteLine("Trapezoid's area = " + trapArea);
        }
    }
