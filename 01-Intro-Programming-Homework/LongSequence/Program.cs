using System;


class Program
{
    static void Main(string[] args)
    {
        Console.SetWindowSize(170, 45); // resizing the console window

        int a = 1; //chooce 1 because the sequence starts from 2 = 1 + 1
        int n = 0;
        for (int i = 0; i < 1000; i++) // calls 1000 numbers
        {
            n++;
            a++;
            if (n%25==0) // formats the results by making a new line for every 25 members of the sequence
            {
                Console.Write("\n");
            }
            if (a % 2 == 0)
            {
                Console.Write("   "+a); // even numbers
            }
            else
            {
                Console.Write("   "+"-"+a); // odd numbers
            }
            
           
        }
        Console.WriteLine();
    }
}
