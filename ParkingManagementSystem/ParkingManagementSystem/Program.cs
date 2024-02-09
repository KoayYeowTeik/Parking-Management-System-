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
            MonthlyPassCollection monthlyPassCollection= new MonthlyPassCollection();
            SeasonPassManager passManager = new SeasonPassManager();
            ParkingRecord parkingRecord = new ParkingRecord();

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nParking Management System - Menu");
                Console.WriteLine("1. Terminate Season Pass");
                Console.WriteLine("2. Renew Season Pass");
                Console.WriteLine("3. Make Payment");
                Console.WriteLine("4. Apply Season Pass");
                Console.WriteLine("5. Enter Carpark");
                Console.WriteLine("6. Leave Carpark");
                Console.WriteLine("8. Exit");
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

                        passManager.TerminateSeasonPass(user, passId, reason, monthlyPassCollection);
                        break;

                    //UC-004 Koay Yeow Teik (Renew Season Pass)
                    case 2:
                        Console.Write("Enter UserID : "); int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Season passes of the user is displayed here");
                        Console.Write("Enter Parking Pass to renew : "); int passid = Convert.ToInt32(Console.ReadLine());
                        while (true)
                        {
                            // create fake pass to extend the date by
                            ParkingPass pass1 = new ParkingPass(
                         passid,
                         DateTime.Now, // Assuming start date is now
                         DateTime.Now.AddDays(30),
                         "Monthly",
                         id
                         //assume pass was made recently 
                     ) ;
                            User user1 = new User
                            {
                                id = id,
                                name = "Default Name",
                                userType = UserType.STUDENT, 
                                mobileNumber = "000-000-0000",
                                username = "defaultUser",
                                password = "defaultPassword",
                                vehicleList = new List<Vehicle>()
                            {
                                new Vehicle("ABC123", VehicleType.CAR) // Example license plate and vehicle type
                                {
                                    ParkingPassList = new List<ParkingPass>() {  }
                                }
                            }
                            };
                            if (user1.MakePayment())
                            {
                                Console.WriteLine("Payment confirmed");
                                pass1.endDateTime.AddDays(30);
                                return;
                            }
                            Console.WriteLine("End of use case");
                        }                        
                        break;
                    case 3:
                        // Add logic for making a payment
                        MakePayment();
                        break;
                    case 4:
                        // Add logic for applying for a season pass
                        ApplySeasonPass(monthlyPassCollection);
                        break;
                    case 6:
                        //logic
                        parkingRecord.EntryDateTime = DateTime.Now;
                        //create mock vehicle
                        parkingRecord.Vehicle = new Vehicle("ABC123", VehicleType.CAR);
                        //create mock carpark
                        parkingRecord.Carpark = new Carpark { carparkNumber = 1, location = "lot1" };
                        parkingRecord.EntryDateTime = DateTime.Now;
                        parkingRecord.Pass = new ParkingPass { passType = "Daily" }; //assume that parking pass is daily
                        parkingRecord.Status = "Parked";
                        parkingRecord.IsParked();
                        break;

                    case 7:
                        //logic
                        if (parkingRecord.EntryDateTime == null)
                        {
                            Console.WriteLine("Vehicle has not been parked yet.");
                            break;
                        }
                        else
                        {
                            parkingRecord.ExitDateTime = DateTime.Now;
                            parkingRecord.calculateCharges();
                            parkingRecord.addRecord();
                            parkingRecord.IsExited();
                            break;
                        }
                    case 8:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }

        static bool MakePayment()
        {
            return true;
        }

		static void ApplySeasonPass(MonthlyPassCollection collection) //Bi De
		{
			//System prompts for the user to choose between Monthly and Daily season parking pass
			Console.WriteLine("Daily/Monthly season parking pass: ");
			//User selects
			string passType = Console.ReadLine();

			if (passType == "Daily") // User selects to apply for daily season parking pass
			{
				Console.WriteLine("Please enter your name: ");
				string name = Console.ReadLine();
				Console.WriteLine("Please enter your NP ID: ");
				int userID = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Please enter your username: ");
				string username = Console.ReadLine();
				Console.WriteLine("Please enter your password: ");
				string password = Console.ReadLine();
				Console.WriteLine("Please enter your mobile number: ");
				string mobileNo = Console.ReadLine();
				Console.WriteLine("Please enter your start month: ");
				DateTime startDate = Convert.ToDateTime(Console.ReadLine());
				Console.WriteLine("Please enter your end month: ");
				DateTime endDate = Convert.ToDateTime(Console.ReadLine());
				Console.WriteLine("Please enter your payment mode: ");
				string paymentMethod = Console.ReadLine();
				Console.WriteLine("Please enter your license plate: ");
				string licensePlate = Console.ReadLine();
				Console.WriteLine("Please enter your IU number: ");
				string iuNumber = Console.ReadLine();
				Console.WriteLine("Please enter your car type: ");
				string carType = Console.ReadLine();
				//User provides the system with all the information required

				//System executes payment use case
				bool payment = MakePayment();

				//System creates parking pass in processing state
                if (payment == true)
                {
					int id = 1;
					ParkingPass parkingPass = new ParkingPass(id, startDate, endDate, passType, userID);

					//System displays successful application
					Console.WriteLine("Daily season pass has been created");
				}
                else if (payment == false)
                {
                    Console.WriteLine("failed payment");
                }
			}

			else if (passType == "Monthly") // User selects to apply for monthly season parking pass
			{
                if (collection.availablePasses > 0)//System detects there are available monthly season passes
				{
                    Console.WriteLine("Please enter your name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Please enter your NP ID: ");
                    int userID = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter your username: ");
                    string username = Console.ReadLine();
                    Console.WriteLine("Please enter your password: ");
                    string password = Console.ReadLine();
                    Console.WriteLine("Please enter your mobile number: ");
                    string mobileNo = Console.ReadLine();
                    Console.WriteLine("Please enter your start month: ");
                    DateTime startDate = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Please enter your end month: ");
                    DateTime endDate = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Please enter your payment mode: ");
                    string paymentMethod = Console.ReadLine();
                    Console.WriteLine("Please enter your license plate: ");
                    string licensePlate = Console.ReadLine();
                    Console.WriteLine("Please enter your IU number: ");
                    string iuNumber = Console.ReadLine();
                    Console.WriteLine("Please enter your car type: ");
                    string carType = Console.ReadLine();
					//User provides the system with all the information required

					//System executes payment use case
                    bool payment = MakePayment();

                    if (payment == true)
                    {
						//System creates parking pass in processing state
						int id = 1;
						ParkingPass parkingPass = new ParkingPass(id, startDate, endDate, passType, userID);
						Console.WriteLine("Monthly season parking pass has been created.");
					}
                    else if (payment == false)
                    {
                        Console.WriteLine("Use case ends");
                    }
				}
				else if (collection.availablePasses == 0)
                {
                    //System prompts user to sign up for waiting list
                    Console.WriteLine("Do you want to sign up for waiting list?(Y/N) ");
                    string option = Console.ReadLine();

                    if (option == "Y") //User wants to sign up for waiting list
                    {
						Console.WriteLine("Please enter your name: ");
						string name = Console.ReadLine();
						Console.WriteLine("Please enter your NP ID: ");
						int userID = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine("Please enter your username: ");
						string username = Console.ReadLine();
						Console.WriteLine("Please enter your password: ");
						string password = Console.ReadLine();
						Console.WriteLine("Please enter your mobile number: ");
						string mobileNo = Console.ReadLine();
						Console.WriteLine("Please enter your start month: ");
						DateTime startDate = Convert.ToDateTime(Console.ReadLine());
						Console.WriteLine("Please enter your end month: ");
						DateTime endDate = Convert.ToDateTime(Console.ReadLine());
						Console.WriteLine("Please enter your payment mode: ");
						string paymentMethod = Console.ReadLine();
						Console.WriteLine("Please enter your license plate: ");
						string licensePlate = Console.ReadLine();
						Console.WriteLine("Please enter your IU number: ");
						string iuNumber = Console.ReadLine();
						Console.WriteLine("Please enter your car type: ");
						string carType = Console.ReadLine();
						//User provides the system with all the information required

						//System executes payment use case
						bool payment = MakePayment();

                        if (payment == true)
                        {
							//System creates parking pass in processing state
							int id = 1;
							ParkingPass parkingPass = new ParkingPass(id, startDate, endDate, passType, userID);
							//collection.addToWaitList(parkingPass);
							Console.WriteLine("Monthly season parking pass has been created");
						}
                        else if (payment == false)
                        {
                            Console.WriteLine("Use case ends");
                        }
					}
                    else if (option == "N") //User does not want to sign up for waiting list
                    {
						Console.WriteLine("Use case ends");
					}
                }
			}
		}
	}
}