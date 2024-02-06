using System.Text;
using System.Threading.Tasks;
using ParkingManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
// Use Case - 001 Implementation, Javier

namespace ParkingManagementSystem
{

    public class SeasonPassManager
    {
        public List<ParkingPass> WaitingList { get; set; }
        public int MaxPassCount { get; set; }
        public List<ParkingPass> CurrentList { get; set; }

        public SeasonPassManager()
        {
            WaitingList = new List<ParkingPass>();
            CurrentList = new List<ParkingPass>();
            MaxPassCount = 100; // Example max count
        }

        public void TerminateSeasonPass(User user, int passId, string reason)
        {
            // Assuming each Vehicle in vehicleList can have a ParkingPass
            var pass = user.vehicleList.SelectMany(v => v.ParkingPassList)
                                       .FirstOrDefault(p => p.id == passId);
            if (pass == null || pass.status != MonthlyPassStatus.VALID)
            {
                Console.WriteLine("No valid season parking pass found.");
                return;
            }

            if (pass.endDateTime < DateTime.Now)
            {
                Console.WriteLine("The pass has already expired and cannot be terminated.");
                return;
            }

            pass.status = MonthlyPassStatus.TERMINATED;
            Console.WriteLine($"Parking pass {pass.id} has been terminated.");

            if (pass.paymentMode == PaymentMode.DEBIT)
            {
                ProcessRefund(pass);
            }

            UpdateAvailablePassesCount();
            SendConfirmation(user);
        }

        private void ProcessRefund(ParkingPass pass)
        {
            // Implement refund logic
        }

        private void UpdateAvailablePassesCount()
        {
            // Implement logic to update available passes count
        }

        private void SendConfirmation(User user)
        {
            // Implement logic to send confirmation
        }
    }
}





