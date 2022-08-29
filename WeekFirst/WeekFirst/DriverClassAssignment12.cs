using System;

namespace WeekFirst
{
    class DriverClassAssignment12
    {
        public static void Main()
        {  
            // 'a' is object of class 'Account' class 'Account' cannot be instantiate.
            Account a;

            // Instantiating class 'SBAccount'
            a = new SBAccount();
            //calling 'CalculateInterest()' of class 'SBAccount'
            a.CalculateInterest();

            // Instantiating class 'RDAccount'
            a = new RDAccount();
            //calling 'CalculateInterest()' of class 'RDAccount'
            a.CalculateInterest();

            // Instantiating class 'FDAccount'
            a = new FDAccount();
            //calling 'CalculateInterest()' of class 'FDAccount'
            a.CalculateInterest();


        }
    }
}
