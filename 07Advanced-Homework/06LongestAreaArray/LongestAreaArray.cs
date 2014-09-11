using System;
using System.Collections.Generic;
using System.Linq;


    class LongestAreaArray
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());
            int curCounter = 0; 
            int bigCounter = 0;
            string[] input = new string[n+1];
            input[0] = null;
            string repStr = input[0];

            for (int i = 1; i < n+1; i++)
            {
                input[i] = Console.ReadLine();
               
                if (input[i] == input[i-1])
                {
                    curCounter++;
                }
                else 
                {
                    if (curCounter > bigCounter)
                    {
                        repStr = input[i];
                        bigCounter = curCounter;
                    }
                    curCounter = 0;
                }
                if (curCounter > bigCounter)
                {
                    repStr = input[i];
                    bigCounter = curCounter;
                }
            }
            bigCounter++;
            Console.WriteLine("{0}", bigCounter);
            for (int i = 0; i < bigCounter; i++)
            {
                Console.WriteLine(repStr);
            }
        }
    }
