using System;

    class CompanyInfo
    {
        static void Main()
        {

            string compName = Console.ReadLine();
            string compAddress = Console.ReadLine();
            string phoneNum = Console.ReadLine();
            string webSite = Console.ReadLine();
            string faxNum = Console.ReadLine();
            string manFName = Console.ReadLine();
            string manLName = Console.ReadLine();
            uint manAge = uint.Parse(Console.ReadLine());
            string manPhone = Console.ReadLine();
            if (faxNum==" "|| faxNum=="")
            {
                faxNum = "(no fax)";
            }

            Console.WriteLine("{0}\nAddress:{1}\nTel:{2}\nFax:{3}\nWeb site:{4}\nManager:{5}{6}(age:{7},tel:{8})",compName,compAddress,phoneNum,webSite,faxNum,webSite,manFName,manLName,manAge,manPhone);
        }
    }

