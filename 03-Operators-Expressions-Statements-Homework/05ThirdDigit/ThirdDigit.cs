using System;

class ThirdDigit
{
    static void Main()
    {

        int num = int.Parse(Console.ReadLine());
        int checkNum = num / 100;

        if (checkNum%10==7)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }

       

    }
}

