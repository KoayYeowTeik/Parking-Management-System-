using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem
{
	public class Applicants : Observer
	{
		private Subject monthlyPassCollection;
		public string name;
		public int npID;
		public string username;
		public string password;
		public string mobileNumber;
		public DateTime startDate;
		public DateTime endDate;
		public string paymentMode;
		public string licensePlate;
		public string iuNumber;
		public string carType;

		public Applicants(Subject mpc, string name, int npID, string username, string password, string mobileNumber, DateTime startDate, DateTime endDate, string paymentMode, string licensePlate, string iuNumber, string carType)
		{
			this.monthlyPassCollection = mpc;
			monthlyPassCollection.addObserver(this);
			this.name = name;
			this.npID = npID;
			this.username = username;
			this.password = password;
			this.mobileNumber = mobileNumber;
			this.startDate = startDate;
			this.endDate = endDate;
			this.paymentMode = paymentMode;
			this.licensePlate = licensePlate;
			this.iuNumber = iuNumber;
			this.carType = carType;
		}

		public void Update(int passesLeft)
		{
			
		}
	}
}
