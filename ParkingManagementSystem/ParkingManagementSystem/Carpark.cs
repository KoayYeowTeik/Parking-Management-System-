using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem
{
    public class Carpark
    {
        public List<ParkingLot> lotList { get; set; }
        public string location { get; set; }
        public string description { get; set; }
        public int carparkNumber { get; set; }
        public Carpark() { }
        public Carpark(List<ParkingLot> lotList, string location, string description, int carparkNumber)
        {
            this.lotList = lotList;
            this.location = location;
            this.description = description;
            this.carparkNumber = carparkNumber;
        }
    }
}
