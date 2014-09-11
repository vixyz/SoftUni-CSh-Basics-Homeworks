using System;


    class Program
    {
        static void Main(string[] args)
        {

            int a = 1; //chooce 1 because the sequence starts from 2 = 1 + 1
            int n = 0;
            for (int i = 0; i < 10; i++) // calls 10 numbers
            {
                n++;
                a++;
                if (a%2==0)
                {
                    Console.WriteLine(n+">    "+a); // even numbers
                }
                else
                {
                    Console.WriteLine(n+">   "+"-"+a); // odd numbers
                }
                

            }
        }
    }
