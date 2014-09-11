using System;

    class Rectangles
    {
        static void Main()
        {

            Console.Write("Rectangles Perimeter and Area\n\nWidth: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Perimeter = " + 2*(width+height) + "\nArea = " + width*height);

        }
    }

