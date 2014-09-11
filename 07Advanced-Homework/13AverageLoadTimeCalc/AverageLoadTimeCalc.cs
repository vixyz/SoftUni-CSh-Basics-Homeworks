using System;
using System.Collections.Generic;
using System.Linq;

    class AverageLoadTimeCalc
    {

        public struct URL {

            public string link;
            public double loadTime;
        }
        public struct Results {

            public string linkHere;
            public double timeHere;
        }

     
        static void Main()
        {
            List<URL> myReports = new List<URL>();

            URL current;   // CURRENT

            string inputReport;
            string[] report;          
            double timeSum = 0.0;
            int countListLenght = 0;
            double countInputs = 0.0;

            while (true)
            {            
                inputReport = Console.ReadLine();
                report = inputReport.Split(' ');
            
                current.link = report[2];
                current.loadTime = double.Parse(report[3]);
                myReports.Add(current);
                countListLenght++;

                for (int i = 0; i < countListLenght; i++)
                {
                    if (current.link == myReports[i].link)
                    {
                        timeSum += myReports[i].loadTime;
                    }
                    
                }


              
                current.loadTime = timeSum / countInputs;
                int n = 0;




                for (int i = 0; i < countListLenght; i++)
                {
                    if (myReports[i].link == current.link)
                    {
                        n++;
                    }                  
                }

                if (n == 0)
                {
                    myResults.Add(lastResult);
                }
                else
                {
                    for (int i = 1; i < countListLenght; i++)
                    {
                        if (myResults[i].sameLink == current.link)
                        {
                            myResults[i].avTime = lastResult.avTime;
                        }
                    }
                }

                Console.WriteLine("{0} -> {1}", current.link,(timeSum/countInputs));
                timeSum = 0;
            }
        }
    }

