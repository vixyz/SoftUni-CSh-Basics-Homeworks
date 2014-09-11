using System;

class Extract_Bit
{
    static void Main()
    {

        uint n = uint.Parse(Console.ReadLine());
        uint mask = 1;
        string arr;

        Console.WriteLine(arr = ((mask << 3 & n)) == 0 ? "0" : "1");
    }
}

