using System;

class PrintTable
{
    static void Main()
    {
        int counter = 0;
        int n = 0;
        char symbol = Convert.ToChar(counter);
        for (counter = 0; counter < 255; counter++) 
        {
            n++;           
            if (n % 25 == 0) // formats the results by making a new line for every 25 members of the table members
            {
                Console.Write("\n");
            }
            symbol = Convert.ToChar(counter);
            Console.Write(symbol + "  ");
        } 
    }
}