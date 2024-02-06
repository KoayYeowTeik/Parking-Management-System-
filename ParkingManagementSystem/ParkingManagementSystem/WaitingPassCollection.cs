using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem
{
    public class WaitingPassCollection
    {
        public List<Monthly> waitingPass;
        public WaitingPassCollection() { }
        public WaitingPassCollection(List<Monthly> waitingPass) {  this.waitingPass = waitingPass; }
        public void AddWaitingPass() { }
    }
}
