using System;


class JoroFootball
{
    static void Main(string[] args)
    {

        const int weeksPerYear = 52; //weeks in a non-leap year



        Console.WriteLine("Please chooce [t] for leap year or [f] for a non-leap year"); //“t” for leap year or “f” for year that is not leap.
        string choiceYear = Console.ReadLine();
        Console.WriteLine("Number of holidays in the year: ");
        int p = int.Parse(Console.ReadLine()); //number of holidays in the year (which are not Saturday or Sunday)

        Console.WriteLine("Number of weekends in hometown: ");
        int h = int.Parse(Console.ReadLine()); //number of weekends that Joro spends in his hometown
        double tottalGames = 0;

        if (choiceYear == "f")
        {
            tottalGames = (weeksPerYear - h) * 2.0 / 3.0 + h + p / 2.0;
        }
        else if (choiceYear == "t")
        {
            tottalGames = (weeksPerYear - h) * 2.0 / 3.0 + h + p / 2.0 + 3;

        }
        else
        {
            Console.WriteLine("Wrong input data!");
            return;
        }


        Console.WriteLine((int)tottalGames);

    }
}
