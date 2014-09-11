using System;
using System.Linq;



class CountOfLetters
{
    static void Main()
    {

        string inputNames = Console.ReadLine();
        string[] strNames = inputNames.Split(' ');

        string[] myNames = new string[strNames.Length];


        for (int i = 0; i < myNames.Length; i++)
        {
            myNames[i] = strNames[i];
        }
        Array.Sort(myNames);

        int counter = 1;
        string repName;
        for (int i = 0; i < myNames.Length; i++)
        {
            if (myNames[i] == "0")
            {
                continue;
            }
            for (int j = i + 1; j < myNames.Length; j++)
            {
                if (myNames[j] == "0")
                {
                    continue;
                }
                if (myNames[i] == myNames[j])
                {
                    counter++;
                    myNames[j] = "0";
                }

            }
            repName = myNames[i];
            Console.WriteLine("{0} -> {1}", repName, counter);
            counter = 1;
        }
    }
}

