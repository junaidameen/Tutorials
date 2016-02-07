using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seasharpconcepts.AbstractExample
{
    class AbstractExample
    {
        static void Main(string[] args)
        {

            //BaseEmployee bte = new BaseEmployee()
            //{
            //    ID = 139435,
            //    FirstName = "Junaid",
            //    LastName = "Ameen"
            //};

            //Console.WriteLine(bte.GetFullName());


            FullTimeEmployee fte = new FullTimeEmployee()
            {
                ID = 139435,
                FirstName = "Junaid",
                LastName = "Ameen",
                AnnualSalary = 60000
            };


            ContractEmployee cte = new ContractEmployee()
            {
                ID = 139435,
                FirstName = "John",
                LastName = "Mark",
                HourlyPay = 200,
                TotalHoursWorked = 100
            };

            Console.WriteLine(cte.GetFullName());
            Console.WriteLine(cte.GetMonthlySalary());
            Console.WriteLine("------------");
            Console.WriteLine(fte.GetFullName());
            Console.WriteLine(fte.GetMonthlySalary());

            Console.ReadLine();
        }

    }
 
}
