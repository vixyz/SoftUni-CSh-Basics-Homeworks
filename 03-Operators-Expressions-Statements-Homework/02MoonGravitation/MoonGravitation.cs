using System;


    class MoonGravitation
    {
        static void Main()
        {
            Console.Write("Your weight on the Earth: ");
            double weightE = double.Parse(Console.ReadLine());
            const double moonGr = 0.17;
            Console.WriteLine("\nYour Moon-weight is " + weightE*moonGr + " kg\n");
            
        }
    }

