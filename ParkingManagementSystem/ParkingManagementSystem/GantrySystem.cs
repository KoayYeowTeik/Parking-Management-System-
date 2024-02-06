using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem
{
    public class GantrySystem
    {
        public List<ParkingRecord> parkRecords { get; set; }
        public GantrySystem() { }   
        
        public string VehicleType { get; set; }

        public DateTime EntryTime { get; set; }

        public DateTime ExitTime { get; set; }

        public double Rate { get; set; }

        public string Pass { get; set; }

        public GantrySystem(List<ParkingRecord> parkRecords)
        {
            this.parkRecords = parkRecords;
        }
        public void AddRecord() 
        { 
            
        
        }
        public decimal CalculateCharge(string vehicleType, DateTime EntryTime, DateTime ExitTime, Double rate, string pass)
        {
            decimal totalCharge = 0;
            VehicleType = VehicleType;
            this.EntryTime = EntryTime;
            this.ExitTime = ExitTime;
            Rate = rate;
            Pass = pass;

            bool isValid = CheckPass(pass);

            //get the parking pass if it exists, if daily pass calculate based on maximum rate, otherwise charge normally.
            
            //implementation
            return totalCharge;
        }
        public decimal CalculateRevenue()
        {
            return 0;
        }
        public void UpdateParkingRecord(int id)
        {
            
        }
        public bool CheckPass(string)
        {
            //implementation
            return false;
        }
        public void RemoveRecord(int id)
        {

        }
    }
}
