using System;
using System.Collections.Generic;
using System.Linq;



class RemoveNames
{
    static void Main()
    {
        List<string> FirstNameList;
        List<string> SecondNameList;
        InitialingLists(out FirstNameList, out SecondNameList);

        FindingRepetitiveNames(FirstNameList, SecondNameList);

        Output(FirstNameList);
    }

    private static void Output(List<string> FirstNameList)
    {

        for (int i = 0; i < FirstNameList.Count; i++)
        {
            if (FirstNameList[i] != null)
            {
                Console.Write("{0} ", FirstNameList[i]);
            }

        }

        Console.WriteLine();
    }

    private static void FindingRepetitiveNames(List<string> FirstNameList, List<string> SecondNameList)
    {
        for (int i = 0; i < SecondNameList.Count; i++)
        {
            for (int j = 0; j < FirstNameList.Count; j++)
            {

                if (FirstNameList[j] == SecondNameList[i])
                {
                    FirstNameList[j] = null;
                }
                else
                {
                    continue;
                }
            }
        }
    }

    private static void InitialingLists(out List<string> FirstNameList, out List<string> SecondNameList)
    {
        string inputFRow = Console.ReadLine();
        string[] fRow = inputFRow.Split(' ');
        FirstNameList = new List<string>();
        for (int i = 0; i < fRow.Length; i++)
        {
            FirstNameList.Add(fRow[i]);
        }
        string inputSRow = Console.ReadLine();
        string[] sRow = inputSRow.Split(' ');
        SecondNameList = new List<string>();
        List<string> OutputNameList = new List<string>();
        for (int i = 0; i < sRow.Length; i++)
        {
            SecondNameList.Add(sRow[i]);
        }
    }
}