using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem
{
    public class ParkingLot
    {
        public int id { get; set; }
        public VehicleType vehicle { get; set; }
        public bool occupied { get; set; }
       
        public ParkingLot() { } 
        public ParkingLot(int id, VehicleType vehicle)
        {
            this.id = id;
            this.vehicle = vehicle;
            this.occupied = false;
        }
        public string GetLocationDescription()
        {
            return null;
        }
    }
}
