using System;

class Program
{
    static void Main(string[] args)
    {
       int a = 4;
        int b = 5;
  /*      Console.WriteLine((double)a / b);
        Console.WriteLine(a / b);
        double c = 5.444;
        double d = 3.3534;
        Console.WriteLine(c % d);
        int z = 0;
        try
        {
            Console.WriteLine(a / z);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Can't divide by Zero!");
        }
        Console.WriteLine();
        Console.WriteLine("BN!!!"); //BN !!!
        int bigNum = 200000000;
        Console.WriteLine(bigNum * bigNum);
        bigNum = Int32.MaxValue;
        Console.WriteLine(bigNum);
        Console.WriteLine();
        Console.WriteLine("Stupid Operators from Discret Math"); 

        bool y = true;
        bool x = false;

        Console.WriteLine(x && y);
        Console.WriteLine(x || y);
        Console.WriteLine(x ^ y);
        Console.WriteLine(!x);
        Console.WriteLine(!y);
        Console.WriteLine(x && true);
        Console.WriteLine(x && false); */

        Console.WriteLine();
        Console.WriteLine("Bitwise Operators");
        // in Bitwise level the operatos are:  { & } , { | } , { ^ }
        // << and >> moving bits (left or right)
        ushort u = 3;                  //0000 0011
        ushort w = 5;                  //0000 0101
        Console.WriteLine("My starting numbers: " + u + " and " + w);
        Console.WriteLine();

        Console.WriteLine(u | w);        //0000 0111   7 
        Console.WriteLine(u & w);        //0000 0001   1
        Console.WriteLine(u ^ w);        // 6
        Console.WriteLine(~u & w);       // 4
        Console.WriteLine(u << 1);       // 6
        Console.WriteLine(u >> 1);       // 1
        Console.WriteLine(u >> 2);       // 0
        Console.WriteLine(u << 2);       // 12
        Console.WriteLine(~u);           // -4
        Console.WriteLine((ushort)~u);   // 65532

        Console.WriteLine(Convert.ToString(u, 2).PadLeft(16, '0'));       // 0000 0000 0000 0011 


        int p = 9;
        int n = 279;

        int mask = ~(1 << p);
        int result = n & mask;

        Console.WriteLine(result);
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(16, '0'));


        var h = new int(); // var is used for undef objects. Later we def it as int 


        Console.WriteLine();
        Console.WriteLine("Inplicit and Explicit Type Conversion");
        long l = 5;
        int i = (int)l; // explict type conversion. Precision loss. Without cast >> ERROR

        double Y = (double)(a + b) / w;
        Console.WriteLine("c={0:F8}", Y);

        // Bit Hacks :D



      











    }
}





