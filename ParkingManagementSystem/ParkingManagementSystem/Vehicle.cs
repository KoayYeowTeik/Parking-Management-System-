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
        public string IUNumber { get; set; }
        public ParkingPass ParkingPass { get; set; } // Assuming ParkingPass is defined elsewhere

        // Constructor to set the license plate and vehicle type upon creation
        public Vehicle(string licensePlate, VehicleType type, string iuNumber)
        {
            LicensePlate = licensePlate;
            Type = type;
            IUNumber = iuNumber;
        }

        // Additional methods and properties related to the Vehicle can be added here
    }
}
