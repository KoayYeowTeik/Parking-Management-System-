using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem
{
    public class ParkingRecord
    {
        public int id { get; set; }
        public Vehicle vehicle { get; set; }
        public DateTime entryDateTime { get; set; }
        public DateTime exitDateTime { get; set; }
        public decimal amountCharged { get; set; }
        public Carpark carpark { get; set; }
        public PaymentMode paymentMode { get; set; }
        public ParkingRecord() { }
        public ParkingRecord(int id, Vehicle vehicle, DateTime entryDateTime, DateTime exitDateTime, decimal amountCharged, Carpark carpark, PaymentMode paymentMode)
        {
            this.id = id;
            this.vehicle = vehicle;
            this.entryDateTime = entryDateTime;
            this.exitDateTime = exitDateTime;
            this.amountCharged = amountCharged;
            this.carpark = carpark;
            this.paymentMode = paymentMode;
        }
        public bool IsParked()
        {
            return false;
        }
        public bool IsExited()
        {
            return false;
        }
    }
}
