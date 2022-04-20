using System;
using System.Collections.Generic;
using System.Text;

namespace TaskHotelRoom.Models
{
    internal class Hotel
    {
        public string Name { get; set; }

        private Room[] rooms = new Room[0];

        public Hotel(string name)
        {
            Name = name;
        }



        public void AddRoom(Room room)
        {
            Array.Resize(ref rooms, rooms.Length + 1);
            rooms[rooms.Length - 1] = room;
        }

        public void MakeReservation(int roomId)
        {
            foreach (var item in rooms)
            {
                if(item.Id == roomId)
                {
                    if(item.IsAvailable == false)
                    {
                        Console.WriteLine("Room Is Full");
                    }
                    else
                    {
                        item.IsAvailable = false;
                        Console.WriteLine($"{roomId}Id room reserved");
                    }

                }

            }

        }

        public void GetRooms()
        {
            foreach (var item in rooms)
            {
                Console.WriteLine(item);
            }
        }



    }
}
