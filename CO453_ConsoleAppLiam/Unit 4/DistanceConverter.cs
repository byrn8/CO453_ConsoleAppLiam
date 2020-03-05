using System;
using System.Collections.Generic;
using System.Text;

namespace CO453_ConsoleAppLiam.Unit_4
{
    /// <summary>
    /// Class used for the distance converter in task 4.1
    /// The class will give you the option to convert miles to feet or feet to miles
    /// 
    /// Author: Liam Byrnes
    /// </summary>
    class DistanceConverter
    {
        private double miles, feet;

        /// <summary>
        /// This method gives the user the option between miles to feet or feet to miles
        /// and will also get the values from the other methods to display
        /// </summary>
        public void Test()
        {
            string input;

            Console.WriteLine("1. Convert Miles to Feet");
            Console.WriteLine("2. Convert Feet to Miles");

            Console.WriteLine("Input your decision: ");

            input = Console.ReadLine();

            if (input == "1")
            {
                miles = GetNumbers("miles");
                feet = ToFeet(miles);
                Console.WriteLine(miles + " miles is " + feet + " feet");
            }
            else if (input == "2")
            {
                feet = GetNumbers("feet");
                miles = ToMiles(feet);
                Console.WriteLine(feet + " feet is " + miles + " miles");
            }
        }

        /// <summary>
        /// This method asks the user to input the value they want to convert
        /// </summary>
        public double GetNumbers(string prompt)
        {
            double number;
            string input;
            Console.Write("Please enter the distance: ");
            input = Console.ReadLine();
            number = Convert.ToDouble(input);
            return number;
        }

        /// <summary>
        /// This method will calculate the feet to miles
        /// </summary>
        public double ToMiles(double feet)
        {
            return feet / 1760 / 3;
        }

        /// <summary>
        /// This method will calculate the miles to feet
        /// </summary>
        public double ToFeet(double miles)
        {
            return miles * 1760 * 3;
        }
    }
}
