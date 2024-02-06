using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem
{
    public class FinancialReport
    {
        public double StaffRevenue { get; private set; }
        public double StudentRevenue { get; private set; }

        public FinancialReport(double staffRevenue, double studentRevenue)
        {
            StaffRevenue = staffRevenue;
            StudentRevenue = studentRevenue;
        }

        // This method would calculate and create the financial report
        public void CreateReport()
        {
            // Implementation to create the report goes here
            // It could involve calculating totals, formatting the report, etc.
        }
    }
}
