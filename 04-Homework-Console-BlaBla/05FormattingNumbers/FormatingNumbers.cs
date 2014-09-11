using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class FormatingNumbers
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            string binary = Convert.ToString(a, 2);

            Console.WriteLine("{0,-10:X}|{1}|{2,10:F2}|{3,-10:F3}",a,binary,b,c);
        }
    }
