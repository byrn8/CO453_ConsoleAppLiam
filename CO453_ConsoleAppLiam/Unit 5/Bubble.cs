using System;
using System.Collections.Generic;
using System.Text;

namespace CO453_ConsoleAppLiam.Unit_5
{
    class Bubble
    {
        int[] num;
        const int MAX = 6;

        public void InputNumbers()
        {
            num = new int[MAX];
            
            for (int i = 0; i < MAX; i++)
            {
                Console.WriteLine("Input number " + (i + 1 ) + ": ");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void Display()
        {
            Console.WriteLine(num[0]);
            Console.WriteLine(num[1]);
            Console.WriteLine(num[2]);
            Console.WriteLine(num[3]);
            Console.WriteLine(num[4]);
            Console.WriteLine(num[5]);
        }

        public void SortNumbers()
        {
            int numberSwap;

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
