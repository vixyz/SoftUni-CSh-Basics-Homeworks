using System;

    class RandomInRange
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            Random mySequence = new Random();
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0,3}",mySequence.Next(min,max));
            }
            Console.WriteLine();
        }
    }
