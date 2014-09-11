using System;



class NumberAsWords
{

    static void Main(string[] args)
    {

        int num = int.Parse(Console.ReadLine());
        string hundreads = "";
        string tens = "";
        string one = "";

        if (num == 0)
        {
            Console.WriteLine("zero");
            return;
        }
        if ((num % 100) < 20)
        {

            switch (num % 100)
            {
                case 1:
                    one = "one"; break;
                case 2:
                    one = "two"; break;
                case 3:
                    one = "three"; break;
                case 4:
                    one = "four"; break;
                case 5:
                    one = "five"; break;
                case 6:
                    one = "six"; break;
                case 7:
                    one = "seven"; break;
                case 8:
                    one = "eight"; break;
                case 9:
                    one = "nine"; break;
                case 0: one = ""; break;
                case 10:
                    one = "ten"; break;
                case 11:
                    one = "eleven"; break;
                case 12:
                    one = "twelve"; break;
                case 13:
                    one = "thirteen"; break;
                case 14:
                    one = "fourteen"; break;
                case 15:
                    one = "fifteen"; break;
                case 16:
                    one = "sixteen"; break;
                case 17:
                    one = "seventeen"; break;
                case 18:
                    one = "eighteen"; break;
                case 19:
                    one = "nineteen"; break;
            }
        }
        else
        {
            switch (num % 10)
            {
                case 1:
                    one = "one"; break;
                case 2:
                    one = "two"; break;
                case 3:
                    one = "three"; break;
                case 4:
                    one = "four"; break;
                case 5:
                    one = "five"; break;
                case 6:
                    one = "six"; break;
                case 7:
                    one = "seven"; break;
                case 8:
                    one = "eight"; break;
                case 9:
                    one = "nine"; break;
                case 0: one = ""; break;
               
            }

            switch (num - (num % 10) - (num / 100) * 100)
            {
                case 20:
                    tens = "twenty"; break;
                case 30:
                    tens = "thirty"; break;
                case 40:
                    tens = "fourty"; break;
                case 50:
                    tens = "fifty"; break;
                case 60:
                    tens = "sixty"; break;
                case 70:
                    tens = "seventy"; break;
                case 80:
                    tens = "eighty"; break;
                case 90:
                    tens = "ninety"; break;
                default: tens = ""; break;
            }
            switch (num / 100)
            {
                case 1:
                    hundreads = "one"; break;
                case 2:
                    hundreads = "two"; break;
                case 3:
                    hundreads = "three"; break;
                case 4:
                    hundreads = "four"; break;
                case 5:
                    hundreads = "five"; break;
                case 6:
                    hundreads = "six"; break;
                case 7:
                    hundreads = "seven"; break;
                case 8:
                    hundreads = "eight"; break;
                case 9:
                    hundreads = "nine"; break;
                case 0: hundreads = ""; break;
            }
        }

        string hunWr = "hundread";
        if (num / 100 == 0)
        {
            hunWr = "";
        }
        string isAnd = "";
        if ((num / 100 != 0) && (num % 100 !=0) )
        {
            isAnd = "and";
        }

        Console.WriteLine("{0} {1} {2} {3} {4}",hundreads, hunWr, isAnd, tens,  one);
    }

}

