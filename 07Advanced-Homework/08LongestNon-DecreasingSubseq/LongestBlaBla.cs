using System;
using System.Collections.Generic;
using System.Linq;


class LongestBlaBla


{
    static void Main()
    {

        string input = Console.ReadLine();
        string[] numsRead = input.Split(' ');
        int[] num = new int[numsRead.Length];

        for (int i = 0; i < num.Length; i++)
        {
            num[i] = int.Parse(numsRead[i]);
        }

        int myCounter = 0;
        int curCounter = 0;

        List<int> tempSeqList = new List<int>();

        tempSeqList.Add(num[0]);

        List<int> bigList = new List<int>();
        

        for (int i = 0; i < num.Length; i++)
        {
            if (i < num.Length-1)
            {
                if (num[i] < num[i + 1])
                {
                    tempSeqList.Add(num[i + 1]);
                    curCounter++;
                }
                else
                {
                    if (curCounter > myCounter)
                    {
                        myCounter = curCounter;
                        curCounter = 0;
                        
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else
            {
                break;
            }
        }
    }
}

