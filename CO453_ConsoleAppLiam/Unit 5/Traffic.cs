using System;
using System.Collections.Generic;
using System.Text;

namespace CO453_ConsoleAppLiam.Unit_5
{
    /// <summary>
    /// Class used for the traffic survey in task 5.5
    /// The class will ask the user to input the number of cars per hour and will output the data into a table
    /// It will also calculate the total number of cars and the busiest hour of the day
    /// 
    /// Author: Liam Byrnes
    /// </summary>
    class Traffic
    {
        int[] TrafficCount;
        const int MAX = 24;
        int total, busiestTime, busiestCars = 0;

        /// <summary>
        /// This method will ask the user to input cars per hour and will also 
        /// calculate the busiest time and the total amount of cars in that time period
        /// </summary>
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

        /// <summary>
        /// This method is used to calculate the total number of cars that were seen in the day
        /// </summary>
        public void ShowTotal()
        {
            for (int i = 0; i < MAX; i++)
            {
                total = total + TrafficCount[i];
            }

            Console.WriteLine("The total number of cars seen was " + total);
        }

        /// <summary>
        /// This method is used to display the busiest time period and the amount of cars in that time
        /// </summary>
        public void Busiest()
        {
            Console.WriteLine("The busiest time of the day was hour number " + (busiestTime + 1) + " and there were " + busiestCars + " cars");

        }

        /// <summary>
        /// This is the method that is used to write out the table
        /// </summary>
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
