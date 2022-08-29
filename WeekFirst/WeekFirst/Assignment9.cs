using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekFirst
{
    class Assignment9
    {
        public static string reverseByWords(string sentence)
        {

            string output = string.Empty;
            string word = string.Empty;
            foreach (char c in sentence)
            {
                if (c == ' ')
                {
                    output = word + ' ' + output;
                    word = string.Empty;
                }
                else
                {
                    word = word + c;
                }
            }
            output = word + ' ' + output;
            return output;
        }
        static void Main(string[] args)
        {
            string str = "my name is vinod and i live in bangalore";
            string[] arr = str.Split(' ');
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
           

            Console.ReadLine();
        }
    }
}