using System;


class FourDigitNumber
{
    static void Main()
    {
        Console.WriteLine("Choose your number with 4 digits");
        int num = int.Parse(Console.ReadLine());
        int a, b, c, d;


        a = num / 1000;
        b = (num / 100) - 10 * a;
        c = (num / 10) - 10 * b - 100 * a;
        d = num - 10 * c - 100 * b - 1000 * a;

        /* Same as: 
          
           a = num / 1000;
           b = (num / 100) % 10;
           c = (num / 10) % 10;
           d = num % 10; */


        Console.WriteLine(d + c + b + a);         // LOOK AT THIS

        Console.WriteLine("" + d + c + b + a);   // AND THIS   >> The reason why it's better to use Console.WriteLine("Some text {0} + {1} + {2} + {3}");

        Console.WriteLine("{0}{1}{2}{3}\n{1}{3}{2}{0}", d, a, b, c);
                                                

        if (a == 0)
        {
            Console.Clear();
            Console.WriteLine("The number cannot start with 0\n");
            Main();
        }


    }
}
