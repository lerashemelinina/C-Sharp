using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
     abstract class Building
    {
        public Building(int totalFloors, bool isElevator)
        {
            TotalFloors = totalFloors;
            IsElevator = isElevator;
        }


        public int TotalFloors { get; set; }
        public bool IsElevator { get; set; }


       

        public virtual string GetDetails()
        {
            return $"occupancy is: {TotalFloors}, has elevator: {IsElevator}";
        }
    }
}
