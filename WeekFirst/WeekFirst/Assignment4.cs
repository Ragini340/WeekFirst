using System;


namespace WeekFirst
{
    class Assignment4
    {
       static void arrayOfIntegers(int[] arr)
        {
            int OddSum=0, EvenSum=0;

            Console.WriteLine("Printing array elements : ");
            // Displaying the array elements
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                if(i%2 != 0)
                {
                    OddSum = OddSum + arr[i];
                }
                else
                {
                    EvenSum = EvenSum + arr[i];
                }
            }
            Console.WriteLine("Sum of odd numbers in the array : " + OddSum);
            Console.WriteLine("Sum of even numbers in the array : " + EvenSum);

        }

        public static void Main()
        {
           // Declaring an array and initializing it
            int[] arr = { 1, 2, 3, 4, 5 ,6,7,8,9,10};

            // Calling the function
            arrayOfIntegers(arr);
        }
    }
}

