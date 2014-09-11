using System;

class BooleanVar
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Are you a Female?");
        bool isFemale = true;

        string input = Console.ReadLine();

        if (input == "y" || input == "Y" || input == "yes" || input == "Yes")
        {
            Console.WriteLine("You are a female. This is {0} about me too", isFemale);
        }
        else if (input == "n" || input == "N" || input == "no" || input == "No")
        {
            isFemale = false;
            Console.WriteLine("You are a male. This is {0} about me.", isFemale);
        }
        else
        {
            Console.WriteLine("I don't understand you. Please, use [Y]es or [N]o for answer! \n If you don't answer me, I won't tell you my gender too.");
        }

    }
}
