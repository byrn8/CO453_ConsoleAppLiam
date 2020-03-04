using System;
using System.Collections.Generic;
using System.Text;

namespace CO453_ConsoleAppLiam.Unit_5
{
    class Traffic
    {
        int[] TrafficCount;
        const int MAX = 24;
        int total, busiestTime, busiestCars = 0;

        public void EnterCounts()
        {
            TrafficCount = new int[MAX];

            for (int i = 0; i < MAX; i++)
            {
                Console.Write("Please enter the count for hour number " + (i + 1) + ": ");
                TrafficCount[i] = Convert.ToInt32(Console.ReadLine());

                if (TrafficCount[i] > busiestCars)
                {
                    busiestTime = i;
                    busiestCars = TrafficCount[i];
                }
            }
        }

        public void ShowTotal()
        {
            for (int i = 0; i < MAX; i++)
            {
                total = total + TrafficCount[i];
            }

            Console.WriteLine("The total number of cars seen was " + total);
        }

        public void Busiest()
        {
            Console.WriteLine("The busiest time of the day was hour number " + (busiestTime + 1) + " and there were " + busiestCars + " cars");

        }

        public void ShowData()
        {
            Console.WriteLine("Traffic Report\n");
            Console.WriteLine("Hour\tCar Count");

            for (int i = 0; i < MAX; i++)
            {
                Console.WriteLine((i + 1) + "\t" + TrafficCount[i]);
            }
        }
    }
}
