using System;

    class PrimeChecker
    {
        static void Main()
        {


            // This Problem is wrong because we have to use int input but in the examples 117342557809 is a long type number


            long n = long.Parse(Console.ReadLine());

            bool ifPrime = IsPrime(n);
           
                Console.WriteLine(ifPrime);
           
        }

        private static bool IsPrime(long n)
        {
            bool isPrime = true;

            for (long i = 2L; i < n; i++)
            {
                if (n % i == 0L)
                {
                    isPrime = false;
                    break;
                }
            }
            if (n == 0L)
            {
                isPrime = false;
            }
            return isPrime;
        }
    }

