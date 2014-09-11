using System;
using System.Linq;



class MinMaxSumAver
{
    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        int[] seqence = new int[n];
      
        for (int i = 0; i < n; i++)
        {
            seqence[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("min = {0} \nmax = {1} \nsum = {2} \navg = {3:0.00}",seqence.Min(),seqence.Max(), seqence.Sum(), seqence.Average());
    }
}
