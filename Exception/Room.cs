using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
   public  class Room
    {
        public Room()
        {
            _id++;
            Id = _id;
        }
        public Room(string name, double price, int personCapacity)
        {
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
        } 
        static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCapacity { get; set; }

    }
}
