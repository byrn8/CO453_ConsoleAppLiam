using System;
using System.Collections.Generic;
using System.Text;

namespace CO453_ConsoleAppLiam.Unit_5
{
    /// <summary>
    /// Class used for the bates motel in task 5.6
    /// The class will 
    /// 
    /// 
    /// </summary>
    class Motel
    {
        int[] rooms; 
        const int MAX = 21;

        public Motel() 
        {
            rooms = new int[MAX]; 
        }

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
                
                
                
                
                else if (choice == "3")
                {
                    ShowAllRooms();
                }





            }
            while (choice != "5"); 
        }

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

        public void VacateOneRoom()
        {

        }







    }
}
