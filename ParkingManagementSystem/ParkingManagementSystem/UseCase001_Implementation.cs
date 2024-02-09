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

        public void TerminateSeasonPass(User user, int passId, string reason, MonthlyPassCollection collection)
        {
            var pass = user.vehicleList.SelectMany(v => v.ParkingPassList)
                                       .FirstOrDefault(p => p.id == passId);
            if (pass == null)
            {
                Console.WriteLine("No season parking pass found.");
                return;
            }

            // Check if the pass is already expired using the endDateTime
            if (pass.endDateTime < DateTime.Now)
            {
                Console.WriteLine("The pass has already expired and cannot be terminated.");
                return;
            }

            // Terminate the pass
            pass.terminate(reason, collection);
            Console.WriteLine($"Parking pass {pass.id} has been terminated.");

            // To check if there are remaining days on the pass
            TimeSpan remainingDuration = pass.endDateTime - DateTime.Now;
            if (remainingDuration.TotalDays > 0)
            {
                ProcessRefund(pass);
            }

            UpdateAvailablePassesCount();
            SendConfirmation(user);
        }

        private void ProcessRefund(ParkingPass pass)
        {
            Console.WriteLine("Pass has been refunded");
        }

        private void UpdateAvailablePassesCount()
        {
            // Implementation
        }

        private void SendConfirmation(User user)
        {
            Console.WriteLine("Your pass has been terminated successfully, thank you.");
        }
    }
}





