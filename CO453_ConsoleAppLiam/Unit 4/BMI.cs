using System;
using System.Collections.Generic;
using System.Text;

namespace CO453_ConsoleAppLiam.Unit_4
{
    class BMI
    {
        double bmi, weight, height;

        public void GetDetails()
        {
            string input;
            
            Console.WriteLine("Please enter your weight in kg:");
            input = Console.ReadLine();
            weight = Convert.ToDouble(input);

            Console.WriteLine("Please enter your height in metres:");
            input = Console.ReadLine();
            height = Convert.ToDouble(input);
        }

        public void CalcBMI()
        {
            bmi = weight / (height * height);
        }

        public void DisplayBMI()
        {
            Console.WriteLine("Your BMI is " + bmi);

            if (bmi < 18.5)
            {
                Console.WriteLine("Your BMI was less than 18.5 which means you are underweight");
            }
            else if (bmi > 18.5 && bmi <= 25)
            {
                Console.WriteLine("Your BMI was greater than 18.5 and less than 25 which means you are of desirable weight for size");
            }
            else if (bmi > 25 && bmi <= 30)
            {
                Console.WriteLine("Your BMI was greater than 25 and less than 30 which means you are overweight");
            }
            else if (bmi > 30 && bmi <= 40)
            {
                Console.WriteLine("Your BMI was greater than 30 but less than 40 which means you are obese");
            }
            else if (bmi > 40)
            {
                Console.WriteLine("Your BMI was greater than 40 which means you are severely obese");
            }
        }
    }
}
