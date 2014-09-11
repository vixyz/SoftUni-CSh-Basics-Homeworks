using System;


class NotDiviveSeven
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i < n+1; i++)
        {
            if (i%7==0 || i%3==0)
            {
                continue;
            }
            Console.Write(i + " ");
        }

    }
}

