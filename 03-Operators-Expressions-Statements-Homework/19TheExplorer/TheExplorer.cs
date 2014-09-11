using System;

    class TheExplorer
    {

        

        static void Main()
        {

            int rows = int.Parse(Console.ReadLine());
            int q = rows / 2;

            for (int i = 0; i < q; i++)
            {

                for (int j = 0; j < q; j++)
                {

                    Console.Write("-");
                }
                Console.Write("*");
                //for (int j = 0; j < q; j++)
                //{

                //    Console.Write("-");
                //}
                Console.WriteLine();
            }
        }


        }
    