using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Usecase 002 implementation - Hadith Mukrish (s10221013)
namespace ParkingManagementSystem
{
    public class ParkingRecord
    {
        // Properties with private setters for encapsulation
        public int Id { get;  set; }
        public Vehicle Vehicle { get;  set; }
        public DateTime? EntryDateTime { get;  set; }
        public DateTime? ExitDateTime { get;  set; }
        public decimal AmountCharged { get;  set; }
        public Carpark Carpark { get;  set; }
        public ParkingPass Pass { get; set; }
        public string Status { get; set; }

        public ParkingRecord() { }

        // Constructor to initialize all properties
        public ParkingRecord(int id, Vehicle vehicle, DateTime entryDateTime, DateTime exitDateTime, decimal amountCharged, Carpark carpark, string status)
        {
            Id = id;
            Vehicle = vehicle;
            EntryDateTime = entryDateTime;
            ExitDateTime = exitDateTime;
            AmountCharged = amountCharged;
            Carpark = carpark;
            Status = status;
        }
        //method to calculate charges
        public bool addRecord()
        {
            
            bool isParked = IsParked();
            bool isExited = IsParked();
            decimal amountCharge = calculateCharges();
            //if successful, return true
            if (isParked && isExited)
            {
                //implementation to store in the database

                Console.WriteLine("Parking record has been stored");
            }
            else
            {
                Console.WriteLine("Parking record has not been stored");
            }

            
            return true;
        }

        public bool removeRecord()
        {
            //implementation
            return true;
        }
        // Method to check if the vehicle is currently parked
        public bool IsParked()
        {
            // Assuming that if the exit date time is default, the vehicle is still parked
            if(ExitDateTime == null && EntryDateTime != null)
            {
                Console.WriteLine("Car has been set to \"parked\"");
                return true;
            }
            return ExitDateTime == default(DateTime);
        }

        // Method to check if the vehicle has exited
        public bool IsExited()
        {
            // Assuming that if the exit date time is set, the vehicle has exited
            if (ExitDateTime != null)
            {
                return true;
            }
            return ExitDateTime != default(DateTime);
        }

        public decimal calculateCharges()
        {
            checkPass();
            if (Pass.passType == "Monthly")
            {
                Console.WriteLine("Amount has been charged for monthly pass");
                return 0;
            }
            else if (Pass.passType == "Daily")
            {
                decimal amount = 0;
                //implementation to get daily pass rate and vehicle type then calculate charges
                Console.WriteLine("Amount has been charged for daily pass");
                return amount;
            }
            else
            {
                decimal amount = 0;
                //implementation to get amount charges with vehicle type
                Console.WriteLine("Amount has been charged for no pass");
                return amount;
            }
        }

        public void checkPass ()
        {
            //get parking pass implementation
            Console.WriteLine($"passtype is {Pass.passType}");
        }

    }
}

