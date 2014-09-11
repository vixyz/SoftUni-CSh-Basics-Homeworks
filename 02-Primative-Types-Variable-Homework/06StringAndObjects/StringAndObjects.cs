using System;



    class StringsAndObjects
    {
        static void Main(string[] args)
        {

            string a = "Hello";
            string b = "World";
            object sum = a + " " + b;
            string c;
            c = (string)sum;          
            Console.WriteLine(c);


        }
    }

