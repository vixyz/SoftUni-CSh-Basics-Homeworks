using System;
using System.Collections.Generic;
using System.Linq;

class AverageLoadTime
{
    static void Main()
    {

        string inputReport = Console.ReadLine();
        string[] report = inputReport.Split(' ');
    
        double[] loadTime = new double[(report.Length)/4];
        int atCount = 3;
        for (int i = 0; i < loadTime.Length; i++)
        {
            loadTime[i] = double.Parse(report[atCount]);
            atCount += 4;
        }
        string[] URL = new string[(report.Length) / 4];
        int urlCount = 2;
        for (int i = 0; i < URL.Length; i++)
        {
            URL[i] = report[urlCount];
            urlCount += 4;
        }
        string currURL = URL[0];
        double timeSum = 0.0;
        int counter = 0;
        for (int j = 0; j < URL.Length; j++)
        {
            if (URL[j] == null)
            {
                currURL = URL[j++];
                continue;
            }

            for (int i = 0; i < URL.Length; i++)
            {
                if (URL[i] == null)
                {
                    continue;
                }
                if (currURL == URL[i])
                {
                    timeSum += loadTime[i];
                    URL[i] = null;
                    counter++;
                }
            }
            Console.WriteLine("{0} -> {1}",currURL, (timeSum/counter));
        }

    }
}
//2014-Mar-02 11:33 http://softuni.bg 8.37725 2014-Mar-02 11:34 http://www.google.com 1.335 2014-Mar-03 21:03 http://softuni.bg 7.25 2014-Mar-03 22:00 http://www.google.com 2.44 2014-Mar-03 22:01 http://www.google.com 2.45 2014-Mar-03 22:01 http://www.google.com 2.77