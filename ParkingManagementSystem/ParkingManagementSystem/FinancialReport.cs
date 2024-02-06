using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem
{
    public class FinancialReport
    {
        public decimal staffRevenue { get; private set; }
        public decimal studentRevenue { get; private set; }
        public decimal totalRevenue { get; private set; }    
        public FinancialReport() { }   

        public FinancialReport(decimal staffRevenue, decimal studentRevenue, decimal totalRevenue)
        {
            this.staffRevenue = staffRevenue;
            this.studentRevenue = studentRevenue;
            this.totalRevenue = totalRevenue;
        }

        // This method would calculate and create the financial report
        public void CreateReport()
        {
            // Implementation
        }
    }
}
