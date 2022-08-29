using System;

namespace WeekFirst
{
   public abstract class Account
    {
        int Id = 123;
        string Name = "Ragini";
        int balance = 2000;
        float CreditOperation = 500;
        float DebitOperation =100;
        public abstract void CalculateInterest();
       
    }
}
