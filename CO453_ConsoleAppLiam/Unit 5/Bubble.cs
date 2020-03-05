using System;
using System.Collections.Generic;
using System.Text;

namespace CO453_ConsoleAppLiam.Unit_5
{
    /// <summary>
    /// Class used for the bubble sort in task 5.4
    /// The class will ask the user to input numbers and it will then sort them from lowest to highest
    /// 
    /// Author: Liam Byrnes
    /// </summary>
    class Bubble
    {
        int[] num;
        const int MAX = 6;

        /// <summary>
        /// This method asks the user to input the numbers
        /// </summary>
        public void InputNumbers()
        {
            num = new int[MAX];
            
            for (int i = 0; i < MAX; i++)
            {
                Console.WriteLine("Input number " + (i + 1 ) + ": ");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        /// <summary>
        /// This is the method that is used to display the numbers in order
        /// </summary>
        public void Display()
        {
            Console.WriteLine(num[0]);
            Console.WriteLine(num[1]);
            Console.WriteLine(num[2]);
            Console.WriteLine(num[3]);
            Console.WriteLine(num[4]);
            Console.WriteLine(num[5]);
        }

        /// <summary>
        /// This method is used to apply the bubble sort algorithm but i still haven't worked how to apply it yet
        /// The actual algoritm is there but i can't work out how to sort the numbers
        /// </summary>
        public void SortNumbers()
        {
            for (int i = 0; i < num.Length; i++)
            {
                for (int ii = 0; ii < num.Length - 1; ii++)
                {
                    if (num[ii] > num[ii + 1])
                    {
                        
                    }
                }
            }
        }
    }
}
