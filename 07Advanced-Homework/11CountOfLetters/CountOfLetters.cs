using System;
using System.Linq;



class CountOfLetters
{
    static void Main()
    {
            
        string inputLetters = Console.ReadLine();
        string[] strLetters = inputLetters.Split(' ');

        char[] myLetter = new char[strLetters.Length];


        for (int i = 0; i < myLetter.Length; i++)
        {
            myLetter[i] = char.Parse(strLetters[i]);
        }
        Array.Sort(myLetter);

        int counter = 1;
        char repLetter ;
        for (int i = 0; i < myLetter.Length; i++)
        {
            if (myLetter[i] == '0')
            {
                continue;
            }
            for (int j = i+1; j < myLetter.Length; j++)
			{
                if (myLetter[j] == '0' )
                {
                    continue;
                }
                if (myLetter[i] == myLetter[j])
                {
                    counter++;
                    myLetter[j] = '0';
                }

			}
            repLetter = myLetter[i];
            Console.WriteLine("{0} -> {1}", repLetter,counter);
            counter = 1;
        }
    }
}

