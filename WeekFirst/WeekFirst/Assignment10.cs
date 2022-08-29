using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekFirst
{
    class Assignment10
    {
        private static String[] units = { "zero", "one", "two", "three",
    "four", "five", "six", "seven", "eight", "nine", "ten", "eleven",
    "twelve", "thirteen", "fourteen", "fifteen", "sixteen",
    "seventeen", "eighteen", "nineteen" };

        private static String[] tens = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };


        public static String inWords(int num)
        {
            try
            {
                
                if (num == 0)
                {
                    return Convert(num) + "";
                }
               else
                {
                    
                    return Convert(num) + "";
                }
            }
            catch (Exception)
            {
                
            }
            return null ;
        }

        public static String Convert(Int64 i)
        {
            if (i < 20)
            {
                return units[i];
            }
            if (i < 100)
            {
                return tens[i / 10] + ((i % 10 > 0) ? " " + Convert(i % 10) : " ");
            }
            if (i < 1000)
            {
                return units[i / 100] + " hundred"
                        + ((i % 100 > 0) ? " " + Convert(i % 100) : " ");
            }
            if (i < 100000)
            {
                return Convert(i / 1000) + " thousand "
                + ((i % 1000 > 0) ? " " + Convert(i % 1000) : " ");
            }
            if (i < 10000000)
            {
                return Convert(i / 100000) + " lakh "
                        + ((i % 100000 > 0) ? " " + Convert(i % 100000) : " ");
            }
            if (i < 1000000000)
            {
                return Convert(i / 10000000) + " crore "
                        + ((i % 10000000 > 0) ? " " + Convert(i % 10000000) : " ");
            }
            return Convert(i / 1000000000) + " arab "
                    + ((i % 1000000000 > 0) ? " " + Convert(i % 1000000000) : " ");
        }


        static void Main()
        {
            try
            {
                Console.WriteLine("Enter a number to convert in words:");
                string number = Console.ReadLine();
                number = inWords(int.Parse(number));

                Console.WriteLine("Input number in words is: \n{0}", number);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

