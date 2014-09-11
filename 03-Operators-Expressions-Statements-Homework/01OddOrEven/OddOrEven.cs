using System;

class OddOrEven
{
    static void Main()
        {
            while (true)   // Disables break
            {
                Console.Write("Number: ");
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0 || num == 0)
                {
                    Console.Write("  false\n\n");
                }
                else
                {
                    Console.Write("  right\n\n");
                }               
            }       
        }
}

