using System.Text;
using System.Threading.Tasks;
using ParkingManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ParkingManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            SeasonPassManager passManager = new SeasonPassManager();

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nParking Management System - Menu");
                Console.WriteLine("1. Terminate Season Pass");
                Console.WriteLine("2. Renew Season Pass");
                Console.WriteLine("3. Make Payment");
                Console.WriteLine("4. Apply Season Pass");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter user ID: ");
                        int userId = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter pass ID: ");
                        int passId = Convert.ToInt32(Console.ReadLine());

                        // Create a ParkingPass object with the specified ID and other details
                        ParkingPass pass = new ParkingPass(
                            passId,
                            DateTime.Now, // Assuming start date is now
                            DateTime.Now.AddDays(30), // Assuming end date is 30 days from now
                            false, // Assuming the vehicle is not parked
                            PaymentMode.DEBIT // Assuming the payment mode is DEBIT
                        );

                        // Create a mock user and add the ParkingPass to a vehicle in their list
                        User user = new User
                        {
                            id = userId,
                            name = "Default Name",
                            userType = UserType.STUDENT, // Assuming UserType is an enum
                            mobileNumber = "000-000-0000",
                            username = "defaultUser",
                            password = "defaultPassword",
                            vehicleList = new List<Vehicle>()
                            {
                                new Vehicle("ABC123", VehicleType.CAR) // Example license plate and vehicle type
                                {
                                    ParkingPassList = new List<ParkingPass>() { pass }
                                }
                            }
                        };

                        Console.WriteLine("Enter reason for termination: ");
                        string reason = Console.ReadLine();

                        passManager.TerminateSeasonPass(user, passId, reason);
                        break;
                    case 2:
                        // Add logic for renewing a season pass
                        break;
                    case 3:
                        // Add logic for making a payment
                        break;
                    case 4:
                        // Add logic for applying for a season pass
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }
    }
}