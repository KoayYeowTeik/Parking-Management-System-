using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem
{
	public class ExpiredState : PPState
	{
		private ParkingPass myParkingPass;

		public ExpiredState(ParkingPass myParkingPass)
		{
			this.myParkingPass = myParkingPass;
		}

		public void enterCarpark()
		{
			Console.WriteLine("Parking pass is expired");
		}

		public void exitCarpark()
		{
			Console.WriteLine("Parking pass is expired");
		}

		public void terminate(string reason)
		{
			Console.WriteLine(reason);
			myParkingPass.setState(myParkingPass.TerminatedState);
			myParkingPass.RefundRemainingPass();
		}

		public void renew()
		{
			//implementation
			myParkingPass.setState(myParkingPass.ValidState);
		}
	}
}
