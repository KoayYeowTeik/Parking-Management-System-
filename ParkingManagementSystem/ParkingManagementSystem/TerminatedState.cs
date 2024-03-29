﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem
{
	public class TerminatedState : PPState
	{
		private ParkingPass myParkingPass;

		public void approvePass(MonthlyPassCollection collection)
		{
			Console.WriteLine("Parking pass is terminated");
		}

		public TerminatedState(ParkingPass myParkingPass)
		{
			this.myParkingPass = myParkingPass;
		}

		public void enterCarpark()
		{
			Console.WriteLine("Parking pass is terminated");
		}

		public void exitCarpark()
		{
			Console.WriteLine("Parking pass is terminated");
		}

		public void terminate(string reason, MonthlyPassCollection collection)
		{
			Console.WriteLine("Your parking pass has been terminated already");
		}

		public void renew(MonthlyPassCollection collection)
		{
			Console.WriteLine("You cannot renew as your parking pass has been terminated");
		}
	}
}
