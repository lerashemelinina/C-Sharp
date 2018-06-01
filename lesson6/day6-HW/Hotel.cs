using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Hotel: Building
    {

        public Hotel(int totalFloors, bool isElevator) : base(totalFloors, isElevator)
        {
            TotalRooms = totalFloors * 20;
            OccupiedRooms = TotalRooms * 65 / 100;
         
        }

        public int  TotalRooms;
        public int OccupiedRooms;
        public Countries HotelCountry;
        public Services[] HotelServices = new Services[3];

        public override string GetDetails()
        {
            return $"this is Hotel has {TotalRooms} rooms, occupaied rooms: {OccupiedRooms}";
        }






    }
}
