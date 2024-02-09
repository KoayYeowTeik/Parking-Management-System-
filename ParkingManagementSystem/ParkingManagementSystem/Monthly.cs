using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem
{
    public class Monthly : ParkingPass
    {
        public int passLeft { get; set; }
        public Monthly() { }
        public Monthly(int passLeft)
        {
            this.passLeft = passLeft;
        }
        public void NotifyObservers() { }
        public void AddObservers() { }
        public void RemoveObservers() { }   
        public List<Monthly> GetWaitingList() { return new List<Monthly>(); }
        public void UpdateStatus() { }

    }
}
