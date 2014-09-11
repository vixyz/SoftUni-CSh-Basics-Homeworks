using System;

class BeerTime
{
    static void Main(string[] args)
    {


            Console.WriteLine("Please enter time in format HH:MM:TT");
            string timeIn = Console.ReadLine();
            DateTime needBeer = Convert.ToDateTime(timeIn);

            string start = "01:00 PM";
            string end = "03:00 AM";
            string dayLimit = "11:59 PM";
            string nightLimit = "00:00 AM";

            DateTime needLimit = DateTime.Parse(nightLimit);
            DateTime someLimit = DateTime.Parse(dayLimit);
            DateTime haveBeer = DateTime.Parse(start);
            DateTime noBeer = DateTime.Parse(end);

            if ((needBeer >= haveBeer && needBeer <= someLimit) || (needBeer < noBeer && needBeer >= needLimit))
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }

           
        }
    }


