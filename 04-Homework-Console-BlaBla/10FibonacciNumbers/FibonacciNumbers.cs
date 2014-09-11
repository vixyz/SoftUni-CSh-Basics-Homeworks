/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08SumOneN
{
    class SumOneN
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
                Console.Beep();
            }

        }
    }
}*/
using System;

    class SumNumbers
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int firstNum = 0; 
            int secNum = 1;
            if (n >= 2)
            {
                for (int i = 0; i < n; i++)
                {                   
                    sum = firstNum + secNum;
                    Console.Write("{0}  ",firstNum);
                    firstNum = secNum;
                    secNum = sum;
                }
                Console.WriteLine();
            }            
        }
    }
