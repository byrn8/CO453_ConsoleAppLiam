using System;
using System.Collections.Generic;
using System.Text;

namespace CO453_ConsoleAppLiam.Unit_5
{
    class Tournament
    {
        string[] names;
        int[] scores; 
        const int MAX = 12;

        public Tournament() 
        {
            scores = new int[MAX];
            names = new string[MAX];
        }

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

        public void ShowDetails()
        {
            Console.WriteLine("Tournament Scores");
            Console.WriteLine("================");

            for (int detail = 0; detail < MAX; detail++)
            {
                Console.Write("Player " + names[detail] + " Scored: " + scores[detail] + "\n");
            }
        }

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
