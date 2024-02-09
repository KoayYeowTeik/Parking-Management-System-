using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem
{
	public class MonthlyPassCollection
	{
		private List<ParkingPass> currentPass;
		private List<ParkingPass> waitingList;
		public int availablePasses = 100;

		public MonthlyPassCollection()
		{
			currentPass = new List<ParkingPass>();
			waitingList = new List<ParkingPass>();
		}

		public void addToCurrentPass(ParkingPass pass)
		{
			currentPass.Add(pass);
			availablePasses--;
		}

		public void removeFromCurrentPass(ParkingPass pass)
		{
			currentPass.Remove(pass);
			availablePasses++;
		}

		public void addToWaitList(ParkingPass Pass)
		{
			waitingList.Add(Pass);
		}

		public void removeFromWaitList(ParkingPass Pass)
		{
			waitingList.Remove(Pass);
		}
	}
}
