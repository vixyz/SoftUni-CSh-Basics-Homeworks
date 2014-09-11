using System;

    class IsDivided
    {
        static void Main()
        {
            int divObj = int.Parse(Console.ReadLine());
            if (divObj % 7 == 0 && divObj % 5 == 0)
            {
                Console.WriteLine("True");
            }
            else if (divObj == 0)
            {
                Console.WriteLine("False");  // if we don't check the zero-value of the number, the program will return true
            }
            else
            {
                Console.WriteLine("False");
            }

        
        }
    }
