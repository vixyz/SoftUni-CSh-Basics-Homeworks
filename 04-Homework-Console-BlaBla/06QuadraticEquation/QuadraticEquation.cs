using System;

class QuadraticEquation
    {
        static void Main()
        {

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double xOne, xTwo;
            double dis = Math.Pow(b, 2) - 4 * a * c;
            if (dis<0 )
            {
                Console.WriteLine("no real roots");
            }
            else
            {
                xOne = (-b + Math.Sqrt(dis)) / (2 * a);

                xTwo = (-b - Math.Sqrt(dis)) / (2 * a);
                Console.WriteLine("x = {0} \nx = {1}",xOne,xTwo);
            }
        }
    }

