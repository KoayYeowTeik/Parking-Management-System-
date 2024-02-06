using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem
{
    public class Vehicle
    {
        public string LicensePlate { get; private set; }
        public VehicleType Type { get; private set; }
        public ParkingPass ParkingPass { get; set; } 
        public List<ParkingPass> ParkingPassList { get; set; }


        // Constructor to set the license plate and vehicle type upon creation
        public Vehicle(string licensePlate, VehicleType type)
        {
            LicensePlate = licensePlate;
            Type = type;
        }
    }
}
