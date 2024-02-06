using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem
{
    public class User
    {
        public int id { get;set; }
        public string name { get;set; }
        public UserType userType { get;set; }
        public string mobileNumber { get;set; }
        public string username { get;set; }
        public string password { get;set; }
        public List<Vehicle> vehicleList { get;set; }
        public User() { }
        public User(int id, string name, UserType userType, string mobileNumber, string username, string password, List<Vehicle> vehicleList)
        {
            this.id = id;
            this.name = name;
            this.userType = userType;
            this.mobileNumber = mobileNumber;
            this.username = username;
            this.password = password;
            this.vehicleList = vehicleList;
        }
        public bool MakePayment()
        {
            return false;
        }
    }
}
