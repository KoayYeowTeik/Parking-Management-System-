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
        public GantrySystem(List<ParkingRecord> parkRecords)
        {
            this.parkRecords = parkRecords;
        }
        public void AddRecord() { }
        public decimal CalculateCharge()
        {
            return 0;
        }
        public decimal CalculateRevenue()
        {
            return 0;
        }
        public void UpdateParkingRecord(int id)
        {
            
        }
        public bool CheckPass()
        {
            return false;
        }
        public void RemoveRecord(int id)
        {

        }
    }
}
