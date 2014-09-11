using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04DifferenceBetweenDates
{
    class DifferenceBetweenDates
    {
        static void Main(string[] args)
        {

            DateTime firstInput = DateTime.Parse(Console.ReadLine());
            DateTime secondInput = DateTime.Parse(Console.ReadLine());

            double DayDelta = (secondInput - firstInput).TotalDays;

            Console.WriteLine(DayDelta);
        }
    }
}
