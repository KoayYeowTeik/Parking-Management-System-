using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem
{
	public class ProcessingState : PPState
	{
		private ParkingPass myParkingPass;

		public void approvePass(MonthlyPassCollection collection)
		{
			if (myParkingPass.passType == "Daily")
			{
				myParkingPass.setState(myParkingPass.ValidState, collection);
				Console.WriteLine("Parking pass is now valid state from processing state.");
			}
			else if (myParkingPass.passType == "Monthly")
			{
				if (collection.availablePasses == 0)
				{
					collection.addToWaitList(myParkingPass);
					Console.WriteLine("Pass is added to waiting list.");
				}
				else if (collection.availablePasses > 0)
				{
					collection.addToCurrentPass(myParkingPass);
					myParkingPass.setState(myParkingPass.ValidState, collection);
					Console.WriteLine("Pass is added to current list and is now valid.");
				}
			}
		}

		public ProcessingState(ParkingPass parkingPass)
		{
			myParkingPass = parkingPass;
		}

		public void enterCarpark()
		{
			Console.WriteLine("Parking pass is being processed");
		}

		public void exitCarpark()
		{
			Console.WriteLine("Parking pass is being processed");
		}

		public void terminate(string reason, MonthlyPassCollection collection)
		{
			Console.WriteLine("Parking pass is being processed");
		}

		public void renew(MonthlyPassCollection collection)
		{
			Console.WriteLine("Parking pass is being processed");
		}
	}
}
