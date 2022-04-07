using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
   public  class Hotel
    {
        public string Name { get; set; }
        Room[] _rooms = new Room[0];
        public Room[] Rooms { get => _rooms; }
        public void AddRoom(Room room)
        {
            Array.Resize(ref _rooms, _rooms.Length + 1);
            _rooms[_rooms.Length - 1] = room;
        }
        public bool MakeReservation(int? roomId)
        {
            return true;
        }


    }
}
