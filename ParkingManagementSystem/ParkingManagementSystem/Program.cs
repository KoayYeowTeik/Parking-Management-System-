namespace ParkingManagementSystem
{
	public class Program
	{
		static void Main()
		{

		}

		void ApplySeasonPass()
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
				DateTime startDate = Convert.ToDateTime(applicationInfo[5]);
				DateTime endDate = Convert.ToDateTime(applicationInfo[6]); 
				ParkingPass parkingPass = new ParkingPass(id, startDate, endDate, passType);

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