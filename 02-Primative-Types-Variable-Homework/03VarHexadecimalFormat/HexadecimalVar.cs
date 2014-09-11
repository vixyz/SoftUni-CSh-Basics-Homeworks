using System;

class HexadecimalVar
{
    static void Main()
    {
        string hexString = "FE"; 
        int num = Int32.Parse(hexString, System.Globalization.NumberStyles.HexNumber);
        Console.WriteLine(num);
        }
    }
