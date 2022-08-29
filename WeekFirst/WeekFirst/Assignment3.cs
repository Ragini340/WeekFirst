using System;


namespace WeekFirst
{
    class Assignment3
    {
        public static void Main()
        {
            int num1, num2, choice;

            Console.Write("Enter the first number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nThe choices are :\n");
            Console.Write("1.Addition\n2.Substraction\n3.Multiplication\n4.Division\n5.Exit\n");
            Console.Write("\nEnter the choice :");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("The Addition of  {0} and {1} is: {2}\n", num1, num2, num1 + num2);
                    break;

                case 2:
                    Console.Write("The Substraction of {0}  and {1} is: {2}\n", num1, num2, num1 - num2);
                    break;
                 
               case 3:
                    Console.Write("The Multiplication of {0}  and {1} is: {2}\n", num1, num2, num1 * num2);
                    break;

               case 4:
                    if (num2 == 0)
                    {
                        Console.Write("The second integer is zero. Devide by zero.\n");
                    }
                    else
                    {
                        Console.Write("The Division of {0}  and {1} is : {2}\n", num1, num2, num1 / num2);
                    }
                    break;

                case 5:
                    break;

                default:
                    Console.Write("Wrong choice\n");
                    break;
            }
        }
    }
}
