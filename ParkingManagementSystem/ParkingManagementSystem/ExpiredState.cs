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

		public void approvePass()
		{
			Console.WriteLine("Parking pass is expired");
		}

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
			myParkingPass.isParked = false;
		}

		public void terminate(string reason)
		{
			Console.WriteLine(reason);
			myParkingPass.setState(myParkingPass.TerminatedState);
			CurrentPassCollection currentPassCollection = new CurrentPassCollection();
			//myParkingPass.RefundRemainingPass();
		}

		public void renew()
		{
			if (myParkingPass.passType == "Daily")
			{
				myParkingPass.endDateTime.AddDays(1);
				myParkingPass.setState(myParkingPass.ValidState);
				Console.WriteLine("Daily season parking pass has been renewed.");
			}
		}
	}
}
