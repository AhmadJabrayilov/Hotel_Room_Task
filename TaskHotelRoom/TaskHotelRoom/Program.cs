using System;
using TaskHotelRoom.Models;

namespace TaskHotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Room room1 = new Room("Boyuk otaq", 30, 4);
            Room room2 = new Room("Kicik otaq", 12, 1);

            Hotel hotel = new Hotel("Four Seasons");

            hotel.AddRoom(room1);
            hotel.AddRoom(room2);

            Console.WriteLine(room1);
            Console.WriteLine("**************************************");
            Console.WriteLine(room2);
            Console.WriteLine("**************************************");


            hotel.GetRooms();

        }
    }
}
