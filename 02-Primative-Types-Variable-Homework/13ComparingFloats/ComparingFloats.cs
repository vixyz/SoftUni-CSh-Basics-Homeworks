//using System;


//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double a, b;
//            Console.Write("Compare two float numbers. ( a > b ) \n Give value for a:");
//            a = double.Parse(Console.ReadLine());
//            Console.Write("Give value for b:");
//            b = double.Parse(Console.ReadLine());
//            double sum = Math.Abs(a - b);
//            Console.WriteLine();
//            if (a > b)
//            {
//                Console.WriteLine("Result: true\n" + "  " + "The difference {0} < eps", sum);
//            }
//            else
//    {
//                Console.WriteLine("false" + "  " + "The difference {0} > eps", sum);
//    }
//        }
//    }

using System;

class ComparingFloats
{
    private static bool AreEqualWithPrecision(decimal a, decimal b, decimal precision)
    {
        return Math.Abs(a - b) < precision;
    }

    static void Main()
    {
        string firstInput = String.Empty;
        string secondInput = String.Empty;

        decimal firstNumber = 0;
        decimal secondNumber = 0;

        do
        {
            Console.WriteLine("First number:");
            firstInput = Console.ReadLine();
        }
        while (!Decimal.TryParse(firstInput, out firstNumber));

        do
        {
            Console.WriteLine("Second number:");
            secondInput = Console.ReadLine();
        }
        while (!Decimal.TryParse(secondInput, out secondNumber));

        decimal precision = 0.000001M;
        bool areEqual = AreEqualWithPrecision(firstNumber, secondNumber, precision);

        Console.WriteLine("{0} and {1} are{2} equal with precision {3}.",
            firstNumber, secondNumber, areEqual ? String.Empty : " not", precision);
    }
}