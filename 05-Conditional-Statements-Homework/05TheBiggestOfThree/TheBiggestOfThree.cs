using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TheBiggestOfThree
{
    static void Main(string[] args)
    {

        double[] num = new double[3];
        for (int i = 0; i < num.Length; i++)
        {
            num[i] = double.Parse(Console.ReadLine());
        }
        Console.WriteLine(num.Max());

    }
}

