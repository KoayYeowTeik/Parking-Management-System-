using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem
{
	public class ValidState : PPState
	{
		private ParkingPass myParkingPass;

		public void approvePass(MonthlyPassCollection collection)
		{
			Console.WriteLine("Parking pass is valid");
		}

		public ValidState(ParkingPass parkingPass)
		{
			myParkingPass = parkingPass;
		}

		public void enterCarpark()
		{
			myParkingPass.isParked = true;
		}

		public void exitCarpark()
		{
			myParkingPass.isParked = false;
		}

		public void terminate(string reason, MonthlyPassCollection collection)
		{
			if (myParkingPass.passType == "Daily")
			{
				myParkingPass.setState(myParkingPass.TerminatedState, collection);
				Console.WriteLine(reason);
			}
			else if (myParkingPass.passType == "Monthly")
			{
				myParkingPass.setState(myParkingPass.TerminatedState, collection);
				myParkingPass.RefundRemainingPass();
				collection.removeFromCurrentPass(myParkingPass);
				Console.WriteLine(reason);
			}
		}

		public void renew(MonthlyPassCollection collection)
		{
			if (myParkingPass.passType == "Monthly")
			{
				collection.removeFromCurrentPass(myParkingPass);
				myParkingPass.setState(myParkingPass.ProcessingState, collection);
				Console.WriteLine("Parking pass is renewed and now in processing state.");
			}
			Console.WriteLine("You cannot renew your pass yet. It is still a valid pass!");
		}
	}
}
