using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem
{
	public class MonthlyPassCollection : Subject
	{
		private List<ParkingPass> currentPass;
		private List<ParkingPass> waitingList;
		private List<Observer> observers;
		public int availablePasses = 0;

		public MonthlyPassCollection()
		{
			currentPass = new List<ParkingPass>();
			waitingList = new List<ParkingPass>();
			observers = new List<Observer>();
		}

		public void addObserver(Observer observer)
		{
			observers.Add(observer);
		}

		public void removeObserver(Observer observer)
		{
			observers.Remove(observer);
		}

		public void notifyObservers()
		{
			foreach (Observer o in observers)
			{
				o.Update(availablePasses);
			}
		}

		public void addToCurrentPass(ParkingPass pass, Observer observer)
		{
			observers.Add(observer);
			currentPass.Add(pass);
			availablePasses--;
			notifyObservers();
		}

		public void removeFromCurrentPass(ParkingPass pass, Observer observer)
		{
			observers.Remove(observer);
			currentPass.Remove(pass);
			availablePasses++;
			notifyObservers();
		}

		public void addToWaitList(ParkingPass Pass, Observer observer)
		{
			observers.Remove(observer);
			waitingList.Add(Pass);
		}

		public void removeFromWaitList(ParkingPass Pass, Observer observer)
		{
			observers.Remove(observer);
			waitingList.Remove(Pass);
		}
	}
}
