using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem
{
    public interface PPState
    {
        void approvePass();

		void enterCarpark();

        void exitCarpark();

        void renew();

        void terminate(string reason);
    }
}
