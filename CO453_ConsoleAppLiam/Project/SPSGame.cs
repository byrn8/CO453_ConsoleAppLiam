using System;
using System.Collections.Generic;
using System.Text;

namespace CO453_ConsoleAppLiam.Project
{
    /// <summary>
    /// Class used for the SPS game in the project
    /// This class will simulate a rock, paper scissors game by generating a random number
    /// 
    /// Author: Liam Byrnes
    /// </summary>
    class SPSGame
    {
        string compChoice;
        string playerChoice;
        string name;
        Random randy;
        public SPSGame() 
        {
            randy = new Random(); 
        }

        /// <summary>
        /// This is the main method i used to call all of the other methods
        /// </summary>
        public void Play() 
        {
            SetupScreen();
            Introduction();
            GetPlayerChoice();
            GetComputerChoice();
            DrawPlayerChoice();
            PrintChoices();
            ShowResult();
            Console.ReadKey(); 
        }

        /// <summary>
        /// This method is used to set the size and background colour of the program
        /// </summary>
        private void SetupScreen()
        {
            Console.Title = " The Great Scissors-Paper-Stone Game";
            Console.SetWindowSize(100, 36);
            Console.SetBufferSize(100, 36);
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear(); 
        }

        /// <summary>
        /// This method is used to introduce the game and ask the user for their name
        /// </summary>
        private void Introduction()
        {
            Console.WriteLine("\tPlay the Scissors Paper Stone Game");
            Console.WriteLine("\t============================");
            Console.Write("\tEnter your name: ");
            name = Console.ReadLine();
        }

        /// <summary>
        /// This method is used to ask the user what their choice is
        /// </summary>
        private void GetPlayerChoice()
        {
            Console.WriteLine("\n\tWhat is your choice " + name + "?");
            Console.Write("\tScissors, Paper or Stone : ");
            playerChoice = Console.ReadLine();
        }

        /// <summary>
        /// This method is used to randomly generate a number between 0 and 2 
        /// Each number correlates to one of the three choices shown below
        /// </summary>
        private void GetComputerChoice() 
        {
            int num;
            num = randy.Next(3);
            if (num == 0)
            {
                compChoice = "SCISSORS";
            }
            else if (num == 1)
            {
                compChoice = "PAPER";
            }
            else if (num == 2)
            {
                compChoice = "STONE";
            }
        }

        /// <summary>
        /// This is the method used to draw the pictures based on the player and the computers choice
        /// </summary>
        private void DrawPlayerChoice()
        {
            if (playerChoice == "SCISSORS")
            {
                DrawScissors(10, 5); 
            }
            else if (playerChoice == "PAPER")
            {
                DrawPaper(10, 5);
            }
            else if (playerChoice == "STONE")
            {
                DrawStone(10, 5);
            }

            if (compChoice == "SCISSORS")
            {
                DrawScissors(60, 6);
            }
            else if (compChoice == "PAPER")
            {
                DrawPaper(60, 6);
            }
            else if (compChoice == "STONE")
            {
                DrawStone(60, 6);
            }
        }

        /// <summary>
        /// This method is used to output the player choice and the computer choice
        /// </summary>
        private void PrintChoices()
        {
            Console.WriteLine("\n\t" + name + " picked " + playerChoice);
            Console.WriteLine("\tThe computer has picked " + compChoice);
        }

        /// <summary>
        /// This is the method used to determine if the user has won the game or not
        /// It will then output a message based on if you won or lost
        /// </summary>
        private void ShowResult()
        {
            if (playerChoice == compChoice)
            {
                Console.WriteLine("\n\tA DRAW!!");
            }
            else if (playerChoice == "SCISSORS" && compChoice != "STONE")
            {
                Console.WriteLine("\n\t" + name + " WINS!!");
            }
            else if (playerChoice == "PAPER" && compChoice != "SCISSORS")
            {
                Console.WriteLine("\n\t" + name + " WINS!!");
            }
            else if (playerChoice == "STONE" && compChoice != "PAPER")
            {
                Console.WriteLine("\n\t" + name + " WINS!!");
            }
            else
            {
                Console.WriteLine("\n\t" + name + " LOSES!!");
            }
        }

        /// <summary>
        /// This is the method used for the picture of the scissors
        /// </summary>
        private void DrawScissors(int x, int y) 
        {
            Console.SetCursorPosition(x, y++);
            Console.Write("     \\            /");
            Console.SetCursorPosition(x, y++);
            Console.Write("      \\          /");
            Console.SetCursorPosition(x, y++);
            Console.Write("       \\        /");
            Console.SetCursorPosition(x, y++);
            Console.Write("        \\      /");
            Console.SetCursorPosition(x, y++);
            Console.Write("         \\    /");
            Console.SetCursorPosition(x, y++);
            Console.Write("          \\  /");
            Console.SetCursorPosition(x, y++);
            Console.Write("           **");
            Console.SetCursorPosition(x, y++);
            Console.Write("          /  \\");
            Console.SetCursorPosition(x, y++);
            Console.Write("    (----/    \\----)");
            Console.SetCursorPosition(x, y++);
            Console.Write("     \\  /      \\  /");
            Console.SetCursorPosition(x, y++);
            Console.Write("      ==        ==");
            Console.WriteLine("\n\n");
        }

        /// <summary>
        /// This is the method used for the picture of the paper
        /// </summary>
        private void DrawPaper(int x, int y)
        {
            Console.SetCursorPosition(x, y++);
            Console.Write("      .--.------------------.");
            Console.SetCursorPosition(x, y++);
            Console.Write("     /      \\  \\ \\ \\ \\ \\ \\ \\ \\");
            Console.SetCursorPosition(x, y++);
            Console.Write("    /   OOO  \\                |");
            Console.SetCursorPosition(x, y++);
            Console.Write("   |   OOOO   || A N D R E X | |");
            Console.SetCursorPosition(x, y++);
            Console.Write("   |   OOOO   |                |");
            Console.SetCursorPosition(x, y++);
            Console.Write("    \\   OOO   /                /");
            Console.SetCursorPosition(x, y++);
            Console.Write("     \\      // / / / / / / / //");
            Console.SetCursorPosition(x, y++);
            Console.Write("       `--'-|| | | | | | | | |");
            Console.SetCursorPosition(x, y++);
            Console.Write("             \\                \\");
            Console.SetCursorPosition(x, y++);
            Console.Write("              \\                \\");
            Console.SetCursorPosition(x, y++);
            Console.Write("               \\                \\");
            Console.SetCursorPosition(x, y++);
            Console.Write("                \\ \\ \\ \\ \\ \\ \\ \\ \\\\");
            Console.SetCursorPosition(x, y++);
            Console.Write("                 \\________________\\");
            Console.WriteLine();
        }

        /// <summary>
        /// This is the method used for the picture of the stone
        /// </summary>
        private void DrawStone(int x, int y)
        {
            Console.SetCursorPosition(x, y++);
            Console.Write("                 ___---___     ");
            Console.SetCursorPosition(x, y++);
            Console.Write("              .--         --.    ");
            Console.SetCursorPosition(x, y++);
            Console.Write("           ./   ()       .-. \\.   ");
            Console.SetCursorPosition(x, y++);
            Console.Write("           /   o    .   (   )  \\  ");
            Console.SetCursorPosition(x, y++);
            Console.Write("          / .            '-'    \\  ");
            Console.SetCursorPosition(x, y++);
            Console.Write("         /     ()   ()           \\ ");
            Console.SetCursorPosition(x, y++);
            Console.Write("        |    o           ()       | ");
            Console.SetCursorPosition(x, y++);
            Console.Write("        |      .--.           O   | ");
            Console.SetCursorPosition(x, y++);
            Console.Write("         \\ .  |    |              |  ");
            Console.SetCursorPosition(x, y++);
            Console.Write("          \\   `.__.'     o   .   /    ");
            Console.SetCursorPosition(x, y++);
            Console.Write("           `\\  o    ()         /'    ");
            Console.SetCursorPosition(x, y++);
            Console.Write("              `--___    ___--'    ");
            Console.SetCursorPosition(x, y++);
            Console.Write("                     ---         ");
            Console.WriteLine();
        }
    }
}
