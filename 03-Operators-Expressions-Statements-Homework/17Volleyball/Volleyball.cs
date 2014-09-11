using System;

    class Volleyball
    {
        static void Main()
        {
            string year = Console.ReadLine();
            const int yearWeeks = 48;
            int p = int.Parse(Console.ReadLine()); //holidays
            int h = int.Parse(Console.ReadLine()); //hometown
            double tottalPlays = (yearWeeks - h) * 3.0 / 4.0 + h + p * 2.0 / 3.0;
            if (year == "normal")
            {
                Console.WriteLine((int)tottalPlays);
            }
            if (year == "leap")
            {
                Console.WriteLine((int)(tottalPlays + tottalPlays*15.0/100.0));
            }
            
        }
    }
