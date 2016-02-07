using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seasharpconcepts.AbstractExample
{
    class ContractEmployee : BaseEmployee
    {
        public int HourlyPay { get; set; }
        public int TotalHoursWorked { get; set; }

        public override int GetMonthlySalary()
        {
            return HourlyPay * TotalHoursWorked;
        }

    }

    class ContractEmployee2 : ContractEmployee
    {
        
        public override int GetMonthlySalary()
        {
            return HourlyPay * TotalHoursWorked;
        }

    }
}
