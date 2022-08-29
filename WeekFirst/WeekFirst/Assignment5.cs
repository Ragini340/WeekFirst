using System;


namespace WeekFirst
{
    class Assignment5
    {
         static int Interest(int p, int r, int t) 
         {
            int Interest_Amount;
            Interest_Amount = (p * r * t) / 100; 
            return Interest_Amount;
         }
        static void Main()
        {
            int principalAmount, term, rateOFInterest, SimpleInterest;
            
            Console.WriteLine("Enter the Principal Amount : ");
            principalAmount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the term : ");
            term = Convert.ToInt32(Console.ReadLine()); ;
            Console.Write("Enter the Rate Of Interest : ");
            rateOFInterest = Convert.ToInt32(Console.ReadLine());

            SimpleInterest = Interest(principalAmount, rateOFInterest, term);
          
            Console.WriteLine("Interest amount is : "+ SimpleInterest);

           // Console.ReadLine();
            
        }
    }
}
