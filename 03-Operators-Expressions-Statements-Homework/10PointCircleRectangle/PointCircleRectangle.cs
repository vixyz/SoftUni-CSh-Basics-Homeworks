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
                const double circleRad = 1.5;
                Point myPoint;
                Point testPoint;
                myPoint.x = double.Parse(Console.ReadLine());
                myPoint.y = double.Parse(Console.ReadLine());               
                double cirDistance = Math.Sqrt(Math.Pow((myPoint.x-1), 2) + Math.Pow((myPoint.y-1), 2));
                if (cirDistance > circleRad || myPoint.y <= 1)
                {
                    Console.WriteLine("no");
                }
                else
                {
                    Console.WriteLine("yes");
                }
        }
    }

