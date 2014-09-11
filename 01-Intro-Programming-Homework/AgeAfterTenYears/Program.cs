using System;



    class AgeAfterTenYears
    {
        static void Main(string[] args)
        {
            Console.Write("Date of birth (dd/mm/yyyy or dd.mm.yyyy):  ");            

            string birthDate = Console.ReadLine();

            //string date = "01/08/2008";

            DateTime BD = Convert.ToDateTime(birthDate);

            Console.WriteLine("Year: {0}, Month: {1}, Day: {2}", BD.Year, BD.Month, BD.Day);


            int DayDelta = DateTime.Today.Day - BD.Day;

            int MonthDelta = DateTime.Today.Month - BD.Month;

            int YearDelta = DateTime.Today.Year - BD.Year;

            


            // Console.WriteLine(7912/12/30);  //Some Checkpoint

            // TimeSpan interval1 = DateTime.Today - BD;

            //Console.WriteLine("RESULT: "+interval1);
                 
            //Console.WriteLine(interval1.Hours);

            //Console.WriteLine(Math.Abs(DateTime.Today.Month - BD.Month)*Math.Abs(DateTime.Today.Year - BD.Year));


            if (DateTime.Today.Month == BD.Month && DateTime.Today.Day < BD.Day)
            {
                Console.WriteLine("After 10 years you will be " + ((MonthDelta + YearDelta * 12) / 12 + 9) + " years old");
            }

        
            Console.WriteLine("After 10 years you will be " + ((MonthDelta + YearDelta*12)/12+10) + " years old");


            if (BD.Year > DateTime.Now.Year)
            {
                Console.Clear();
                Console.WriteLine("You are still not born");
                
            }

        }
    }


