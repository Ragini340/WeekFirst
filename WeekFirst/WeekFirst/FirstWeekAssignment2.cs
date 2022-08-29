using System;


namespace WeekFirst
{
    class FirstWeekAssignment2
    {
        static void EvenOdd(int[] arr)
        {
            // Initializing left and right indexes 
            int left = 0, right = arr.Length - 1;
            while (left < right)
            {
                //Incrementing left index while we see 0 at left 
                while (arr[left] % 2 == 0 && left < right)
                    left++;

                //Decrementing right index while we see 1 at right 
                while (arr[right] % 2 == 1 && left < right)
                    right--;

                if (left < right)
                {
                    // Swapping arr[left] and arr[right]
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                 
                    left++;
                    right--;
                }
            }
        }


        public static void Main()
        {
            int[] arr = { 12, 34, 45, 9, 8, 90, 3 };
            EvenOdd(arr);

            Console.Write("Even and Odd numbers are:  ");
            for (int i = 0; i < arr.Length; i++)             
            Console.Write(arr[i] + " ");
            
            
        }
    }
}
