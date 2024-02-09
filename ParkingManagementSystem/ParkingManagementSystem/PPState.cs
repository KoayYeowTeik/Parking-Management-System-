using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem
{
    public interface PPState
    {
        void approvePass(MonthlyPassCollection collection);

		void enterCarpark();

        void exitCarpark();

        void renew(MonthlyPassCollection collection);

        void terminate(string reason, MonthlyPassCollection collection);
    }
}
