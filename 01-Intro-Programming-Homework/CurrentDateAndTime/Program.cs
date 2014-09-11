using System;
using System.Threading;


    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine(DateTime.Now);
            }
        }
    }
