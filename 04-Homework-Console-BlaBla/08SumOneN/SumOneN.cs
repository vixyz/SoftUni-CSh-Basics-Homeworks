﻿using System;
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
}