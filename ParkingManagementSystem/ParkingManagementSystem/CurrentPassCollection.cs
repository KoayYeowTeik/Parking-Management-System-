using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem
{
    public  class CurrentPassCollection
    {
        public List<Monthly> currentPass;
        public CurrentPassCollection() { }
        public CurrentPassCollection(List<Monthly> currentPass)
        {
            this.currentPass = new List<Monthly>();
        }
        public void RenewPass() { }
    }
}
