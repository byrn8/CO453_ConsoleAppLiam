﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CO453_ConsoleAppLiam.Unit_5
{
    /// <summary>
    /// Class used for the MP3 chart in task 5.2
    /// The class will show a list of songs and the user can vote which one they like the most
    /// At the end it will display which song got the most votes
    /// 
    /// Author: Liam Byrnes
    /// </summary>
    class MP3Chart
    {
        int[] votes;
        string[] topTen; 
        const int MAX = 10;

        /// <summary>
        /// Constructor used for defing the arrays and songs used in the arrays
        /// </summary>
        public MP3Chart() 
        {
            votes = new int[MAX];
            topTen = new string[MAX]; 
            topTen[0] = "Revolution"; 
            topTen[1] = "Mera Dil Tuta Hain";
            topTen[2] = "CandyMan";
            topTen[3] = "Ruby Tuesday";
            topTen[4] = "Old Man";
            topTen[5] = "Sometimes";
            topTen[6] = "Sometimes";
            topTen[7] = "Sometimes";
            topTen[8] = "Sometimes";
            topTen[9] = "Sometimes";
        }

        /// <summary>
        /// This method will show the whole list of songs that were previously defined
        /// </summary>
        public void ShowMusicList()
        {
            Console.Clear();
            Console.WriteLine("\tMusic List");
            Console.WriteLine("\t==========");
            for (int i = 0; i < MAX; i++)
            {
                Console.WriteLine("\tSong " + (i) + " is " + topTen[i]);
            }
        }

        /// <summary>
        /// This method will allow you to vote for your favourite song
        /// </summary>
        public void GetVotes()
        {
            int userVote;
            Console.WriteLine("\tSelect your favourite Song");
            Console.WriteLine("\t==========================");
            
            for (int vote = 0; vote < MAX; vote++)
            {
                Console.Write("\tChoose your favourite song from the list of 10 shown above : ");
                userVote = Convert.ToInt32(Console.ReadLine());
                votes[userVote]++;
            }
        }

        /// <summary>
        /// This method will list out all of the songs with the number of votes they received
        /// </summary>
        public void ShowVotes()
        {
            int count = 0;

            Console.WriteLine("\tMP3 Track Votes");
            Console.WriteLine("\t=================");

            while (count < MAX)
            {
                Console.WriteLine("\t Track " + count + " Got " + votes[count] + " votes");
                count++;
            }
        }
    }
}
