using System;


    class PointCircle
    {

        struct Point
        {
            public double x;
            public double y;
        };

        static void Main()
        {
            const double circleRad = 2.0; 
                        Point myPoint;
            myPoint.x = double.Parse(Console.ReadLine());
            myPoint.y = double.Parse(Console.ReadLine());             
            double distance = Math.Sqrt(Math.Pow(myPoint.x, 2) + Math.Pow(myPoint.y, 2));

            Console.WriteLine("Distance: " + distance);

            if (distance > circleRad)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }
        }
    }

