using System;


namespace WeekFirst
{
    class Assignment7
    {
        static bool isPrimeNumber(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            if (num== 2)
            {
                return true;
            }
            
             if (num % 2 == 0)
                {
                    return false;
                }
            return true;
        }
        public static void Main()
        {
          
            Console.Write("Enter a number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            if (isPrimeNumber(n))
            {
                Console.WriteLine(n + " is a prime number");
            }
            else
            { 
                Console.WriteLine(n + " is not a prime number");
            }
        }
    }
}


