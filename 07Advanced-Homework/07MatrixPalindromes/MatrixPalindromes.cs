using System;

    class MatrixPalindromes
    {
        static void Main()
        {
            // Sorry but I am not good with the Multidimensional arrays
            string input = Console.ReadLine();
            string[] numsRead = input.Split(' ');
            int[] num = new int[numsRead.Length];

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(numsRead[i]);
            }

            int r = num[0];
            int c = num[1];

           char row = (char)97;
           char col = (char)97;

           
          
           for (int i = 0; i < r; i++)
           {
              
               for ( int j = 0 ; j < c; j++)
               {
                   Console.Write("{0}{1}{0} ", row, col);
                   col++;
               }
               //col = (char)(97+z);
               row++; col = row;
             
               Console.WriteLine();
               
           }


        }
    }

