using System;
using System.Collections.Generic;
using System.Text;

namespace CO453_ConsoleAppLiam.Unit_5
{
    /// <summary>
    /// Class used for the bates motel in task 5.6
    /// The class will give the user 4 different options to choose from
    /// 
    /// Author: Liam Byrnes
    /// </summary>
    class Motel
    {
        int[] rooms; 
        const int MAX = 21;
        int roomNumber;

        /// <summary>
        /// Constructor used to define the array in the program
        /// </summary>
        public Motel() 
        {
            rooms = new int[MAX]; 
        }

        /// <summary>
        /// The main method of the program where all the other methods are called from
        /// </summary>
        public void RunMotel()
        {
            string choice = "";
            
            do
            {
                Console.Clear();
                Console.WriteLine("The Bates Motel");
                Console.WriteLine("===============");
                Console.WriteLine("1. Book a room");
                Console.WriteLine("2. Vacate a room");
                Console.WriteLine("3. Display ALL Room Details");
                Console.WriteLine("4. Vacate ALL rooms");
                Console.WriteLine("5. Quit");
                Console.Write("Enter your choice : ");
                choice = Console.ReadLine();
               
                if (choice == "1")
                {
                    BookRoom();
                }
                else if (choice == "2")
                {
                    VacateOneRoom();
                }
                else if (choice == "3")
                {
                    ShowAllRooms();
                }
                else if (choice == "4")
                {
                    VacateAll();
                }
            }
            while (choice != "5"); 
        }

        /// <summary>
        /// This method was used for the first option and allows you to book a room in the motel
        /// </summary>
        public void BookRoom()
        {
            int roomNumber, guests;
            Console.WriteLine("\nThe Bates Motel");
            Console.WriteLine("===============");
            Console.WriteLine("Book a room");
            Console.Write("Enter the room number : ");
            roomNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many guests : ");
            guests = Convert.ToInt32(Console.ReadLine());
            rooms[roomNumber] = guests;
            Console.WriteLine("Room " + roomNumber + " booked for " + guests + " people");
            Console.ReadKey(); 
        }

        /// <summary>
        /// This method was used for the third choice and will show all the room details
        /// </summary>
        public void ShowAllRooms()
        {
            {
                Console.WriteLine("All Room Details");

                for (int i = 1; i < MAX + 1; i++)
                {
                    Console.WriteLine("Room " + (i - 1) + "    " + rooms[i - 1] + " Guests");
                }
                Console.ReadKey();
            }
        }

        /// <summary>
        /// This method was used for the second option and will vacate whichever room the user inputs
        /// </summary>
        public void VacateOneRoom()
        {
            Console.Write("Which room do you want to vacate: ");
            roomNumber = Convert.ToInt32(Console.ReadLine());
            rooms[roomNumber] = 0;
            Console.Write("Room " + roomNumber + " has been vacated");
            Console.ReadKey();
        }

        /// <summary>
        /// This method was used for the fourth option and will vacate every room in the motel
        /// </summary>
        public void VacateAll()
        {
            for (int i = 1; i < MAX; i++)
            {
                rooms[i] = 0;
            }
            
            Console.Write("All rooms have been vacated");
            Console.ReadKey();
        }
    }
}
