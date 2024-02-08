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

                        string passType = "Daily";
                        // Create a ParkingPass object with the specified ID and other details
                        ParkingPass pass = new ParkingPass(
                            passId,
                            DateTime.Now, // Assuming start date is now
                            DateTime.Now.AddDays(30),
                            passType,
                            userId
                            // Assuming end date is 30 days from now
                            //false, // Assuming the vehicle is not parked
                            //PaymentMode.DEBIT // Assuming the payment mode is DEBIT
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

		void ApplySeasonPass() //Bi De
		{
			//System prompts for the user to choose between Monthly and Daily season parking pass
			Console.WriteLine("Daily/Monthly season parking pass: ");
			//User selects
			string passType = Console.ReadLine();

			if (passType == "Daily") // User selects to apply for daily season parking pass
			{
				//System prompts for the user to provide their name, student/staff id, username, password, mobile number, start month, end month, payment mode, license plate number, IU number and vehicle type
				Console.WriteLine("Please input your name, id, username, password, mobile number, start month, end month, payment mode, license plate number, IU number and vehicle type. (Separated by ,) ");
				//User provides the system with all the information required
				string collatedInfo = Console.ReadLine();
				string[] applicationInfo = collatedInfo.Split(",");

				//System executes payment use case
				string paymentMethod = applicationInfo[7];
				//bool payment = MakePayment(paymentMethod);

				//System creates parking pass in processing state
				int id = Convert.ToInt32(DateTime.Now);
                int userID = Convert.ToInt32(applicationInfo[1]);
				DateTime startDate = Convert.ToDateTime(applicationInfo[5]);
				DateTime endDate = Convert.ToDateTime(applicationInfo[6]);
				ParkingPass parkingPass = new ParkingPass(id, startDate, endDate, passType, userID);

				//System displays successful application
				Console.WriteLine("Successful application");
			}

			else if (passType == "Monthly") // User selects to apply for monthly season parking pass
			{
				//System detects there are available monthly season passes


			}
		}
	}
}