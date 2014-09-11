using System;
using System.Collections.Generic;
using System.Linq;

    class PrimesInRange
    {
        static void Main()
        {
            // my code is not suitable for static List<int> Method including more rows
            int from = int.Parse(Console.ReadLine());
            int to = int.Parse(Console.ReadLine());

            List<int> myPrimeNum = CreatingList();
            int j = FindPrimesInRange(from, to, myPrimeNum);
            PrintPrimeNumList(myPrimeNum, j);
            Console.WriteLine();            
        }

        private static int FindPrimesInRange(int from, int to, List<int> myPrimeNum)
        {
            int j = 0;
            for (int i = from; i < to + 1; i++) // takes every i number from my range
            {
                if (i == 0 || i == 1) // remove 0 and 1 from the sequence
                {
                    continue;
                }
                int checkpoint = 0; // for every circle need a new zero-checkpoint
                for (int k = 2; k < i; k++) // checks every i number if prime
                {
                    if (i % k == 0)  // for every not prime number, checkpoint ++
                    {
                        checkpoint++;
                    }
                }
                if (checkpoint == 0) // adds every prime number to the list
                {
                    myPrimeNum.Add(i);
                    j++;
                }
            }
            return j;
        }

        private static List<int> CreatingList()
        {
            List<int> myPrimeNum = new List<int>();

            return myPrimeNum;
        }

        private static void PrintPrimeNumList(List<int> myPrimeNum, int j)
        {
            for (int i = 0; i < j; i++)
            {
                Console.Write(myPrimeNum[i]);
                if (i != j - 1)  //doesn't add " , " after the last number in the list
                {
                    Console.Write(", ");
                }
            }
        }
    }

