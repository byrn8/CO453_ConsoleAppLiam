using System;
using System.Collections.Generic;
using System.Text;

namespace CO453_ConsoleAppLiam.Unit_4
{
    /// <summary>
    /// Class used for the horror story in task 4.2 & 4.3
    /// The class can generate a horror story based on certain variables the user inputs
    /// 
    /// Author: Liam Byrnes
    /// </summary>
    class HorrorStory
    {
        private string author;
        private string name, town, animal, weapon, job, colour, bus, sex, gender, answer;

        /// <summary>
        /// This is the constructor for Task 4.3 which has the 
        /// variables already filled out for the user if they 
        /// choose the default method.
        /// </summary>
        public HorrorStory()
        {
            author = "Liam Byrnes";
            name = "Danny";
            town = "Glasgow";
            animal = "Chinchilla";
            job = "Guitarist";
            weapon = "Club";
            sex = "Male";
            colour = "Orange";
            bus = "37";
        }
        
        /// <summary>
        /// This method gets the answers to the questions
        /// </summary>
        public string GetString(string prompt)
        {
            string answer;
            Console.Write(prompt);
            answer = Console.ReadLine();
            return answer;
        }
        
        /// <summary>
        /// This method gives the user the option between auto and manual
        /// </summary>
        public void GetDetails()
        {
            Console.WriteLine("Would you like to use the default method or would like to fill the story in yourself?");
            Console.WriteLine("Type 'myself' to fill the answers in yourself or press any key then enter to view the default story");
            answer = Console.ReadLine();

            if (answer == "Myself" || answer == "myself")
            {
                author = GetString("Please type your Name : ");
                name = GetString("Please type a friend's Name : ");
                town = GetString("Now give me the Name of a Town : ");
                animal = GetString("Now a type of Animal : ");
                job = GetString("Now a type of Job : ");
                weapon = GetString("Your Weapon of choice : ");
                sex = GetString("Are you male or female : ");
                colour = GetString("Your favourite color : ");
                bus = GetString("Finally, please enter a random number : ");
            }
        }
        
        /// <summary>
        /// This method confirms the gender of the user and uses it to write the story
        /// </summary>
        public void ConfirmGender()
        {
            if (sex == "Male" || sex == "male")
            {
                gender = "he";
            }
            else if (sex == "Female" || sex == "female")
            {
                gender = "she";
            }
        }
        
        /// <summary>
        /// This is the method used to write out the first chapter of the horror story
        /// </summary>
        public void WriteChapter1()
        {
            Console.Clear();
            Console.WriteLine("A Horror Story : by " + author);
            Console.WriteLine("===============================");
            Console.WriteLine("\tCHAPTER 1");
            Console.WriteLine("It was a dark night in " + town
                + " and " + name + " could hear " + animal + "s screaming in the distance.");
            Console.WriteLine(name + " staggered terrified through the streets of " + town
                + ", realising that " + gender + " had been followed.");
            Console.WriteLine("In the shadow of a doorway, a demented " + job + " waited, clutching a menacing " + weapon + " in his hand.");
        }

        /// <summary>
        /// This is the method used to write out the second chapter of the horror story
        /// </summary>
        public void WriteChapter2()
        {
            Console.WriteLine("A Horror Story : by " + author);
            Console.WriteLine("===============================");
            Console.WriteLine("\tCHAPTER 2");
            Console.WriteLine("It was a dark night in " + town
                + " and " + name + " could hear " + animal + "s screaming in the distance.");
            Console.WriteLine(name + " knew that " + gender + " had to catch the number " + bus + " bus in a few minutes.");
            Console.WriteLine("As " + name + " continued to walk through " + town + ", bright " + colour + " fireworks lit up the sky.");
            Console.WriteLine(name + " staggered terrified through the streets of " + town
                + ", realising that " + gender + " had been followed.");
            Console.WriteLine("In the shadow of a doorway, a demented " + job + " waited, clutching a menacing " + weapon + " in his hand.");
        }
    }
}
