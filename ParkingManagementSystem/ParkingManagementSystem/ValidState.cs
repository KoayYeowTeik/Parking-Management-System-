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

		public void approvePass()
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

		public void terminate(string reason)
		{
			if (myParkingPass.passType == "Daily")
			{
				myParkingPass.setState(myParkingPass.TerminatedState);
				Console.WriteLine(reason);
			}
			else if (myParkingPass.passType == "Monthly")
			{
				myParkingPass.setState(myParkingPass.TerminatedState);
				myParkingPass.RefundRemainingPass();
				//available passes += 1
				Console.WriteLine(reason);
			}
			myParkingPass.setState(myParkingPass.TerminatedState);
			myParkingPass.RefundRemainingPass();
		}

		public void renew()
		{
			if (myParkingPass.passType == "Monthly")
			{
				//available passes += 1
				myParkingPass.setState(myParkingPass.ProcessingState);
				Console.WriteLine("Parking pass is renewed and now in processing state.");
			}
			Console.WriteLine("You cannot renew your pass yet. It is still a valid pass!");
		}
	}
}
