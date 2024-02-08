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

		public void approvePass()
		{
			if (myParkingPass.passType == "Daily")
			{
				myParkingPass.setState(myParkingPass.ValidState);
				Console.WriteLine("Parking pass is now valid state from processing state.");
			}
			else if (myParkingPass.passType == "Monthly")
			{
				
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

		public void terminate(string reason)
		{
			Console.WriteLine("Parking pass is being processed");
		}

		public void renew()
		{
			Console.WriteLine("Parking pass is being processed");
		}
	}
}
