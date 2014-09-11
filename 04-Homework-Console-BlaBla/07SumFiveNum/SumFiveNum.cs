using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SumFiveNum
{
    static void Main()
    {

        string input = Console.ReadLine();
        string[] numsRead = input.Split(' ');
        double[] num = new double[numsRead.Length];

        for (int i = 0; i < num.Length; i++)
        {
            num[i] = double.Parse(numsRead[i]);
        }
        Console.WriteLine(num.Sum());
    }
}
