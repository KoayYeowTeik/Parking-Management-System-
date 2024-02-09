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

		public void approvePass(MonthlyPassCollection collection)
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

		public void terminate(string reason, MonthlyPassCollection collection)
		{
			Console.WriteLine(reason);
			myParkingPass.setState(myParkingPass.TerminatedState, collection);
			Console.WriteLine("The pass is now terminated.");
		}

		public void renew(MonthlyPassCollection collection)
		{
			if (myParkingPass.passType == "Daily")
			{
				myParkingPass.endDateTime.AddDays(1);
				myParkingPass.setState(myParkingPass.ValidState, collection);
				Console.WriteLine("Daily season parking pass has been renewed.");
			}
		}
	}
}
