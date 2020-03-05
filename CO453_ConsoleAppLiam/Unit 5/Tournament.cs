using System;
using System.Collections.Generic;
using System.Text;

namespace CO453_ConsoleAppLiam.Unit_5
{
    /// <summary>
    /// Class used for the tournament in task 5.1 & 5.3
    /// The class asks the user to input names and scores and will display them
    /// 
    /// Author: Liam Byrnes
    /// </summary>
    class Tournament
    {
        string[] names;
        int[] scores; 
        const int MAX = 6;

        /// <summary>
        /// Constructor used to define the arrays in the class
        /// </summary>
        public Tournament() 
        {
            scores = new int[MAX];
            names = new string[MAX];
        }

        /// <summary>
        /// This method was used for task 5.3 and asks the user to input
        /// their name and their score
        /// </summary>
        public void GetDetails()
        {
            Console.WriteLine("Inputting the Names & Tournament Scores");
            Console.WriteLine("=========================");
            for (int i = 0; i < MAX; i++)
            {
                Console.Write("Enter player " + (i + 1) + " name : ");
                names[i] = Console.ReadLine();

                Console.Write("Enter score number for " + names[i] + " : ");
                scores[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        /// <summary>
        /// This method will write out every name and score that was stored in the array 
        /// </summary>
        public void ShowDetails()
        {
            Console.WriteLine("Tournament Scores");
            Console.WriteLine("================");

            for (int detail = 0; detail < MAX; detail++)
            {
                Console.Write("Player " + names[detail] + " Scored: " + scores[detail] + "\n");
            }
        }

        /// <summary>
        /// This method was used for task 5.1 and does the same as the last method but without names
        /// </summary>
        public void ShowScores()
        {
            Console.WriteLine("Tournament Scores");
            Console.WriteLine("================");

            for (int score = 0; score < MAX; score++)
            {
                Console.Write("Player " + (score + 1) + " Scored <" + scores[score] + ">\n");
            }
        }
    }
}
