using System;
using System.Collections.Generic;
using System.Text;

namespace CO453_ConsoleAppLiam.Unit_4
{
    /// <summary>
    /// This is the class i used for Task 4.2 and 4.3 Horror Story
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
        
        public string GetString(string prompt)
        {
            string answer;
            Console.Write(prompt);
            answer = Console.ReadLine();
            return answer;
        }
        
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
        
        public void CheckGender()
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
