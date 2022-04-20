using System;
using System.Collections.Generic;
using System.Text;

namespace TaskHotelRoom.Models
{
    internal class Room
    {
        private int _id;
        private double _price;
        private int _persoCapacity;
        public int Id { get; }
        public string Name { get; set; }
        public bool IsAvailable = true;

        // Price
        public double Price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }

            }
        }
        ///Person Capacity
        public int PersonCapacity
        {
            get { return _persoCapacity; }
            set
            {
                if (value > 0 && value < 6)
                {
                    _persoCapacity = value;
                }
            }

        }

        public Room(string name,double price,int personCapacity)
        {
            _id++;
            Id = _id;
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
        }

       

        public override string ToString()
        {
            return $"Name: {Name}\nPrice: {Price}\nPerson Capacity: {PersonCapacity}";  
        }



    }
}
