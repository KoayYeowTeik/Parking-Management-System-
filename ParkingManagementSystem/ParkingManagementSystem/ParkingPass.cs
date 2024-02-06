using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem
{
    public class ParkingPass
    {
        public int id { get; set; }
        public DateTime startDateTime { get; set; }
        public DateTime endDateTime { get; set; }
        public MonthlyPassStatus status { get; set; }
        public PaymentMode paymentMode { get; set; }
        public ParkingPass() { }
        public ParkingPass(int id, DateTime startDateTime, DateTime endDateTime, MonthlyPassStatus status, PaymentMode paymentMode)
        {
            this.id = id;
            this.startDateTime = startDateTime;
            this.endDateTime = endDateTime;
            this.status = status;
            this.paymentMode = paymentMode;
        }
        public bool TerminatePass(int id)
        {
            return false;
        }
        public bool ChangeStatus()
        {
            return false;
        }
        public bool RefundRemainingPass()
        {
            return false;
        }
    }
}
