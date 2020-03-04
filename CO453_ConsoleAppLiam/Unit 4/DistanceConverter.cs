using System;
using System.Collections.Generic;
using System.Text;

namespace CO453_ConsoleAppLiam.Unit_4
{
    class DistanceConverter
    {
        private double miles, feet;

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

        public double GetNumbers(string prompt)
        {
            double number;
            string input;
            Console.Write("Please enter the distance: ");
            input = Console.ReadLine();
            number = Convert.ToDouble(input);
            return number;
        }

        public double ToMiles(double feet)
        {
            return feet / 1760 / 3;
        }

        public double ToFeet(double miles)
        {
            return miles * 1760 * 3;
        }
    }
}
