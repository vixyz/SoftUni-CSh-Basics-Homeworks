using System;

class PrimeNumber
{
    static void Main()
    {
     

            int num = byte.Parse(Console.ReadLine());
            int div;
            int counter = 0;

            for (div = num - 1; div > 1; div--)
            {
                if (num % div == 0)
                {
                    counter++;
                }
            }
            if (counter >= 1)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("right");
            }

        }
    }
