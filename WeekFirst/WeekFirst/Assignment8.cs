using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekFirst
{
    class Assignment8
    {
        static int[,] calendar = new int[6,7];
        private static DateTime date;
        public static void printCalendar(int month, int year)
        {
            Console.Write("\n\n");
            //Drawing Header
            Console.WriteLine("Mo Tu We Th Fr Sa Su");
           // Creating date time object of first day of months
            date = new DateTime(year, month, 1);
            // Filling calendar data
            fillCalendarData(year, month);
            // Drawing calendar on console
            drawCalendarOnConsole();
        }

        static void fillCalendarData(int year, int month)
        {
            int days = DateTime.DaysInMonth(year, month);
            int currentDay = 1;
            var dayOfWeek = (int)date.DayOfWeek;
            for (int i = 0; i < calendar.GetLength(0); i++)
            {
                for (int j = 0; j < calendar.GetLength(1) && currentDay - dayOfWeek + 1 <= days; j++)
                {
                    if (i == 0 && month > j)
                    {
                        calendar[i, j] = 0;
                    }
                    else
                    {
                        calendar[i, j] = currentDay - dayOfWeek + 1;
                        currentDay++;
                    }
                }
            }
        }

        static void drawCalendarOnConsole()
        {
            for (int i = 0; i < calendar.GetLength(0); i++)
            {
                for (int j = 0; j < calendar.GetLength(1); j++)
                {
                    if (calendar[i, j] > 0)
                    {
                        if (calendar[i, j] < 10)
                        {
                            Console.Write(" " + calendar[i, j] + " ");
                        }
                        else
                        {
                            Console.Write(calendar[i, j] + " ");
                        }
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine("");
            }
        }

        static void Main()
        {
            Console.Write("Enter Year:");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Month:");
            int month = Convert.ToInt32(Console.ReadLine());
            printCalendar(month, year);
        }
    }

 }
    
