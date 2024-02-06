using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem
{
    public class ParkingRecord
    {
        // Properties with private setters for encapsulation
        public int Id { get; private set; }
        public Vehicle Vehicle { get; private set; }
        public DateTime EntryDateTime { get; private set; }
        public DateTime ExitDateTime { get; private set; }
        public decimal AmountCharged { get; private set; }
        public Carpark Carpark { get; private set; }

        public ParkingRecord() { }

        // Constructor to initialize all properties
        public ParkingRecord(int id, Vehicle vehicle, DateTime entryDateTime, DateTime exitDateTime, decimal amountCharged, Carpark carpark)
        {
            Id = id;
            Vehicle = vehicle;
            EntryDateTime = entryDateTime;
            ExitDateTime = exitDateTime;
            AmountCharged = amountCharged;
            Carpark = carpark;
        }

        // Method to check if the vehicle is currently parked
        public bool IsParked()
        {
            // Assuming that if the exit date time is default, the vehicle is still parked
            return ExitDateTime == default(DateTime);
        }

        // Method to check if the vehicle has exited
        public bool IsExited()
        {
            // Assuming that if the exit date time is set, the vehicle has exited
            return ExitDateTime != default(DateTime);
        }
    }
}

