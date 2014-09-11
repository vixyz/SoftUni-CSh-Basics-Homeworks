using System;



class Program
{
    static void Main(string[] args)
    {

        int colour = 3;


        for (int i = 2; i < 15; i++)
        {
            for (colour = 3; colour < 7; colour++)
            {
                char symbol = Convert.ToChar(colour);
                switch (i)
                {

                    case 11:
                        Console.Write("J" + symbol); break;
                    case 12:
                        Console.Write("D" + symbol); break;
                    case 13:
                        Console.Write("K" + symbol); break;
                    case 14:
                        Console.Write("A" + symbol); break;
                    default:
                        Console.Write(i + "" + symbol); break;

                }
                Console.Write(" ");
            }
            Console.WriteLine();
        }

    }
}

