using System;

class OddOrEvenProduct
{
    static void Main()
    {

        string input = Console.ReadLine();
        string[] step = input.Split(' ');
        int[] myNumbers = new int[step.Length];
        int oddProd = 1; int evenProd = 1;
        for (int i = 0; i < step.Length; i++)
        {
            myNumbers[i] = int.Parse(step[i]);
        }
        for (int i = 0; i < myNumbers.Length; i++)
        {
            oddProd *= myNumbers[i];
            if (i < (myNumbers.Length - 1))
            {
                i++;
                evenProd *= myNumbers[i];
            }
        }
        if (oddProd == evenProd)
        {
            Console.WriteLine("yes\nproduct = {0}",oddProd);
        }
        else
        {
            Console.WriteLine("no\nodd_product = {0}\neven_product = {1}",oddProd,evenProd);
        }
    }
}
