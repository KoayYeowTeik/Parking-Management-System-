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
			Console.WriteLine(reason);
			myParkingPass.setState(myParkingPass.TerminatedState);
			myParkingPass.RefundRemainingPass();
		}

		public void renew()
		{
			Console.WriteLine("You cannot renew your pass yet. It is still a valid pass!");
		}
	}
}
