using System;
using ClassLibrary;
namespace exceptionClasswork
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel();
            hotel.Name = "baku";

            Room room1 = new Room("vip", 200, 2);
            Console.WriteLine(room1.Id);

        }
    }
}
