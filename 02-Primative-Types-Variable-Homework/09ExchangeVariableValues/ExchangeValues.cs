using System;



    class ExchangeValues
    {
        static void Main(string[] args)
        {

            int a = 5;
            int b = 10;
            Console.WriteLine("Before exchange: \n a = {0} \n b = {1}",a,b);

            int c = a;
            a = b;
            b = c;
            Console.WriteLine("After exchange: \n a = {0} \n b = {1}", a, b);

        }
    }

