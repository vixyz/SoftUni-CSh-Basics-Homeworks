using System;

class LongestWord
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] words = input.Split(' ');

        int c1 = 0;
        int c2 = 0;
        string word = null;
        string biggetsWord = null;
        for (int i = 0; i < words.Length; i++)
        {
            word = words[i];
            c1 = word.Length;
            if (c2 < c1)
            {
                c2 = c1;
                biggetsWord = words[i];
            }
        }
        Console.WriteLine(biggetsWord);
    }
}

