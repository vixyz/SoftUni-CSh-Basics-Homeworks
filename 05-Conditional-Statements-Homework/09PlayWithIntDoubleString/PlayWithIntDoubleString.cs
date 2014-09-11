using System;


    class PlayWithIntDoubleString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a type:\n1 --> int\n2 --> double\n3 --> string\n");
            string choice = Console.ReadLine();
            int iNum; string text; double dNum;
            switch (choice)
            {
                case "1":
                    iNum = int.Parse(Console.ReadLine());
                    Console.WriteLine(iNum+1);
                    break;
                case "2":
                    dNum = double.Parse(Console.ReadLine());
                    Console.WriteLine(dNum+1.0);
                    break;
                case "3":
                    text = Console.ReadLine();
                    Console.WriteLine(text+"*");
                    break;
            }

        }
    }

