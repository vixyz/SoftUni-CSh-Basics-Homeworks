using System;

    class MatrixNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int first = 1;
            for (int j = 0; j < n; j++)
            {
                for (int i = first; i < n + first; i++)
                {
                    Console.Write("{0} ", i);
                }
                first++;
                Console.WriteLine();
            }
        }
    }
