using System;

class ExtractBitfromInt
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        uint mask = 1;

        Console.WriteLine((mask << p & n) == 0 ? "0" : "1");
    }
}

