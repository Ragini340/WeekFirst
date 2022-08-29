using System;


namespace WeekFirst
{
    class Assignment6
    {
        static bool isValidDate(int year, int month, int day)
        {
            if (month < 1 || month > 12)
            {
                return false;
            }
            if (day < 1 || day > 31)
            {
                return false;
            }

            if (month == 2)
            {
                return (day <= 29);
                return (day <= 28);
            }

            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                return (day <= 30);
            }
            else
            {
                return true;
            }
        }

        public static void Main()
        {
            if (isValidDate(2000, 12, 10))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            if (isValidDate(2000, 11, 31))
            {
                Console.WriteLine("true");
            }

            else
            {
                Console.WriteLine("false");
            }
        }
    }
}

